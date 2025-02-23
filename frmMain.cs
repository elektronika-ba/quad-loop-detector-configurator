using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

/**
 * Note: References for speed measurement config are still in here,
 * future version of 4-channel firmware will most likely implement it.
 **/

namespace QLDConfig1v2
{
    public partial class frmMain : Form
    {
        const int _XTAL_FREQ = 32000000; // 8MHz crystal * PLL(4) = 32MHz
        const int _XTAL_FREQ_KHZ = (_XTAL_FREQ / 1000);
        const int _TMR1_FREQ = (_XTAL_FREQ / 4 / 2); // TMR1 je Fosc/4 i ima jos prescaled 1:2 pa je zato /4/2
        const int _TMR1_FREQ_KHZ = (_TMR1_FREQ / 1000);
        const int _TMR0_RELOADER_MAX = 130;
        const int _TMR0_PRESCALER_MAX = 0b00000100;
        const int _UART_COMM_MODE_ENTER_DELAY_MS = 3000; // 3 seconds max wait for entering into comm uart mode
        const char _UART_START_CHAR = (char)26;	// 26 = CTRL+Z
        const int EE_SIZE = 82; // 82 bytes, *2 in hexa
        const int FREQ_ANA_BUFFER_SIZE = 4096;
        const int SHORTEST_SPEED_TIME_MS = 2500; // ms

        private List<byte> spData = new List<byte>();
        private const string commandTerminator = "END>\r\n";
        private const string crlf = "\r\n";

        private string saveAnalysisFolder = "";

        private SQLiteConnection sqliteConn = new SQLiteConnection("Data Source=event_logger.db;Version=3");

        private enum TRXState
        {
            Running, // device is running (resumed operation)
            Comm, // device is in uart communication state, waiting for our command
            Comm_Setting, // device is in uart communication mode, we initiated SET command and now we are working it
        }

        /*
            Event code	Event description
            ---------------------------------
            01,xxx.yyy	Undetect, xxx.yyy=strength of detection in percentages in fixed format 000.000
            02,xxx.yyy	Rollaway, did not stop, xxx.yyy=strength of detection in percentages in fixed format 000.000
            03,xxx.yyy	Undetect because of PPC, xxx.yyy=strength of detection in percentages in fixed format 000.000
            04,xxxxx	Movement while stopped, x=change in fixed format 00000
            05,xxxxx	Movement before stopped, x=change in fixed format 00000
            06,xxx.yyy	Repeated stop detected, xxx.yyy=strength of detection in percentages in fixed format 000.000
            07,xxx.yyy	Initial stop detected, xxx.yyy=strength of detection in percentages in fixed format 000.000
            08		    Detect! (detection strength can't be calculated yet)
            09		    Movement after-PPC
            //10,xxx		Speed in km/h or mile/h in fixed 000 format
            11		    Canceled A->B direction
            12		    Going back B->A direction
            13		    Passed B->A
            14		    Cancelled B->A direction
            15		    Going back A->B
            16		    Passed A->B
        */

        /*private enum TEventCode
        {
            Undetect = 1,
            Rollaway = 2,
            UndetectPPC = 3,
            MovementWhileStopped = 4,
            MovementBeforeStopped = 5,
            RepeatedStopDetected = 6,
            InitialStopDetected = 7,
            Detect = 8,
            MovementAfterPPC = 9,
            //SpeedReport = 10,
            DirectionA2BCancel = 11,
            DirectionB2AGoingBack = 12,
            DirectionB2APassed = 13,
            DirectionB2ACancel = 14,
            DirectionA2BGoingBack = 15,
            DirectionA2BPassed = 16,
        }*/

        Dictionary<int, string> EventName = new Dictionary<int, string>()
        {
            { 1, "Undetect, strength: $%" },
            { 2, "Rollaway without stopping, strength: $%" },
            { 3, "Undetect because of PPC, strength: $%" },
            { 4, "Movement while stop detected, change: $" },
            { 5, "Movement before stopping, change: $" },
            { 6, "Repeated stop detected, strength: $%" },
            { 7, "Initial stop detected, strength: $%" },
            { 8, "Detect" },
            { 9, "Movement after PPC" },
            //{ 10, "Speed report: $" },
            { 11, "1->2 pass cancelled" },
            { 12, "2->1 going back" },
            { 13, "2->1 passed" },
            { 14, "2->1 pass cancel" },
            { 15, "1->2 going back" },
            { 16, "1->2 passed" },
        };

        // list of events for directional logic
        List<int> EventForDirlogic = new List<int>() { 11, 12, 13, 14, 15, 16 };

        // used during programming (sending data to device)
        private int commSettingIndex = 0;
        private string hex2send = "";

        private TRXState rxState = TRXState.Running; // running at app startup (we assume)

        private class TDeviceStuff
        {
            public TDeviceStuff()
            {
                freq = new List<double>(4);
                err = new List<int>(4);
                lastEvent = new List<string>(4);
                genDIPs = new List<byte>(4); // there are 4 dips with 4 bits in system. one 4-bit dip for each channel
                freqAna = new List<CirBuff<double>>(4);
                detectState = new List<bool>(4);
                freqAna4Save = new List<List<double>>(4);
                for (int i = 0; i < 4; i++)
                {
                    freq.Add(0.0);
                    err.Add(-1);
                    lastEvent.Add("");
                    detectState.Add(false);
                    freqAna.Add(new CirBuff<double>(FREQ_ANA_BUFFER_SIZE));
                    freqAna4Save.Add(new List<double>());
                    genDIPs.Add(0);
                }
            }
            public List<double> freq { get; set; }
            public List<int> err { get; set; }
            public List<string> lastEvent { get; set; }
            public List<byte> genDIPs { get; set; }
            public List<bool> detectState { get; set; }
            public List<CirBuff<double>> freqAna { get; set; }
            public List<List<double>> freqAna4Save { get; set; }
        };

        private TDeviceStuff deviceStuff = new TDeviceStuff();

        private TaskFactory uiFactory;

        [Serializable]
        public class TConfigPacket
        {
            public TConfigPacket()
            {

            }

            public TConfigPacket(bool init)
            {
                // TODO: Ovdje defaultne vrijednosti stavi, iz Firmware-a iste !
                this.filterNormal = new TFiltering(100, 90, 4);
                this.filterMore = new TFiltering(50, 40, 8);
                this.sensitivities = new List<TSensitivity>(8);
                for (int i = 0; i < 8; i++)
                {
                    this.sensitivities.Add(new TSensitivity(1, 1));
                }
                this.softDIP1 = 0x00;
                this.softDIP2 = 0x00;
                this.dcddThreshold = 1;
                this.dcddTmr = 1;
                this.detectStopSlowCheckerTmr = 1;
                this.detectStopThreshold = 1;
                this.detectStopTmr = 1;
                this.ppcDetectLeftThreshold = 1;
                this.ppcDetectLeftTmr = 1;
                this.ppcTimeShort = 1;
                this.ppcTimeMedium = 1;
                this.ppcTimeLong = 1;
                this.sensitivityLoop = new List<byte>(4);
                this.relDurNormal = new List<byte>(4);
                this.relDurExtended = new List<byte>(4);
                this.tmr1Best = 40000;
                this.useSoftDIPs = 0x00;
                this.chDIP1 = new List<byte>(4);
                this.chDIP2 = new List<byte>(4);
                this.relDelay = new List<byte>(4);
                this.slowStartTmr = 1;
                this.runtimeRecalibSchedTmr = 1;
                this.validVal = 0xAA;
                this.baudRate = 0;

                for (int i = 0; i < 4; i++) // 4 channels
                {
                    this.relDurNormal.Add(1);
                    this.relDurExtended.Add(1);
                    this.sensitivityLoop.Add(4);
                    this.chDIP1.Add(0x10);
                    this.chDIP2.Add(0x10);
                    this.relDelay.Add(1);
                }
            }

            public class TFiltering
            {
                public TFiltering()
                {
                    this.negativeDriftTmr = 1;
                    this.positiveDriftTmr = 1;
                    this.counterArrayLength = 1;
                }

                public TFiltering(byte negativeDriftTmr, byte positiveDriftTmr, byte counterArrayLength)
                {
                    this.negativeDriftTmr = negativeDriftTmr;
                    this.positiveDriftTmr = positiveDriftTmr;
                    this.counterArrayLength = counterArrayLength;
                }
                public byte counterArrayLength { get; set; }
                public byte negativeDriftTmr { get; set; }
                public byte positiveDriftTmr { get; set; }
            }

            public class TSensitivity
            {
                public TSensitivity()
                {
                    this.onThreshold = 1;
                    this.offThreshold = 1;
                }
                public TSensitivity(ushort onThreshold, ushort offThreshold)
                {
                    this.onThreshold = onThreshold;
                    this.offThreshold = offThreshold;
                }
                public ushort onThreshold { get; set; }
                public ushort offThreshold { get; set; }
            }

            public byte validVal { get; set; }
            public TFiltering filterNormal { get; set; }
            public TFiltering filterMore { get; set; }
            public List<TSensitivity> sensitivities { get; set; }
            public byte detectStopTmr { get; set; }
            public byte detectStopThreshold { get; set; }
            public ushort dcddTmr { get; set; }
            public byte dcddThreshold { get; set; }
            public byte useSoftDIPs { get; set; }
            public byte softDIP1 { get; set; }
            public byte softDIP2 { get; set; }
            public byte ppcTimeShort { get; set; }
            public byte ppcTimeMedium { get; set; }
            public byte ppcTimeLong { get; set; }
            public byte ppcDetectLeftTmr { get; set; }
            public byte ppcDetectLeftThreshold { get; set; }
            public List<byte> relDurNormal { get; set; }
            public List<byte> relDurExtended { get; set; }
            public ushort tmr1Best { get; set; }
            public byte detectStopSlowCheckerTmr { get; set; }
            public byte baudRate { get; set; }
            public List<byte> sensitivityLoop { get; set; }
            public List<byte> chDIP1 { get; set; }
            public List<byte> chDIP2 { get; set; }
            public List<byte> relDelay { get; set; }
            public ushort slowStartTmr { get; set; }
            public byte runtimeRecalibSchedTmr { get; set; }
        }

        private TConfigPacket configPacket = new TConfigPacket(true);

        /**
         * Updates current config packet with data from form.
         **/
        public void updateConfigPacket()
        {
            // tmr1 best
            configPacket.tmr1Best = (ushort)uctbSamplingSpeed.Value;

            // DIPs
            configPacket.softDIP1 = 0x00;
            foreach (Control c in gbDIP1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    int bitWeight = int.Parse(cb.Tag.ToString());
                    if (cb.Checked)
                    {
                        configPacket.softDIP1 += (byte)Math.Pow(2, bitWeight);
                    }
                }
            }
            configPacket.softDIP2 = 0x00;
            foreach (Control c in gbDIP2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    int bitWeight = int.Parse(cb.Tag.ToString());
                    if (cb.Checked)
                    {
                        configPacket.softDIP2 += (byte)Math.Pow(2, bitWeight);
                    }
                }
            }

            // we can copy ONLY active channel-related DIP to packet because we have just one set of checkboxes for all channels...
            int channelIdx = findSelectedChannelIndexOfChannelRelatedDIPs();

            // DIP 1
            configPacket.chDIP1[channelIdx] = 0x00;
            foreach (Control c in gbCHDIP1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    int bitWeight = int.Parse(cb.Tag.ToString());
                    if (cb.Checked)
                    {
                        configPacket.chDIP1[channelIdx] += (byte)Math.Pow(2, bitWeight);
                    }
                }
            }

            // DIP 2
            configPacket.chDIP2[channelIdx] = 0x00;
            foreach (Control c in gbCHDIP2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    int bitWeight = int.Parse(cb.Tag.ToString());
                    if (cb.Checked)
                    {
                        configPacket.chDIP2[channelIdx] += (byte)Math.Pow(2, bitWeight);
                    }
                }
            }

            // using soft dips for general DIPs?
            configPacket.useSoftDIPs = ckUseSoftDIPs.Checked ? (byte)0xFF : (byte)0x00;

            // sensitivity stuff
            // pre-set sensitivity bank for each channel
            configPacket.sensitivityLoop[0] = (byte)(cbSensitivityA.SelectedIndex + 1);
            configPacket.sensitivityLoop[1] = (byte)(cbSensitivityB.SelectedIndex + 1);
            configPacket.sensitivityLoop[2] = (byte)(cbSensitivityC.SelectedIndex + 1);
            configPacket.sensitivityLoop[3] = (byte)(cbSensitivityD.SelectedIndex + 1);

            // sensitivity thresholds for currently selected channel in the dropdown
            if (cbSensitivityForBank.SelectedIndex > -1)
            {
                configPacket.sensitivities[cbSensitivityForBank.SelectedIndex] = new TConfigPacket.TSensitivity((ushort)uctbSensitivityDetectThreshold.Value, (ushort)uctbSensitivityUndetectThreshold.Value);
            }

            // filtering stuff
            if (cbFilteringLevel.SelectedIndex == 0)
            {
                configPacket.filterNormal = new TConfigPacket.TFiltering((byte)uctbFilteringNegative.Value, (byte)uctbFilteringPositive.Value, (byte)uctbFilteringAveraging.Value);
            }
            else if (cbFilteringLevel.SelectedIndex == 1)
            {
                configPacket.filterMore = new TConfigPacket.TFiltering((byte)uctbFilteringNegative.Value, (byte)uctbFilteringPositive.Value, (byte)uctbFilteringAveraging.Value);
            }

            // relay pulse durations
            configPacket.relDurNormal[0] = (byte)uctbRelayAPulseNormal.Value;
            configPacket.relDurExtended[0] = (byte)uctbRelayAPulseExtended.Value;
            configPacket.relDurNormal[1] = (byte)uctbRelayBPulseNormal.Value;
            configPacket.relDurExtended[1] = (byte)uctbRelayBPulseExtended.Value;
            configPacket.relDurNormal[2] = (byte)uctbRelayCPulseNormal.Value;
            configPacket.relDurExtended[2] = (byte)uctbRelayCPulseExtended.Value;
            configPacket.relDurNormal[3] = (byte)uctbRelayDPulseNormal.Value;
            configPacket.relDurExtended[3] = (byte)uctbRelayDPulseExtended.Value;

            // ppc related
            configPacket.ppcTimeShort = (byte)uctbPPCShort.Value;
            configPacket.ppcTimeMedium = (byte)uctbPPCMedium.Value;
            configPacket.ppcTimeLong = (byte)uctbPPCLong.Value;
            configPacket.ppcDetectLeftTmr = (byte)uctbPPCDetLeftTimer.Value;
            configPacket.ppcDetectLeftThreshold = (byte)uctbPPCDetLeftThreshold.Value;

            // detect stop
            configPacket.detectStopTmr = (byte)uctbDetStopTimer.Value;
            configPacket.detectStopThreshold = (byte)uctbDetStopThreshold.Value;
            configPacket.detectStopSlowCheckerTmr = (byte)uctbDetStopSlowCheckerTimer.Value;

            // dcdd
            configPacket.dcddTmr = (ushort)uctbDCDDTimer.Value;
            configPacket.dcddThreshold = (byte)uctbDCDDThreshold.Value;
            
            // baudrate
            configPacket.baudRate = (byte)cbBaudRate.SelectedIndex;

            // output delayed activation
            configPacket.relDelay[0] = (byte)uctbRelayADelayAct.Value;
            configPacket.relDelay[1] = (byte)uctbRelayBDelayAct.Value;
            configPacket.relDelay[2] = (byte)uctbRelayCDelayAct.Value;
            configPacket.relDelay[3] = (byte)uctbRelayDDelayAct.Value;

            // slow startup (warm up)
            configPacket.slowStartTmr = (byte)uctbSlowStartupTimer.Value;

            // runtime recalibration timer
            configPacket.runtimeRecalibSchedTmr = (byte)uctbRuntimeRecalibTmr.Value;
        }

        /**
         * Puts current config packet to screen/form.
         **/
        public void configPacketToScreen(bool onlyGenDIPs = false)
        {
            // General DIPs
            foreach (Control c in gbDIP1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    int bitWeight = int.Parse(cb.Tag.ToString());
                    cb.Checked = false;
                    if ((configPacket.softDIP1 & (byte)Math.Pow(2, bitWeight)) > 0)
                    {
                        cb.Checked = true;
                    }
                }
            }
            foreach (Control c in gbDIP2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    int bitWeight = int.Parse(cb.Tag.ToString());
                    cb.Checked = false;
                    if ((configPacket.softDIP2 & (byte)Math.Pow(2, bitWeight)) > 0)
                    {
                        cb.Checked = true;
                    }
                }
            }

            // if only DIPs should be updated on screen, end here
            if (onlyGenDIPs)
            {
                return;
            }

            // Channel related DIPs
            rbCHDIPsA.Checked = true; // this will trigger the CheckChanged() event
            repaintChannelRelatedDIPsSelection();

            // tmr1 best
            uctbSamplingSpeed.Value = configPacket.tmr1Best;

            // using soft dips?
            ckUseSoftDIPs.Checked = configPacket.useSoftDIPs == 0xFF;

            // sensitivity stuff
            // pre-set sensitivity bank for each channel
            cbSensitivityA.SelectedIndex = configPacket.sensitivityLoop[0] - 1;
            cbSensitivityB.SelectedIndex = configPacket.sensitivityLoop[1] - 1;
            cbSensitivityC.SelectedIndex = configPacket.sensitivityLoop[2] - 1;
            cbSensitivityD.SelectedIndex = configPacket.sensitivityLoop[3] - 1;

            cbSensitivityForBank.SelectedIndex = 0; // show first option on screen, others will be loaded on user-change
            uctbSensitivityDetectThreshold.Value = configPacket.sensitivities[0].onThreshold;
            uctbSensitivityUndetectThreshold.Value = configPacket.sensitivities[0].offThreshold;

            // filtering stuff
            cbFilteringLevel.SelectedIndex = 0; // show first option on screen, others will be loaded on user-change
            uctbFilteringNegative.Value = configPacket.filterNormal.negativeDriftTmr;
            uctbFilteringPositive.Value = configPacket.filterNormal.positiveDriftTmr;
            uctbFilteringAveraging.Value = configPacket.filterNormal.counterArrayLength;
            
            // relay pulse durations
            uctbRelayAPulseNormal.Value = configPacket.relDurNormal[0];
            uctbRelayAPulseNormal.TriggerChange(null, null);
            uctbRelayAPulseExtended.Value = configPacket.relDurExtended[0];
            uctbRelayAPulseExtended.TriggerChange(null, null);
            
            uctbRelayBPulseNormal.Value = configPacket.relDurNormal[1];
            uctbRelayBPulseNormal.TriggerChange(null, null);
            uctbRelayBPulseExtended.Value = configPacket.relDurExtended[1];
            uctbRelayBPulseExtended.TriggerChange(null, null);

            uctbRelayCPulseNormal.Value = configPacket.relDurNormal[2];
            uctbRelayCPulseNormal.TriggerChange(null, null);
            uctbRelayCPulseExtended.Value = configPacket.relDurExtended[2];
            uctbRelayCPulseExtended.TriggerChange(null, null);

            uctbRelayDPulseNormal.Value = configPacket.relDurNormal[3];
            uctbRelayDPulseNormal.TriggerChange(null, null);
            uctbRelayDPulseExtended.Value = configPacket.relDurExtended[3];
            uctbRelayDPulseExtended.TriggerChange(null, null);

            // ppc related
            uctbPPCShort.Value = configPacket.ppcTimeShort;
            uctbPPCShort.TriggerChange(null, null);
            uctbPPCMedium.Value = configPacket.ppcTimeMedium;
            uctbPPCMedium.TriggerChange(null, null);
            uctbPPCLong.Value = configPacket.ppcTimeLong;
            uctbPPCLong.TriggerChange(null, null);

            uctbPPCDetLeftTimer.Value = configPacket.ppcDetectLeftTmr;
            uctbPPCDetLeftThreshold.Value = configPacket.ppcDetectLeftThreshold;

            // detect stop
            uctbDetStopTimer.Value = configPacket.detectStopTmr;
            uctbDetStopThreshold.Value = configPacket.detectStopThreshold;
            uctbDetStopSlowCheckerTimer.Value = configPacket.detectStopSlowCheckerTmr;
            uctbDetStopSlowCheckerTimer.TriggerChange(null, null);

            // dcdd
            uctbDCDDTimer.Value = configPacket.dcddTmr;
            uctbDCDDThreshold.Value = configPacket.dcddThreshold;

            // baud rate
            try
            {
                cbBaudRate.SelectedIndex = configPacket.baudRate;
            }
            catch(Exception)
            {
                cbBaudRate.SelectedIndex = 0;
            }

            // output delayed activation
            uctbRelayADelayAct.Value = configPacket.relDelay[0];
            uctbRelayADelayAct.TriggerChange(null, null);

            uctbRelayBDelayAct.Value = configPacket.relDelay[1];
            uctbRelayBDelayAct.TriggerChange(null, null);

            uctbRelayCDelayAct.Value = configPacket.relDelay[2];
            uctbRelayCDelayAct.TriggerChange(null, null);

            uctbRelayDDelayAct.Value = configPacket.relDelay[3];
            uctbRelayDDelayAct.TriggerChange(null, null);

            // slow startup (warm up)
            uctbSlowStartupTimer.Value = configPacket.slowStartTmr;
            uctbSlowStartupTimer.TriggerChange(null, null);

            // runtime recalibration timer
            uctbRuntimeRecalibTmr.Value = configPacket.runtimeRecalibSchedTmr;
            uctbRuntimeRecalibTmr.TriggerChange(null, null);

            // trigger change event on sampling speed, so that everything that depends on it gets updated
            uctbSamplingSpeed.TriggerChange(null, null);
        }

        private TConfigPacket parseHexaConfigPacket(string hexaConfigPacket)
        {
            TConfigPacket parsedConfigPacket = new TConfigPacket(true);

            int index = 0;
            string hex = "";

            try
            {
                // validVal
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.validVal = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // current system sensitivities: 4 bytes, channel A B C and D
                for (int i = 0; i < 4; i++)
                {
                    hex = hexaConfigPacket.Substring(index, 2);
                    index += hex.Length;
                    parsedConfigPacket.sensitivityLoop[i] = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                }

                // filtering: 3 bytes * 2banks, counter length, negative, positive
                // normal filtering
                // counter
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.filterNormal.counterArrayLength = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                // negative
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.filterNormal.negativeDriftTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                // positive
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.filterNormal.positiveDriftTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                // more filtering
                // counter
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.filterMore.counterArrayLength = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                // negative
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.filterMore.negativeDriftTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                // positive
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.filterMore.positiveDriftTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // sensitivities: 8 * 2bytes * 4loops
                for (int i = 0; i < 8; i++)
                {
                    // on threshold
                    hex = hexaConfigPacket.Substring(index, 4);
                    index += hex.Length;
                    parsedConfigPacket.sensitivities[i].onThreshold = ushort.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                    // off threshold
                    hex = hexaConfigPacket.Substring(index, 4);
                    index += hex.Length;
                    parsedConfigPacket.sensitivities[i].offThreshold = ushort.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                }

                // detect stop, prvi dio
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.detectStopTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.detectStopThreshold = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // detect stop, drugi dio
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.detectStopSlowCheckerTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // detect left for PPC
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.ppcDetectLeftTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.ppcDetectLeftThreshold = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // dcdd
                hex = hexaConfigPacket.Substring(index, 4);
                index += hex.Length;
                parsedConfigPacket.dcddTmr = ushort.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.dcddThreshold = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // ppc
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.ppcTimeShort = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.ppcTimeMedium = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.ppcTimeLong = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // pulse durations
                for (int i = 0; i < 4; i++)
                {
                    hex = hexaConfigPacket.Substring(index, 2);
                    index += hex.Length;
                    parsedConfigPacket.relDurNormal[i] = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                    hex = hexaConfigPacket.Substring(index, 2);
                    index += hex.Length;
                    parsedConfigPacket.relDurExtended[i] = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                }

                // TMR1_BEST
                hex = hexaConfigPacket.Substring(index, 4);
                index += hex.Length;
                parsedConfigPacket.tmr1Best = ushort.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // soft dips
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.useSoftDIPs = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // software General DIP-A
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.softDIP1 = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                // software General DIP-B
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.softDIP2 = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // channel specific DIPs
                // 2 * 4channels
                for (int i = 0; i < 4; i++)
                {
                    // DIP-A
                    hex = hexaConfigPacket.Substring(index, 2);
                    index += hex.Length;
                    parsedConfigPacket.chDIP1[i] = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                    // DIP-B
                    hex = hexaConfigPacket.Substring(index, 2);
                    index += hex.Length;
                    parsedConfigPacket.chDIP2[i] = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                }

                // baud rate
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.baudRate = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // output delayed activation timers
                for (int i = 0; i < 4; i++)
                {
                    hex = hexaConfigPacket.Substring(index, 2);
                    index += hex.Length;
                    parsedConfigPacket.relDelay[i] = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                }

                // slow startup (warm up) timer
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.slowStartTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                // runtime loop recalibration scheduler
                hex = hexaConfigPacket.Substring(index, 2);
                index += hex.Length;
                parsedConfigPacket.runtimeRecalibSchedTmr = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Error parsing data received from device!", "Error");
                return null;
            }

            return parsedConfigPacket;
        }

        private string encodeHexaConfigPacket(TConfigPacket configPacket)
        {
            string hex = "";

            // validVal first (it will always be valid...)
            hex += configPacket.validVal.ToString("X2");

            // current system sensitivities: 4 bytes, channel A B C and D
            for (int i = 0; i < 4; i++)
            {
                hex += configPacket.sensitivityLoop[i].ToString("X2");
            }

            // filtering: 3 bytes * 2banks, counter length, negative, positive
            // normal
            // counter
            hex += configPacket.filterNormal.counterArrayLength.ToString("X2");
            // negative
            hex += configPacket.filterNormal.negativeDriftTmr.ToString("X2");
            // positive
            hex += configPacket.filterNormal.positiveDriftTmr.ToString("X2");
            // more
            // counter
            hex += configPacket.filterMore.counterArrayLength.ToString("X2");
            // negative
            hex += configPacket.filterMore.negativeDriftTmr.ToString("X2");
            // positive
            hex += configPacket.filterMore.positiveDriftTmr.ToString("X2");

            // sensitivities: 8 * 2bytes * 4loops
            // a
            for (int i = 0; i < 8; i++)
            {
                // on threshold
                hex += configPacket.sensitivities[i].onThreshold.ToString("X4");

                // off threshold
                hex += configPacket.sensitivities[i].offThreshold.ToString("X4");
            }

            // detect stop, prvi dio
            hex += configPacket.detectStopTmr.ToString("X2");
            hex += configPacket.detectStopThreshold.ToString("X2");

            // detect stop, drugi dio
            hex += configPacket.detectStopSlowCheckerTmr.ToString("X2");

            // detect left for PPC
            hex += configPacket.ppcDetectLeftTmr.ToString("X2");
            hex += configPacket.ppcDetectLeftThreshold.ToString("X2");

            // dcdd
            hex += configPacket.dcddTmr.ToString("X4");
            hex += configPacket.dcddThreshold.ToString("X2");

            // ppc
            hex += configPacket.ppcTimeShort.ToString("X2");
            hex += configPacket.ppcTimeMedium.ToString("X2");
            hex += configPacket.ppcTimeLong.ToString("X2");

            // pulse durations
            for (int i = 0; i < 4; i++)
            {
                hex += configPacket.relDurNormal[i].ToString("X2");
                hex += configPacket.relDurExtended[i].ToString("X2");
            }

            // TMR1_BEST
            hex += configPacket.tmr1Best.ToString("X4");

            // soft dips
            hex += configPacket.useSoftDIPs.ToString("X2");

            // software General DIP-A
            hex += configPacket.softDIP1.ToString("X2");
            // software General DIP-B
            hex += configPacket.softDIP2.ToString("X2");

            // channel specific DIPs
            // 2 * 4channels
            for (int i = 0; i < 4; i++)
            {
                // DIP-A
                hex += configPacket.chDIP1[i].ToString("X2");
                // DIP-B
                hex += configPacket.chDIP2[i].ToString("X2");
            }

            // baudrate
            hex += configPacket.baudRate.ToString("X2");

            // output delayed activation timers
            for (int i = 0; i < 4; i++)
            {
                hex += configPacket.relDelay[i].ToString("X2");
            }

            // slow startup timer (warm up)
            hex += configPacket.slowStartTmr.ToString("X2");

            // runtime loop recalibration scheduler
            hex += configPacket.runtimeRecalibSchedTmr.ToString("X2");

            return hex;
        }

        public frmMain()
        {
            InitializeComponent();

            // make all components trigger updateConfigPacket()
            List<Control> c2check = findControlRecursively(this, "UPDATE_CONFIG_PACKET");
            foreach (Control c in c2check)
            {
                if (c is ucTrackBar)
                {
                    ((ucTrackBar)c).TrackbarChanged += new System.EventHandler(delegate (object sender, EventArgs e)
                    {
                        if (sender == null && e == null) return; // on our programmatic change, don't do this

                        tmrUpdateConfigPacket.Enabled = false;
                        tmrUpdateConfigPacket.Enabled = true;
                    });
                }
                else if (c is ComboBox)
                {
                    // https://stackoverflow.com/a/13452659
                    ((ComboBox)c).SelectionChangeCommitted += new System.EventHandler(delegate (object sender, EventArgs e)
                    {
                        if (sender == null && e == null) return; // on our programmatic change, don't do this

                        tmrUpdateConfigPacket.Enabled = false;
                        tmrUpdateConfigPacket.Enabled = true;
                    });
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).CheckedChanged += new System.EventHandler(delegate (object sender, EventArgs e)
                    {
                        if (sender == null && e == null) return; // on our programmatic change, don't do this

                        tmrUpdateConfigPacket.Enabled = false;
                        tmrUpdateConfigPacket.Enabled = true;
                    });
                }
            }

            // also make DIP checkboxes on-change trigger the updating of config packet
            List<Control> cl = new List<Control>
            {
                gbDIP1,
                gbDIP2,
                gbCHDIP1,
                gbCHDIP2
            };
            foreach (Control ch in cl)
            {
                foreach (Control c in ch.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).CheckedChanged += new System.EventHandler(delegate (object sender, EventArgs e)
                        {
                            if (sender == null && e == null) return; // on our programmatic change, don't do this

                            tmrUpdateConfigPacket.Enabled = false;
                            tmrUpdateConfigPacket.Enabled = true;
                        });
                    }
                }
            }

            cbCopyCHDIPsFrom.SelectedIndex = 0;
            cbQuickPresets.SelectedIndex = 0;

            // https://stackoverflow.com/a/14129252
            uiFactory = new TaskFactory(TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            tssDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // use this timer also for displaying current loops frequencies in the statusbar
            tssFrequencyLoopA.Text = tssFrequencyLoopA.Tag.ToString().Replace("%", deviceStuff.freq[0].ToString("0.00", CultureInfo.InvariantCulture));
            tssFrequencyLoopB.Text = tssFrequencyLoopB.Tag.ToString().Replace("%", deviceStuff.freq[1].ToString("0.00", CultureInfo.InvariantCulture));
            tssFrequencyLoopC.Text = tssFrequencyLoopC.Tag.ToString().Replace("%", deviceStuff.freq[2].ToString("0.00", CultureInfo.InvariantCulture));
            tssFrequencyLoopD.Text = tssFrequencyLoopD.Tag.ToString().Replace("%", deviceStuff.freq[3].ToString("0.00", CultureInfo.InvariantCulture));

            // also display state device is in
            string state = "Unknown";
            switch(rxState)
            {
                case TRXState.Comm:
                case TRXState.Comm_Setting:
                    state = "Communicating";
                    break;
                case TRXState.Running:
                    state = "Running";
                    break;
            }
            tssDeviceState.Text = tssDeviceState.Tag.ToString().Replace("%", state);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings s = new frmSettings();

            // popuni formu sa trneutnim podesenjima
            string comPort = Properties.Settings.Default.ComPort;
            int baudRate = Properties.Settings.Default.BaudRate;
            s.setFormData(comPort, baudRate);

            DialogResult r = s.ShowDialog();
            if (r == DialogResult.OK)
            {
                // snimi u settingse izmjene sa forme
                comPort = s.getComPort();
                baudRate = s.getBaudRate();

                Properties.Settings.Default.ComPort = comPort;
                Properties.Settings.Default.BaudRate = baudRate;
                Properties.Settings.Default.Save();
            }
        }

        /**
         * Selecting an item from the listbox menu on the left.
         * */
        private void lbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Panel)
                {
                    if (c.Tag != null && c.Tag.Equals(lbMenu.SelectedIndex.ToString()))
                    {
                        c.Visible = true;
                        c.Dock = DockStyle.Fill;
                        // find title label to copy the title from listbox menu
                        foreach (Control cl in ((Panel)c).Controls)
                        {
                            if (cl is Label && cl.Tag != null && ((Label)cl).Tag.Equals("title"))
                            {
                                ((Label)cl).Text = (string)lbMenu.SelectedItem;
                                break;
                            }
                        }
                    }
                    else c.Visible = false;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string strVersion = assembly.GetName().Version.Major.ToString() + "." + assembly.GetName().Version.Minor.ToString();
            this.Text = this.Text.Replace("$", strVersion);

            lbMenu.SelectedIndex = 0; // this will tigger lbMenu_SelectedIndexChanged

            // put default config packet to screen
            configPacketToScreen();

            // try to initialize SQLite database (within 2 seconds max)
            ckEventViewerSaveToSQLite.Enabled = false;
            try
            {
                Stopwatch sw = new Stopwatch();
                sqliteConn.Open();
                sw.Restart();
                while (sqliteConn.State != System.Data.ConnectionState.Open)
                {
                    // I am not happy with this, but...
                    Application.DoEvents();

                    if (sw.Elapsed.TotalSeconds >= 2) break;
                }
                sw.Stop();

                if(sqliteConn.State != System.Data.ConnectionState.Open)
                {
                    throw new Exception();
                }

                // make sure there is "event_log" table in the DB
                SQLiteCommand command = sqliteConn.CreateCommand();
                command.CommandText = "SELECT name FROM sqlite_master WHERE name='event_log'";
                var name = command.ExecuteScalar();
                if (name == null || name.ToString() != "event_log")
                {
                    command.CommandText = "CREATE TABLE event_log (id INTEGER PRIMARY KEY AUTOINCREMENT, event_id INTEGER, event_group_id INTEGER, event_param TEXT, event_description TEXT, event_timestamp TEXT, event_unix_timestamp INTEGER)";
                    command.ExecuteNonQuery();
                }

                ckEventViewerSaveToSQLite.Enabled = true;
            }
            catch (Exception)
            {
                sqliteConn = null;
                MessageBox.Show("Failure with SQLite functions. SQLite logging will not be available.", "SQLite");
            }
        }

        private void ucTrackBar1_TrackbarChanged(object sender, EventArgs e)
        {
            TMR1BestChanged(uctbSamplingSpeed.Value);
        }

        private void TMR1BestChanged(int tmr1best)
        {
            string info;

            // sampling speed information
            info = lblTmr1SamplingSpeed.Tag.ToString();
            double speed = ((1.0 / _TMR1_FREQ) * tmr1best) * 1000.0; // (1/_TMR1_FREQ) * TMR1_BEST * 1000 da bi pretvorio u ms 
            info = info.Replace("%", speed.ToString("0.00"));
            lblTmr1SamplingSpeed.Text = info;

            // table of best sensitivities for chosen TMR1_BEST value, in timer to work slower
            tmrSensitivitiesExampleGenerator.Stop();
            tmrSensitivitiesExampleGenerator.Start();
            tmrSensitivitiesExampleGenerator.Enabled = true;
        }

        private void tmrSensitivitiesExampleGenerator_Tick(object sender, EventArgs e)
        {
            chartFreqVsSens.Series.Clear();
            var seriesChart = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "FrequencyVsSensitivity",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                BorderWidth = 3,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            };

            chartFreqVsSens.Series.Add(seriesChart);

            tmrSensitivitiesExampleGenerator.Enabled = false;
            tblSensitivityExamples.Rows.Clear();
            for (double freq = 20; freq <= 200; freq += 5)
            {
                DataGridViewRow r = new DataGridViewRow();

                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                c1.Value = freq;
                r.Cells.Add(c1);

                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                double bps = calcFreqResolution(freq, uctbSamplingSpeed.Value);
                if (bps == -1)
                {
                    c2.Value = "Freq. too low!";
                }
                else
                {
                    c2.Value = bps.ToString("0.00");
                }
                r.Cells.Add(c2);

                if (bps > 0)
                {
                    seriesChart.Points.AddXY(freq, bps);
                }

                tblSensitivityExamples.Rows.Add(r);
            }

            chartFreqVsSens.Invalidate();

            // trigger all components that depend on us to recalculate their stuff
            List<Control> c2check = findControlRecursively(this, "TMR1BEST_CHANGE");
            foreach (Control c in c2check)
            {
                if (c is ucTrackBar)
                {
                    ((ucTrackBar)c).TriggerChange(null, null);
                }
            }
        }

        public List<Control> findControlRecursively(Control cont, string tag)
        {
            List<Control> ret = new List<Control>();

            foreach (Control c in cont.Controls)
            {
                ret.AddRange(findControlRecursively(c, tag));
            }

            string[] tagListArr = new string[0];
            if (cont.Tag != null)
            {
                try
                {
                    tagListArr = ((string)cont.Tag).Split(';');
                }
                catch(Exception)
                {
                    #warning "OVDJE SAM STAVIO TRY...CATCH, ODJEDNOM JE POSTALO POTREBNO. ZASTO???"
                }
            }
            List<string> tagList = new List<string>(tagListArr);

            if (tagList.Contains(tag))
            {
                ret.Add(cont);
            }

            return ret;
        }

        private double tmr12freq(int tmr1Val, int prescVal, byte reloader)
        {
            return (((255.0 - reloader) * prescVal * _TMR1_FREQ_KHZ) / tmr1Val);
        }

        private int freq2tmr1(double freq, int prescVal, byte reloader)
        {
            return (int)(((255.0 - reloader) * prescVal * _TMR1_FREQ_KHZ) / freq);
        }

        private double calcFreqResolution(double freq, int tmr1Best)
        {
            // Djelimicno portano iz PIC-a
            // 1. prvo trazimo odgovarajuci prescaler
            byte prescaler = _TMR0_PRESCALER_MAX;
            int prescaler_value = (int)Math.Pow(2, prescaler) * 2;
            double tmr1_max_rp = (_TMR1_FREQ_KHZ * ((255 - _TMR0_RELOADER_MAX) * prescaler_value)) / freq;
            while (tmr1_max_rp > tmr1Best)
            {
                if (prescaler == 0)
                {
                    return -1; // too low frequency for this tmr1Best, will not operate!
                }

                tmr1_max_rp /= 2;
                prescaler--;
                prescaler_value /= 2;
            }
            // 2. onda trazimo reloader da bi dobili TMR1_BEST sa maloprije pronadjenim prescalerom
            double reloader = 255 - ((1.0 / prescaler_value) * tmr1Best * freq) / _TMR1_FREQ_KHZ;
            // end: Portano iz PIC-a

            int freq2tmr1a = freq2tmr1(freq, prescaler_value, (byte)reloader);
            double freqb = tmr12freq(freq2tmr1a - 1, prescaler_value, (byte)reloader);

            return (freqb - freq) * 1000;
        }

        private void uctbFilteringNegative_TrackbarChanged(object sender, EventArgs e)
        {
            displayFilteringTime(lblFilteringNegative, uctbFilteringNegative, uctbSamplingSpeed.Value);
        }

        private void uctbFilteringPositive_TrackbarChanged(object sender, EventArgs e)
        {
            displayFilteringTime(lblFilteringPositive, uctbFilteringPositive, uctbSamplingSpeed.Value);
        }

        private void displayFilteringTime(Label lbl, ucTrackBar uctb, int tmr1best)
        {
            string info = lbl.Tag.ToString();

            double speed = ((1.0 / _TMR1_FREQ) * tmr1best) * 1000.0; // (1/_TMR1_FREQ) * TMR1_BEST * 1000 da bi pretvorio u ms 
            speed = speed * 2 * uctb.Value; // *2 jer u firmware-u ga mnozim sa 2
            info = info.Replace("%", speed.ToString("0.00"));

            lbl.Text = info;
        }

        private void uctbRelayAPulseNormal_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayAPulseNormal.Tag.ToString();

            double dura = uctbRelayAPulseNormal.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayAPulseNormal.Text = info;
        }

        private void uctbRelayAPulseExtended_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayAPulseExtended.Tag.ToString();

            double dura = uctbRelayAPulseExtended.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayAPulseExtended.Text = info;
        }

        private void uctbPPC_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblPPCShort.Tag.ToString();

            TimeSpan span = TimeSpan.FromMinutes(uctbPPCShort.Value);
            info = info.Replace("%", span.ToString(@"hh\:mm"));

            lblPPCShort.Text = info;
        }

        private void uctbPPCDetLeftTimer_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblPPCDetLeaveTimer.Tag.ToString();

            double speed = ((1.0 / _TMR1_FREQ) * uctbSamplingSpeed.Value) * 1000.0; // (1/_TMR1_FREQ) * TMR1_BEST * 1000 da bi pretvorio u ms 
            speed = speed * uctbPPCDetLeftTimer.Value;
            info = info.Replace("%", speed.ToString("0.00"));

            lblPPCDetLeaveTimer.Text = info;

        }

        private void uctbDetStopTimer_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblDetectStopTimer.Tag.ToString();

            double speed = ((1.0 / _TMR1_FREQ) * uctbSamplingSpeed.Value) * 1000.0; // (1/_TMR1_FREQ) * TMR1_BEST * 1000 da bi pretvorio u ms 
            speed = speed * uctbDetStopTimer.Value;
            info = info.Replace("%", speed.ToString("0.00"));

            lblDetectStopTimer.Text = info;
        }

        private void uctbDetStopSlowCheckerTimer_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblDetectStopSlowCheckTimer.Tag.ToString();

            double dura = uctbDetStopSlowCheckerTimer.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblDetectStopSlowCheckTimer.Text = info;

        }

        private void uctbDCDDTimer_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblDCDDTimer.Tag.ToString();

            double speed = ((1.0 / _TMR1_FREQ) * uctbSamplingSpeed.Value) * 1000.0; // (1/_TMR1_FREQ) * TMR1_BEST * 1000 da bi pretvorio u ms 
            speed = speed * uctbDCDDTimer.Value;
            string sinfo;

            if (speed >= 1000)
            {
                TimeSpan span = TimeSpan.FromMilliseconds(speed);
                sinfo = span.ToString(@"mm\:ss") + " mm:ss";
            }
            else
            {
                sinfo = speed.ToString("0.00") + " ms";
            }
            info = info.Replace("%", sinfo);

            lblDCDDTimer.Text = info;
        }

        private void uctbSpeedDistance_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblSpeedLoopDistance.Tag.ToString();
            string sinfo;
            int distcm = uctbSpeedDistance.Value;

            if (distcm >= 100)
            {
                int distm = distcm / 100;
                int distcmr = distcm % 100;
                sinfo = distm + " m";
                if (distcmr > 0)
                {
                    sinfo += ", " + distcmr + " cm";
                }
            }
            else
            {
                sinfo = distcm + " cm";
            }
            info = info.Replace("%", sinfo);

            lblSpeedLoopDistance.Text = info;

            // (re)start timer to (re)calculate maximum possible speed
            tmrSpeedTrapErrorGenerator.Stop();
            tmrSpeedTrapErrorGenerator.Start();
            tmrSpeedTrapErrorGenerator.Enabled = true;
        }

        private void cbSensitivityForBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sensIndex = cbSensitivityForBank.SelectedIndex;

            TConfigPacket.TSensitivity sensy = configPacket.sensitivities[sensIndex];
            uctbSensitivityDetectThreshold.Value = sensy.onThreshold;
            uctbSensitivityUndetectThreshold.Value = sensy.offThreshold;
        }

        private void tmrUpdateConfigPacket_Tick(object sender, EventArgs e)
        {
            tmrUpdateConfigPacket.Enabled = false;
            updateConfigPacket();
        }

        private void cbFilteringLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            filteringLevelChanged(cbFilteringLevel.SelectedIndex);
        }

        private void filteringLevelChanged(int index)
        {
            TConfigPacket.TFiltering filty;
            if (index == 0)
            {
                filty = configPacket.filterNormal;
            }
            else if (index == 1)
            {
                filty = configPacket.filterMore;
            }
            else
            {
                throw new NotImplementedException();
            }

            uctbFilteringNegative.Value = filty.negativeDriftTmr;
            uctbFilteringPositive.Value = filty.positiveDriftTmr;
            uctbFilteringAveraging.Value = filty.counterArrayLength;

            uctbFilteringNegative.TriggerChange(null, null);
            uctbFilteringPositive.TriggerChange(null, null);
            uctbFilteringAveraging.TriggerChange(null, null);
        }

        private void uctbRelayBPulseNormal_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayBPulseNormal.Tag.ToString();

            double dura = uctbRelayBPulseNormal.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayBPulseNormal.Text = info;
        }

        private void uctbRelayBPulseExtended_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayBPulseExtended.Tag.ToString();

            double dura = uctbRelayBPulseExtended.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayBPulseExtended.Text = info;
        }

        private void openProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    configPacket = customSerializer.Load<TConfigPacket>(fileName);
                    configPacketToScreen();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error reading profile file.", "Error");
                }
            }
        }

        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    customSerializer.Save(fileName, configPacket);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error saving profile file.", "Error");
                }
            }
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configPacket = new TConfigPacket(true);
            configPacketToScreen();
        }

        private void readFromDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // send GET command
            if(!sendDataToDevice("G"))
            {
                MessageBox.Show("Failed to send command G to device. Please make sure baud rate setting is correct and try again.", "Error");
            }

            // handling of reception of data is in receiver parser
        }

        private void programDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // spakuj configPacket u hexadecimalni string pa da ga posaljemo na uredjaj
            hex2send = encodeHexaConfigPacket(configPacket);

            if(!sendDataToDevice("S")) // this will initiate the programming procedure
            {
                MessageBox.Show("Failed to send command S to device. Please make sure baud rate setting is correct and try again.", "Error");
            }

        }

        private void restartCPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!sendDataToDevice("Y"))
            {
                MessageBox.Show("Failed to send command Y to device. Please make sure baud rate setting is correct and try again.", "Error");
            }
        }

        private void factoryResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to perform factory reset?", "Factory reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(!sendDataToDevice("W"))
                {
                    MessageBox.Show("Failed to send command W to device. Please make sure baud rate setting is correct and try again.", "Error");
                }
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cs = "";
            spData.Clear();
            rxState = TRXState.Running; // reset to this
            string comport = Properties.Settings.Default.ComPort;
            try
            {
                if (sp.IsOpen)
                {
                    sp.Close();
                    cs = "Disconnected";
                    tsbConnectDisconnect.BackColor = System.Drawing.Color.PeachPuff;
                    tssConnectionStatus.BackColor = System.Drawing.Color.PeachPuff;
                }
                else
                {
                    sp.PortName = "COM" + comport;
                    sp.BaudRate = Properties.Settings.Default.BaudRate;
                    sp.Open();
                    cs = "Connected to " + sp.PortName + " @ " + sp.BaudRate + "bps";
                    tsbConnectDisconnect.BackColor = System.Drawing.Color.LightGreen;
                    tssConnectionStatus.BackColor = System.Drawing.Color.LightGreen;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error accessing COM port (COM" + comport + "). Please check settings and try again.", "Error");
                settingsToolStripMenuItem_Click(sender, e);
                cs = "Connection error";
            }
            finally
            {
                tssConnectionStatus.Text = tssConnectionStatus.Tag.ToString().Replace("%", cs);
            }
        }

        private void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // https://stackoverflow.com/a/15124287
            while (sp.BytesToRead > 0)
            {
                var count = sp.BytesToRead;
                var bytes = new byte[count];
                sp.Read(bytes, 0, count);
                spProcessBytes(bytes);
            }
        }

        private void spProcessBytes(byte[] bytes)
        {
            spData.AddRange(bytes);

            // convert array of bytes to string
            string cmds = System.Text.Encoding.ASCII.GetString(spData.ToArray<byte>(), 0, spData.Count());
            
            // while there is a full command available in buffer
            while (cmds.Contains(commandTerminator))
            {
                int eoc = cmds.IndexOf(commandTerminator);
                List<byte> oneCommand = spData.GetRange(0, eoc);

                // convert to string
                string cmd = System.Text.Encoding.ASCII.GetString(oneCommand.ToArray<byte>(), 0, oneCommand.Count());

                // remove from buffer
                spData.RemoveRange(0, eoc + commandTerminator.Length);

                // ucitaj cmd
                var task = uiFactory.StartNew(() => processCommand(cmd));

                // next
                cmds = System.Text.Encoding.ASCII.GetString(spData.ToArray<byte>(), 0, spData.Count());
            }
        }

        private void addToEventLog(string txt, string prependTxt = "", bool useTimeStamp = true)
        {
            if (!string.IsNullOrEmpty(prependTxt))
            {
                txt = prependTxt + " " + txt;
            }

            if (useTimeStamp)
            {
                txt = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + ": " + txt;
            }
            txtLog.AppendText(txt + Environment.NewLine);
        }

        private void addEventToSQLite(int eventId, string eventParam, int eventGroupId, string eventDescription)
        {
            if (sqliteConn == null)
            {
                ckEventViewerSaveToSQLite.Checked = false;
                ckEventViewerSaveToSQLite.Enabled = false;
                return;
            }

            // insert the event
            try
            {
                string sql_insert = "INSERT INTO event_log (event_id, event_group_id, event_param, event_description, event_timestamp, event_unix_timestamp) VALUES (@event_id, @event_group_id, @event_param, @event_description, @event_timestamp, @event_unix_timestamp)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql_insert, sqliteConn))
                {
                    cmd.Parameters.AddWithValue("@event_id", eventId);
                    cmd.Parameters.AddWithValue("@event_group_id", eventGroupId);
                    cmd.Parameters.AddWithValue("@event_param", eventParam);
                    cmd.Parameters.AddWithValue("@event_description", eventDescription);
                    cmd.Parameters.AddWithValue("@event_timestamp", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));

                    DateTime utcNow = DateTime.UtcNow;
                    DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    long unixTimestamp = (long)(utcNow - unixEpoch).TotalSeconds;
                    cmd.Parameters.AddWithValue("@event_unix_timestamp", unixTimestamp);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException e)
            {
                addToEventLog(e.Message.Replace("\n", " "), "[# SQLite Error]");
            }
        }

        private void processCommand(string cmd)
        {
            if (string.IsNullOrEmpty(cmd)) return;

            // state machine
            switch (rxState)
            {
                // at startup, we will assume that device is running
                case TRXState.Running:
                    // here we can get some running data, such as event logging, realtime frequency as it changes. that is basically it
                    // realtime freq analysis
                    if (cmd.StartsWith("A["))
                    {
                        // A[id]>12.2122,12.2122,12.2122,-15.3212,-15.3213\r\n
                        int loopId = extractLoopIdFromResponse(cmd);
                        string paramVal = extractParamValueFromResponse(cmd);

                        try
                        {
                            if (loopId < 0 || loopId > 3)
                            {
                                throw new Exception();
                            }

                            CirBuff<double> freqAna = deviceStuff.freqAna[loopId];

                            List<string> ar = new List<string>(paramVal.Split(','));
                            bool newDetectState = false;
                            // add all items to our circular buffer
                            ar.ForEach(i =>
                            {
                                double fre = double.Parse(i, CultureInfo.InvariantCulture);
                                // see if there is a positive element in array
                                if (fre > 0)
                                {
                                    newDetectState = true;
                                }
                                freqAna.Add(fre);
                            });

                            // if detection has been found, and not already before
                            if (newDetectState && !deviceStuff.detectState[loopId])
                            {
                                deviceStuff.detectState[loopId] = true;

                                // put marker somewhere here
                                freqAna.MarkerPush();
                            }
                            // if there was a detection, but not anymore, fetch previous marker and start plotting
                            else if(!newDetectState && deviceStuff.detectState[loopId])
                            {
                                deviceStuff.detectState[loopId] = false;

                                // save current data index, so we can restore it after moving it around
                                int backupIndex = freqAna.GetCurrentIndex();

                                int dataStartIndex = freqAna.MarkerPop();
                                dataStartIndex -= 20; // take previous N samples as well

                                // move buffer to marker index
                                freqAna.SetIndex(dataStartIndex);

                                // select chart to draw
                                CheckBox ckToSave = ckAutoSaveAnalysisLoopA;
                                System.Windows.Forms.DataVisualization.Charting.Chart destChart = chAnalysisLoopA;
                                if (loopId == 1)
                                {
                                    destChart = chAnalysisLoopB;
                                    ckToSave = ckAutoSaveAnalysisLoopB;
                                }
                                else if (loopId == 2)
                                {
                                    destChart = chAnalysisLoopC;
                                    ckToSave = ckAutoSaveAnalysisLoopC;
                                }
                                else if (loopId == 3)
                                {
                                    destChart = chAnalysisLoopD;
                                    ckToSave = ckAutoSaveAnalysisLoopD;
                                }
                                destChart.Series.Clear();
                                var seriesChart = new System.Windows.Forms.DataVisualization.Charting.Series
                                {
                                    Name = "Signal over time",
                                    Color = System.Drawing.Color.Green,
                                    BorderWidth = 2,
                                    IsVisibleInLegend = false,
                                    IsXValueIndexed = true,
                                    YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double,
                                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                                };
                                destChart.Series.Add(seriesChart);

                                List<double> data4chart = new List<double>();
                                double max = 0;
                                // fetch data from marker index, to backupIndex
                                while (freqAna.GetCurrentIndex() != backupIndex)
                                {
                                    double absVal = Math.Abs(freqAna.GetItem());
                                    data4chart.Add(absVal);
                                    if(absVal > max)
                                    {
                                        max = absVal;
                                    }
                                }

                                // normalizuj
                                List<double> normalized = new List<double>();
                                double maxNorm = 0;
                                foreach (double freq in data4chart)
                                {
                                    double normVal = max - freq;
                                    normalized.Add(normVal);
                                    if(normVal > maxNorm)
                                    {
                                        maxNorm = normVal;
                                    }
                                }

                                // naubacuj sad u chart series, usput invertuj
                                // takodje snimaj u globalnu var da mozemo uraditi SAVE po potrebi
                                deviceStuff.freqAna4Save[loopId].Clear();
                                foreach (double freq in normalized)
                                {
                                    seriesChart.Points.AddY(maxNorm - freq);
                                    deviceStuff.freqAna4Save[loopId].Add(maxNorm - freq);
                                }

                                // save to file if required
                                if(ckToSave.Checked)
                                {
                                    if(!SaveAnalysisToFile(deviceStuff.freqAna4Save[loopId], saveAnalysisFolder, "Loop_" + loopId + "_" + DateTime.Now.ToString("yyyy-MM-dd-H-mm-ss") + ".txt"))
                                    {
                                        ckToSave.Checked = false;
                                    }
                                }

                                // (re)draw
                                destChart.Invalidate();

                                // restore index, just in case it gets important to continue adding samplest from the same position
                                freqAna.SetIndex(backupIndex);
                            }
                        }
                        catch (Exception)
                        {
                            // parsing error happens because of uart->usb interface buffer overrun, so just die silently
                            //Console.WriteLine("EXCEPTION: "+ eee.InnerException);
                            return;
                        }
                    }
                    // event
                    else if(cmd.StartsWith("EVENT["))
                    {
                        // ovdje smo dobili jedan event u formatu: EVENT[loop_id_ili_dirlogix_idx]>EVENT_CODE,_optional_event_parameter_\r\n
                        int loopId = extractLoopIdFromResponse(cmd);
                        string paramVal = extractParamValueFromResponse(cmd);
                        string ev = "";

                        int eventId = -1;
                        string eventParam = "";
                        try
                        {
                            if (paramVal.Contains(","))
                            {
                                List<string> lis = new List<string>(paramVal.Split(','));
                                eventId = int.Parse(lis[0]);
                                eventParam = lis[1];
                            }
                            else
                            {
                                eventId = int.Parse(paramVal);
                            }
                        }
                        catch(Exception)
                        {
                            // failed while parsing...
                            //addToEventLog("Parsing exception!");
                            return;
                        }

                        // unsupported event!?
                        if (!EventName.ContainsKey(eventId)) return;

                        bool isDirLogicEvent = EventForDirlogic.Contains(eventId);

                        ev = EventName[eventId];
                        ev = ev.Replace("$", eventParam);

                        // ako je isDirLogicEvent==true, znaci da je event nije nije od nijedne petlje nego "spojeni event" od neke grupe 0=AB, 1=CD
                        if (isDirLogicEvent)
                        {
                            // AB group
                            if (loopId == 0)
                            {
                                lblLastJointEventAB.Text = lblLastJointEventAB.Tag.ToString().Replace("%", ev);
                                addToEventLog(ev, "[A+B]");
                                if (ckEventViewerSaveToSQLite.Checked) addEventToSQLite(eventId, eventParam, loopId, "[A+B] " + ev);
                            }
                            // CD group
                            else
                            {
                                lblLastJointEventCD.Text = lblLastJointEventCD.Tag.ToString().Replace("%", ev);
                                addToEventLog(ev, "[C+D]");
                                if (ckEventViewerSaveToSQLite.Checked) addEventToSQLite(eventId, eventParam, loopId, "[C+D] " + ev);
                            }
                        }
                        else
                        {
                            if (loopId == 0)
                            {
                                lblLastEventLoopA.Text = lblLastEventLoopA.Tag.ToString().Replace("%", ev);
                                // log to window
                                addToEventLog(ev, "[LOOP A]");
                                if (ckEventViewerSaveToSQLite.Checked) addEventToSQLite(eventId, eventParam, loopId, "[LOOP A] " + ev);
                            }
                            else if (loopId == 1)
                            {
                                lblLastEventLoopB.Text = lblLastEventLoopB.Tag.ToString().Replace("%", ev);
                                // log to window
                                addToEventLog(ev, "[LOOP B]");
                                if (ckEventViewerSaveToSQLite.Checked) addEventToSQLite(eventId, eventParam, loopId, "[LOOP B] " + ev);
                            }
                            else if (loopId == 2)
                            {
                                lblLastEventLoopC.Text = lblLastEventLoopC.Tag.ToString().Replace("%", ev);
                                // log to window
                                addToEventLog(ev, "[LOOP C]");
                                if (ckEventViewerSaveToSQLite.Checked) addEventToSQLite(eventId, eventParam, loopId, "[LOOP C] " + ev);
                            }
                            else if (loopId == 3)
                            {
                                lblLastEventLoopD.Text = lblLastEventLoopD.Tag.ToString().Replace("%", ev);
                                // log to window
                                addToEventLog(ev, "[LOOP D]");
                                if (ckEventViewerSaveToSQLite.Checked) addEventToSQLite(eventId, eventParam, loopId, "[LOOP D] " + ev);
                            }
                        }
                    }
                    // device answered to our communicatino request?
                    else if(cmd.Contains("READY>v2"))
                    {
                        rxState = TRXState.Comm;
                    }
                    // wrong device state, just wait for it to timeout and return to running state
                    else
                    {
                        // Error, waiting for device to timeout and return to running state.
                    }
                    break;

                // free communicating state, this is a reply on our previous command we sent
                case TRXState.Comm:
                    {
                        switch (cmd)
                        {
                            // ping response
                            case "READY>v2\r\n":
                                // nothing special here
                                break;
                            // logging is turned on
                            case "LOG>1\r\n":
                                lblLoggingState.Text = lblLoggingState.Tag.ToString().Replace("%", "On");
                                sendDataToDevice("Q"); // logging is ON, return to running mode
                                break;
                            // logging is turned off
                            case "LOG>0\r\n":
                                lblLoggingState.Text = lblLoggingState.Tag.ToString().Replace("%", "Off");
                                break;
                            // realtime freq analysis is turned on
                            case "ANA>1\r\n":
                                lblSignalAnalysis.Text = lblSignalAnalysis.Tag.ToString().Replace("%", "On");
                                sendDataToDevice("Q"); // logging is ON, return to running mode
                                break;
                            // realtime freq analysis is turned off
                            case "ANA>0\r\n":
                                lblSignalAnalysis.Text = lblSignalAnalysis.Tag.ToString().Replace("%", "Off");
                                break;
                            // resumed to normal operation
                            // quiting from comm mode
                            case "QUIT>\r\n":
                            case "RESUME>\r\n":
                                rxState = TRXState.Running;
                                break;
                            // other command response processing is here
                            default:
                                {
                                    // response on error history request
                                    if(cmd.Contains("ERROR["))
                                    {
                                        // ovdje smo dobili dva error responsa, jer imamo 2 petlje u device-u
                                        // ERROR[%u]>0\r\nERROR[%u]>0\r\n
                                        string[] tmp = cmd.Split(new string[] { crlf }, StringSplitOptions.RemoveEmptyEntries);
                                        List<string> errors = new List<string>(tmp);
                                        foreach (string loopErr in errors)
                                        {
                                            int loopId = extractLoopIdFromResponse(loopErr);
                                            string paramVal = extractParamValueFromResponse(loopErr + "\r\n");
                                            try
                                            {
                                                deviceStuff.err[loopId] = int.Parse(paramVal);
                                            }
                                            catch(Exception)
                                            {
                                                // fail silently...
                                            }
                                        }
                                    }
                                    // response on frequency request
                                    else if(cmd.Contains("FREQ["))
                                    {
                                        // ovdje smo dobili 4 freq responsa, jer imamo 4 petlje u device-u
                                        // FREQ[%u]>%0.5f\r\nFREQ[%u]>%0.5f\r\nFREQ[%u]>%0.5f\r\nFREQ[%u]>%0.5f\r\n
                                        string[] tmp = cmd.Split(new string[] { crlf }, StringSplitOptions.RemoveEmptyEntries);
                                        List<string> freqs = new List<string>(tmp);
                                        foreach (string loopFreq in freqs)
                                        {
                                            int loopId = extractLoopIdFromResponse(loopFreq);
                                            string paramVal = extractParamValueFromResponse(loopFreq + "\r\n");
                                            try
                                            {
                                                deviceStuff.freq[loopId] = double.Parse(paramVal, CultureInfo.InvariantCulture);
                                            }
                                            catch (Exception)
                                            {
                                                // fail silently...
                                            }
                                        }
                                    }
                                    // response on factory reset
                                    else if (cmd.Contains("FACTORY>"))
                                    {
                                        string paramVal = extractParamValueFromResponse(cmd);
                                        MessageBox.Show("Device performed factory reset and answered with: " + paramVal, "Factory reset");
                                    }
                                    // response on startup DIPs query
                                    else if (cmd.Contains("DIPS["))
                                    {
                                        // ovdje smo dobili 4 DIPs responsa, jer imamo 4x 4-bitna DIP-a u device-u
                                        // DIPS[%u]>%02X\r\nDIPS[%u]>%02X\r\nDIPS[%u]>%02X\r\nDIPS[%u]>%02X\r\n
                                        string[] tmp = cmd.Split(new string[] { crlf }, StringSplitOptions.RemoveEmptyEntries);
                                        List<string> dips = new List<string>(tmp);
                                        foreach (string oneDip in dips)
                                        {
                                            int loopId = extractLoopIdFromResponse(oneDip);
                                            string paramVal = extractParamValueFromResponse(oneDip + "\r\n");
                                            try
                                            {
                                                deviceStuff.genDIPs[loopId] = byte.Parse(paramVal, System.Globalization.NumberStyles.HexNumber);
                                            }
                                            catch (Exception asdasd)
                                            {
                                                // fail silently...
                                                Console.Write(asdasd);
                                                return;
                                            }
                                        }

                                        // update configPacket's DIPs
                                        configPacket.softDIP1 = (byte)(deviceStuff.genDIPs[3] >> 4);
                                        configPacket.softDIP1 |= (byte)(deviceStuff.genDIPs[2]);
                                        configPacket.softDIP2 = (byte)(deviceStuff.genDIPs[1] >> 4);
                                        configPacket.softDIP2 |= (byte)(deviceStuff.genDIPs[0]);

                                        // update only DIPs to screen
                                        configPacketToScreen(true);
                                    }
                                    // response on soft-reset
                                    else if (cmd.Contains("RESET>"))
                                    {
                                        MessageBox.Show("Device accepted soft-restart command.", "Soft-restart");
                                    }
                                    // response on communication quitting and communication exiting
                                    else if (cmd.Contains("QUIT>") || cmd.Contains("RESUME>"))
                                    {
                                        // asd...
                                    }
                                    // response to our GET command request
                                    else if (cmd.Contains("GET>"))
                                    {
                                        // ovdje dobijamo npr: GET>93\r\n982734987234987234....982734987234987\r\n
                                        string[] tmp = cmd.Split(new string[] { crlf }, StringSplitOptions.RemoveEmptyEntries);
                                        List<string> stuff = new List<string>(tmp);
                                        try
                                        {
                                            string tmp2 = extractParamValueFromResponse(cmd); // this will extract only number after GET> and before first \r\n
                                            int eeSize = int.Parse(tmp2);

                                            // validate, EE_SIZE is expected
                                            if (eeSize != EE_SIZE)
                                            {
                                                MessageBox.Show("Error in received configuration data. Number of bytes received is not correct (" + eeSize + "/" + EE_SIZE + ")!", "Error");
                                                return;
                                            }

                                            string hexaConfig = stuff[1];
                                            
                                            // parse this baby
                                            TConfigPacket parsedConfigPacket = parseHexaConfigPacket(hexaConfig);

                                            // activate it /show on screen
                                            configPacket = parsedConfigPacket;
                                            configPacketToScreen();
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Error in received configuration data. Something is not right!", "Error");
                                        }
                                    }
                                    // response to our SET command
                                    else if (cmd.Contains("SET>"))
                                    {
                                        // ovdje cemo dobiti SET>93\r\n i uredjaj onda ocekuje da mu pocnemo slati config packet
                                        string paramVal = extractParamValueFromResponse(cmd);

                                        int eeSize = 0;
                                        try
                                        {
                                            eeSize = int.Parse(paramVal);
                                            if(eeSize != EE_SIZE)
                                            {
                                                throw new Exception("");
                                            }
                                        }
                                        catch(Exception)
                                        {
                                            MessageBox.Show("Error in attempting to send configuration data. Number of bytes device is expecting is not correct (" + eeSize + "/" + EE_SIZE + ")!", "Error");
                                            return;
                                        }

                                        // restart index
                                        commSettingIndex = 0;
                                        tssProgress.Maximum = EE_SIZE * 2;
                                        tssProgress.Value = 0;
                                        tssProgress.Visible = true;

                                        // all good, switch to "communication SETting" state
                                        // we will now get "<" command that will start "pulling data from us"
                                        rxState = TRXState.Comm_Setting;
                                    }
                                    // else if...
                                }
                                break;
                        }
                    }
                    break;

                case TRXState.Comm_Setting:
                    switch (cmd)
                    {
                        // programming failed because of timeout
                        case "ERR>\r\n":
                            MessageBox.Show("Programming failed because of timeout in device.", "Programming");
                            rxState = TRXState.Comm; // switch back to comm mode
                            break;
                        // programming done OK
                        case "OK>\r\n":
                            MessageBox.Show("Programming done OK!\r\nDo not forget to restart CPU for changes to take effect.", "Programming");
                            rxState = TRXState.Comm; // switch back to comm mode

                            // after short time reset the progressbar
                            delayedUIRun(1000, delegate ()
                            {
                                tssProgress.Value = 0;
                                tssProgress.Visible = false;
                            });
                            break;
                        // flow control character is here
                        // device is pulling more data from us
                        case "SET><\r\n":
                            string oneByte = hex2send.Substring(commSettingIndex, 1);
                            sendDataToDevice(oneByte);
                            commSettingIndex++;
                            tssProgress.Value = commSettingIndex;
                            break;
                    }
                    break;
            }
        }

        private bool sendDataToDevice(string data)
        {
            if(!sp.IsOpen)
            {
                MessageBox.Show("Please first connect to device!", "Communication error");
                return false;
            }

            // enter comm state if not already in it, returns whether anything failed or data sending was OK
            return ensureCommState(delegate (bool success) {
                // try writing to port
                try
                {
                    // if it failed to enter comm state, just return immediatelly with false
                    if (!success)
                    {
                        throw new Exception(""); // did not manage to enter comm state!
                    }

                    sp.Write(data);
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            });
        }

        private bool ensureCommState(Func<bool, bool> callback)
        {
            // if device is in running state, first enter comm mode
            if (rxState == TRXState.Running)
            {
                try
                {
                    sp.Write(_UART_START_CHAR.ToString());
                }
                catch (Exception)
                {
                    return false;
                }

                // pricekaj nekako malo da vidimo hoce li uletiti u comm mode, ako ne uleti javi greksu. ako uleti - super, samo nastavi
                Stopwatch sw = new Stopwatch();
                sw.Start();
                tssProgress.Maximum = _UART_COMM_MODE_ENTER_DELAY_MS / 1000;
                tssProgress.Visible = true;
                while(rxState != TRXState.Comm && sw.ElapsedMilliseconds <= _UART_COMM_MODE_ENTER_DELAY_MS)
                {
                    // I am not happy with this, but...
                    Application.DoEvents();
                    tssProgress.Value = (int)(sw.ElapsedMilliseconds / 1000);
                }
                sw.Stop();
                tssProgress.Value = tssProgress.Maximum;
                // after short time reset the progressbar
                delayedUIRun(1000, delegate ()
                {
                    tssProgress.Value = 0;
                    tssProgress.Visible = false;
                });

                // return whatever state we are in currently, we should have succeeded
                return callback(rxState == TRXState.Comm);
            }
            // device is already in communication mode, so just return
            else
            {
                return callback(true);
            }
        }

        private void delayedUIRun(int msTime, Action callback)
        {
            Task.Delay(msTime).ContinueWith((dummy) =>
            {
                uiFactory.StartNew(callback);
            });
        }

        private string extractParamValueFromResponse(string r)
        {
            string pattern = Regex.Escape(">") + "(.*)" + Regex.Escape("\r\n");
            Match match = Regex.Match(r, pattern);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Extracts loop id from parameter: SOMETHING[_loop_id_]>SOMETHING...
        /// </summary>
        /// <param name="r"></param>
        /// <returns>Returns loop id, or -1 if loop id is not a number. It is possible that X enters as loop number and it will be returned as -1</returns>
        private int extractLoopIdFromResponse(string r)
        {
            string pattern = Regex.Escape("[") + "([0-9]*)" + Regex.Escape("]");
            Match match = Regex.Match(r, pattern);
            try
            {
                if (match.Success)
                {
                    return int.Parse(match.Groups[1].Value);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private void tssFrequencyLoopA_Click(object sender, EventArgs e)
        {
            if(!sendDataToDevice("F"))
            {
                MessageBox.Show("Failed to send command F to device. Please make sure baud rate setting is correct and try again.", "Error");
            }
        }

        private void tssFrequencyLoopB_Click(object sender, EventArgs e)
        {
            if(!sendDataToDevice("F"))
            {
                MessageBox.Show("Failed to send command F to device. Please make sure baud rate setting is correct and try again.", "Error");
            }
        }

        private void uctbPPCMedium_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblPPCMedium.Tag.ToString();

            TimeSpan span = TimeSpan.FromMinutes(uctbPPCMedium.Value);
            info = info.Replace("%", span.ToString(@"hh\:mm"));

            lblPPCMedium.Text = info;
        }

        private void uctbPPCLong_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblPPCLong.Tag.ToString();

            TimeSpan span = TimeSpan.FromMinutes(uctbPPCLong.Value);
            info = info.Replace("%", span.ToString(@"hh\:mm"));

            lblPPCLong.Text = info;
        }

        private void returnToRunningModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rxState != TRXState.Running)
            {
                sendDataToDevice("Q");
                rxState = TRXState.Running; // mozemo ovdje slobodno
            }
        }

        private void btnReadDIPsFromDevice_Click(object sender, EventArgs e)
        {
            if(!sendDataToDevice("T"))
            {
                MessageBox.Show("Failed to send command T to device. Please make sure baud rate setting is correct and try again.", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // toggle logging mode
            sendDataToDevice("L");
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void btnSignalAnalysis_Click(object sender, EventArgs e)
        {
            sendDataToDevice("A");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are sure you want to close the application?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                this.Activate();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(sp.IsOpen)
            {
                sp.Close();
            }

            if (sqliteConn != null && sqliteConn.State != System.Data.ConnectionState.Closed)
            {
                sqliteConn.Close();
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For more information please visit:\r\n\r\nwww.elektronika.ba", "About");
        }

        private bool SaveAnalysisToFile(List<double> analysisData, string path, string filename)
        {
            // need to ask user for input?
            if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(filename) || !Directory.Exists(path))
            {
                DialogResult dr = saveAnalysisDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string fn = saveAnalysisDialog.FileName;
                    if (string.IsNullOrEmpty(fn))
                    {
                        MessageBox.Show("This is not a valid file!", "File error");
                        return false;
                    }

                    if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
                    {
                        path = Path.GetDirectoryName(fn);
                    }

                    if(string.IsNullOrEmpty(filename))
                    {
                        filename = Path.GetFileName(fn);
                    }
                }
                else
                {
                    return false;
                }
            }

            // save global path
            saveAnalysisFolder = path;

            // save to file
            string fullFileName = Path.Combine(path, filename);
            using (StreamWriter file = new StreamWriter(fullFileName))
            {
                foreach(double freq in analysisData)
                {
                    file.WriteLine(freq.ToString("0.0000"));
                }
            }

            return true;
        }

        private void btnSaveAnalysisLoopA_Click(object sender, EventArgs e)
        {
            SaveAnalysisToFile(deviceStuff.freqAna4Save[0], saveAnalysisFolder, null);
        }

        private void btnSaveAnalysisLoopB_Click(object sender, EventArgs e)
        {
            SaveAnalysisToFile(deviceStuff.freqAna4Save[1], saveAnalysisFolder, null);
        }

        private void chAnalysisLoopA_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = saveChartImageDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                chAnalysisLoopA.SaveImage(saveChartImageDialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
            }
        }

        private void chAnalysisLoopB_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveChartImageDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                chAnalysisLoopB.SaveImage(saveChartImageDialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
            }

        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveLogDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // save to file
                string fullFileName = saveLogDialog.FileName;
                using (StreamWriter file = new StreamWriter(fullFileName))
                {
                    file.Write(txtLog.Text);
                }
            }
        }

        private void tmrSpeedTrapErrorGenerator_Tick(object sender, EventArgs e)
        {
            tmrSpeedTrapErrorGenerator.Enabled = false;
            tblMaximumSpeedErrors.Rows.Clear();

            double samplingSpeedSeconds = ((1.0 / _TMR1_FREQ) * uctbSamplingSpeed.Value);

            int minMeasSpeed = (int)((uctbSpeedDistance.Value / 100.0) / (SHORTEST_SPEED_TIME_MS/1000) * 3600.0);
            int maxMeasSpeed = (int)((uctbSpeedDistance.Value / 100.0) / (2.0 * samplingSpeedSeconds) / 1000.0 * 3600.0);
            for (double speed = 10; speed <= maxMeasSpeed; speed += 10)
            {
                double timeForSpeedMs = (uctbSpeedDistance.Value / 100.0) / (speed * 1000.0 / 3600.0);

                DataGridViewRow r = new DataGridViewRow();

                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                c1.Value = speed;
                r.Cells.Add(c1);

                double timeForSpeedWithMaxErrSec = timeForSpeedMs + (2.0 * samplingSpeedSeconds);
                double speedWithMaxError = ((uctbSpeedDistance.Value / 100.0) / timeForSpeedWithMaxErrSec) / 1000.0 * 3600.0;

                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                c2.Value = speedWithMaxError.ToString("0.00", CultureInfo.InvariantCulture);
                r.Cells.Add(c2);

                double errorKmh = speed - speedWithMaxError;

                DataGridViewTextBoxCell c3 = new DataGridViewTextBoxCell();
                c3.Value = errorKmh.ToString("0.00", CultureInfo.InvariantCulture);
                r.Cells.Add(c3);

                double errorPercent = ((speed - speedWithMaxError) / speed * 100.0);

                DataGridViewTextBoxCell c4 = new DataGridViewTextBoxCell();
                c4.Value = errorPercent.ToString("0.00", CultureInfo.InvariantCulture);
                r.Cells.Add(c4);

                tblMaximumSpeedErrors.Rows.Add(r);
            }
        }

        private void cbQuickPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            - Choose Preset -                   INDEX = 0
            Single Channel (A)                  INDEX = 1
            Two Channels (A) and (B)            INDEX = 2
            Three Channels (A), (B) and (C)     INDEX...
            Four Channels (A), (B), (C) and (D)
            Two Channels Directional Logic (A + B)
            Two Channels Directional Logic (A + B) and One Channel (C)
            Two Channels Directional Logic (A + B) and Two Channels (C) and (D)
            Four Channels Directional Logic (A + B) and (C + D)             
            */

            int presetIdx = cbQuickPresets.SelectedIndex;

            if (presetIdx == 0) return;

            ckGenDIP1_1.Checked = presetIdx >= 1;
            ckGenDIP1_2.Checked = presetIdx >= 2;
            ckGenDIP1_3.Checked = presetIdx >= 3 && presetIdx != 5;
            ckGenDIP1_4.Checked = presetIdx >= 4 && presetIdx != 5 && presetIdx != 6;
            ckGenDIP1_5.Checked = presetIdx >= 5;
            ckGenDIP1_6.Checked = presetIdx >= 8;

            // switch back to nothing
            cbQuickPresets.SelectedIndex = 0;
        }

        /**
         * Clicking on the General DIPs enables/disables others on the same page.
         **/
        private void hndlChannelOnOffAndModeChange(object sender, EventArgs e)
        {
            CheckBox ck = (CheckBox)sender;
            string ckIdx = ck.Tag.ToString();
            if(!ck.Checked)
            {
                if (ckIdx == "0" || ckIdx == "1")
                {
                    ckGenDIP1_5.Checked = false;
                }
                else if (ckIdx == "2" || ckIdx == "3")
                {
                    ckGenDIP1_6.Checked = false;
                }
                else if (ckIdx == "4")
                {
                    ckGenDIP2_5.Checked = false;
                    ckGenDIP2_5.Enabled = false;
                    ckGenDIP2_6.Checked = false;
                    ckGenDIP2_6.Enabled = false;
                    
                    pnlGroupedAB.Visible = false;
                }
                else if (ckIdx == "5")
                {
                    ckGenDIP2_7.Checked = false;
                    ckGenDIP2_7.Enabled = false;
                    ckGenDIP2_8.Checked = false;
                    ckGenDIP2_8.Enabled = false;

                    pnlGroupedCD.Visible = false;
                }
            }
            else
            {
                if (ckIdx == "4")
                {
                    ckGenDIP1_1.Checked = true;
                    ckGenDIP1_2.Checked = true;

                    ckGenDIP2_5.Enabled = true;
                    ckGenDIP2_6.Enabled = true;
                    
                    pnlGroupedAB.Visible = true;
                }
                else if (ckIdx == "5")
                {
                    ckGenDIP1_3.Checked = true;
                    ckGenDIP1_4.Checked = true;

                    ckGenDIP2_7.Enabled = true;
                    ckGenDIP2_8.Enabled = true;

                    pnlGroupedCD.Visible = true;
                }
            }
        }

        private void tssFrequencyLoopC_Click(object sender, EventArgs e)
        {
            if (!sendDataToDevice("F"))
            {
                MessageBox.Show("Failed to send command F to device. Please make sure baud rate setting is correct and try again.", "Error");
            }
        }

        private void tssFrequencyLoopD_Click(object sender, EventArgs e)
        {
            if (!sendDataToDevice("F"))
            {
                MessageBox.Show("Failed to send command F to device. Please make sure baud rate setting is correct and try again.", "Error");
            }
        }

        private int findSelectedChannelIndexOfChannelRelatedDIPs()
        {
            // find selected channel
            foreach (Control rbc in gbCHDips.Controls)
            {
                if (rbc is RadioButton)
                {
                    RadioButton rb = (RadioButton)rbc;
                    if (rb.Checked)
                    {
                        return int.Parse(rb.Tag.ToString());
                    }
                }
            }

            throw new Exception("This should not have happened. Please set Channel Indexes to all to radio buttons' Tags.");
        }

        /**
         * Set labels for checkboxes of selected channel.
         **/
        private void repaintChannelRelatedDIPsSelection()
        {
            int channelIdx = findSelectedChannelIndexOfChannelRelatedDIPs();

            string chName = ((char)('A' + channelIdx)).ToString();
            lblShowingDIPsForChannel.Text = lblShowingDIPsForChannel.Tag.ToString().Replace("%", chName);

            // we need to adjust labels for channel related DIPs according to the mode selected for that group (independent or directional)
            // ...changing mode from directional to independent changes channel-specific DIP meaning
            Dictionary<int, List<string>> DIP1texts = new Dictionary<int, List<string>>()
            {
                // independent
                { 0, new List<string>() { "1. Alternative Frequency +1", "2. Alternative Frequency +2", "3. PPC +1", "4. PPC +2", "5. Presence Output", "6. Extended Output Pulse", "7. Delay Output Activation", "8. Inverted Output" } },
                // directional
                { 1, new List<string>() { "1. Alternative Frequency +1", "2. Alternative Frequency +2", "3. - ignored -", "4. - ignored -", "5. - ignored -", "6. Extended Output Pulse", "7. - ignored -", "8. Inverted Output" } },
            };

            Dictionary<int, List<string>> DIP2texts = new Dictionary<int, List<string>>()
            {
                // independent
                { 0, new List<string>() { "1. ASB", "2. Detect Stop", "3. Fail Safe", "4. Detect LED Mapped to Output", "5. Pulse on Entry", "6. Delayed Runtime Re-Calibration", "7. - reserved -", "8. - reserved -" } },
                // directional
                { 1, new List<string>() { "1. ASB", "2. - ignored -", "3. - ignored -", "4. Detect LED Mapped to Output", "5. - ignored -", "6. Delayed Runtime Re-Calibration", "7. - reserved -", "8. - reserved -" } },
            };

            int dictIndex = 0; // not a group, take labels from index 0
            if ((channelIdx == 0 || channelIdx == 1) && ckGenDIP1_5.Checked) dictIndex = 1; // is A+B, take labels from index 1
            else if ((channelIdx == 2 || channelIdx == 3) && ckGenDIP1_6.Checked) dictIndex = 1; // is C+D, take labels from index 1

            // adjust DIP1 texts
            foreach (Control c in gbCHDIP1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    int bitWeight = int.Parse(cb.Tag.ToString());
                    cb.Checked = false;
                    if ((configPacket.chDIP1[channelIdx] & (byte)Math.Pow(2, bitWeight)) > 0)
                    {
                        cb.Checked = true;
                    }

                    List<string> t = DIP1texts[dictIndex]; 
                    cb.Text = t[int.Parse(c.Tag.ToString())];
                }
            }

            // adjust DIP2 texts
            foreach (Control c in gbCHDIP2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    int bitWeight = int.Parse(cb.Tag.ToString());
                    cb.Checked = false;
                    if ((configPacket.chDIP2[channelIdx] & (byte)Math.Pow(2, bitWeight)) > 0)
                    {
                        cb.Checked = true;
                    }

                    List<string> t = DIP2texts[dictIndex];
                    cb.Text = t[int.Parse(c.Tag.ToString())];
                }
            }

            reEnableChannelRelatedDIPs();
        }

        private void rbCHDIPs_Changed(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            
            System.Drawing.Font fff = rb.Font;
            // boldiraj selektovani
            if(rb.Checked)
            {
                fff = new System.Drawing.Font(fff.Name, fff.Size, System.Drawing.FontStyle.Bold);
            }
            // odboldiraj odselektovani
            else
            {
                fff = new System.Drawing.Font(fff.Name, fff.Size, System.Drawing.FontStyle.Regular);
            }
            rb.Font = fff;

            if (!rb.Checked) return; // we don't care for an un-checked event from this point...
            repaintChannelRelatedDIPsSelection();
        }

        private void tcMainConfigDIPs_SelectedIndexChanged(object sender, EventArgs e)
        {
            repaintChannelRelatedDIPsSelection();
        }

        private void reEnableChannelRelatedDIPs()
        {
            int channelIdx = findSelectedChannelIndexOfChannelRelatedDIPs();

            // skontaj da li je taj kanal u directional modu ili independent
            bool isDirectional = false;
            if ((channelIdx == 0 || channelIdx == 1) && ckGenDIP1_5.Checked) isDirectional = true;
            else if ((channelIdx == 2 || channelIdx == 3) && ckGenDIP1_6.Checked) isDirectional = true;

            // enable/disable some checkboxes depending on the mode
            // directional mode
            if (isDirectional)
            {
                // DIP 1
                ckCHDIP1_3.Enabled = false;
                ckCHDIP1_4.Enabled = false;
                ckCHDIP1_5.Enabled = false;
                ckCHDIP1_6.Enabled = true;
                ckCHDIP1_7.Enabled = false;

                // DIP 2
                ckCHDIP2_2.Enabled = false;
                ckCHDIP2_3.Enabled = false;
                ckCHDIP2_5.Enabled = false;
            }
            // independent mode
            else
            {
                // DIP 1
                ckCHDIP1_3.Enabled = true;
                ckCHDIP1_4.Enabled = true;
                ckCHDIP1_5.Enabled = true;
                ckCHDIP1_6.Enabled = !ckCHDIP1_5.Checked;
                ckCHDIP1_7.Enabled = ckCHDIP1_5.Checked;

                // DIP 2
                ckCHDIP2_2.Enabled = true;
                ckCHDIP2_3.Enabled = true;
                ckCHDIP2_5.Enabled = true;
            }
        }

        private void ckCHDIP_Changed(object sender, EventArgs e)
        {
            reEnableChannelRelatedDIPs();
        }

        private void btnCHDipsCopyFrom_Click(object sender, EventArgs e)
        {
            int channelIdx = findSelectedChannelIndexOfChannelRelatedDIPs();
            int srcChannelIdx = cbCopyCHDIPsFrom.SelectedIndex;
            if (channelIdx == srcChannelIdx) return;

            configPacket.chDIP1[channelIdx] = configPacket.chDIP1[srcChannelIdx];
            configPacket.chDIP2[channelIdx] = configPacket.chDIP2[srcChannelIdx];

            repaintChannelRelatedDIPsSelection();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbSensitivityA_SelectedIndexChanged(object sender, EventArgs e)
        {
            configPacket.sensitivityLoop[0] = (byte)(cbSensitivityA.SelectedIndex + 1);
        }

        private void cbSensitivityB_SelectedIndexChanged(object sender, EventArgs e)
        {
            configPacket.sensitivityLoop[1] = (byte)(cbSensitivityA.SelectedIndex + 1);
        }

        private void cbSensitivityC_SelectedIndexChanged(object sender, EventArgs e)
        {
            configPacket.sensitivityLoop[2] = (byte)(cbSensitivityA.SelectedIndex + 1);
        }

        private void cbSensitivityD_SelectedIndexChanged(object sender, EventArgs e)
        {
            configPacket.sensitivityLoop[3] = (byte)(cbSensitivityA.SelectedIndex + 1);
        }

        private void uctbRelayCPulseNormal_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayCPulseNormal.Tag.ToString();

            double dura = uctbRelayCPulseNormal.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayCPulseNormal.Text = info;
        }

        private void uctbRelayCPulseExtended_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayCPulseExtended.Tag.ToString();

            double dura = uctbRelayCPulseExtended.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayCPulseExtended.Text = info;
        }

        private void uctbRelayDPulseNormal_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayDPulseNormal.Tag.ToString();

            double dura = uctbRelayDPulseNormal.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayDPulseNormal.Text = info;
        }

        private void uctbRelayDPulseExtended_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayDPulseExtended.Tag.ToString();

            double dura = uctbRelayDPulseExtended.Value * 10;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayDPulseExtended.Text = info;
        }

        private void uctbRelayADelayAct_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayADelayAct.Tag.ToString();

            double dura = uctbRelayADelayAct.Value * 50;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayADelayAct.Text = info;

        }

        private void uctbRelayBDelayAct_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayBDelayAct.Tag.ToString();

            double dura = uctbRelayBDelayAct.Value * 50;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayBDelayAct.Text = info;
        }

        private void uctbRelayCDelayAct_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayCDelayAct.Tag.ToString();

            double dura = uctbRelayCDelayAct.Value * 50;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayCDelayAct.Text = info;
        }

        private void uctbRelayDDelayAct_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRelayDDelayAct.Tag.ToString();

            double dura = uctbRelayDDelayAct.Value * 50;
            info = info.Replace("%", dura.ToString("0.00"));

            lblRelayDDelayAct.Text = info;
        }

        private void uctbSlowStartupTimer_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblSlowStartupTmr.Tag.ToString();
            string sinfo = "";

            int val = uctbSlowStartupTimer.Value;
            if (val >= 60)
            {
                TimeSpan span = TimeSpan.FromMilliseconds(val * 1000);
                sinfo = span.ToString(@"mm\:ss") + " mm:ss";
            }
            else
            {
                sinfo = val.ToString("0", CultureInfo.InvariantCulture) + " s";
            }
            info = info.Replace("%", sinfo);

            lblSlowStartupTmr.Text = info;
        }

        private void uctbRuntimeRecalibTmr_TrackbarChanged(object sender, EventArgs e)
        {
            string info = lblRuntimeRecalibTmr.Tag.ToString();
            string sinfo = "";

            int val = uctbRuntimeRecalibTmr.Value;
            if (val >= 60)
            {
                TimeSpan span = TimeSpan.FromMinutes(val);
                sinfo = span.ToString(@"hh\:mm") + " hh:mm";
            }
            else
            {
                sinfo = val.ToString("0", CultureInfo.InvariantCulture) + " m";
            }
            info = info.Replace("%", sinfo);

            lblRuntimeRecalibTmr.Text = info;
        }

        private void btnSaveAnalysisLoopC_Click(object sender, EventArgs e)
        {
            SaveAnalysisToFile(deviceStuff.freqAna4Save[2], saveAnalysisFolder, null);
        }

        private void btnSaveAnalysisLoopD_Click(object sender, EventArgs e)
        {
            SaveAnalysisToFile(deviceStuff.freqAna4Save[3], saveAnalysisFolder, null);
        }
    }
}
