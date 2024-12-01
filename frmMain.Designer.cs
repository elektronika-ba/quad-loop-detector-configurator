namespace QLDConfig1v2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.readFromDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToRunningModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.restartCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.factoryResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFrequencyLoopA = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFrequencyLoopB = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFrequencyLoopC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFrequencyLoopD = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDeviceState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConnectDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReadFromDevice = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlOperatingMode = new System.Windows.Forms.Panel();
            this.tcMainConfigDIPs = new System.Windows.Forms.TabControl();
            this.tabGeneralDIPs = new System.Windows.Forms.TabPage();
            this.gbDIP1 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP1_6 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP1_5 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP1_4 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP1_3 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP1_2 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP1_1 = new System.Windows.Forms.CheckBox();
            this.gbDIP2 = new System.Windows.Forms.GroupBox();
            this.ckGenDIP2_8 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP2_7 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP2_6 = new System.Windows.Forms.CheckBox();
            this.ckGenDIP2_5 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.ckUseSoftDIPs = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuickPresets = new System.Windows.Forms.ComboBox();
            this.btnReadDIPsFromDevice = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.tabChannelDIPs = new System.Windows.Forms.TabPage();
            this.cbCopyCHDIPsFrom = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnCHDipsCopyFrom = new System.Windows.Forms.Button();
            this.gbCHDIP1 = new System.Windows.Forms.GroupBox();
            this.ckCHDIP1_8 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP1_7 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP1_6 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP1_5 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP1_4 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP1_3 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP1_2 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP1_1 = new System.Windows.Forms.CheckBox();
            this.gbCHDIP2 = new System.Windows.Forms.GroupBox();
            this.ckCHDIP2_8 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP2_7 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP2_6 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP2_5 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP2_4 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP2_3 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP2_2 = new System.Windows.Forms.CheckBox();
            this.ckCHDIP2_1 = new System.Windows.Forms.CheckBox();
            this.gbCHDips = new System.Windows.Forms.GroupBox();
            this.lblShowingDIPsForChannel = new System.Windows.Forms.Label();
            this.pnlGroupedCD = new System.Windows.Forms.Panel();
            this.pnlGroupedAB = new System.Windows.Forms.Panel();
            this.rbCHDIPsD = new System.Windows.Forms.RadioButton();
            this.rbCHDIPsC = new System.Windows.Forms.RadioButton();
            this.rbCHDIPsB = new System.Windows.Forms.RadioButton();
            this.rbCHDIPsA = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSamplingSpeed = new System.Windows.Forms.Panel();
            this.chartFreqVsSens = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.tblSensitivityExamples = new System.Windows.Forms.DataGridView();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sensitivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTmr1SamplingSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrSensitivitiesExampleGenerator = new System.Windows.Forms.Timer(this.components);
            this.pnlSensitivity = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbSensitivityD = new System.Windows.Forms.ComboBox();
            this.cbSensitivityC = new System.Windows.Forms.ComboBox();
            this.cbSensitivityB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSensitivityA = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSensitivityForBank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlFilteringLevels = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblFilteringPositive = new System.Windows.Forms.Label();
            this.lblFilteringNegative = new System.Windows.Forms.Label();
            this.cbFilteringLevel = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlRelayPulseDurations = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblRelayDDelayAct = new System.Windows.Forms.Label();
            this.lblRelayDPulseNormal = new System.Windows.Forms.Label();
            this.lblRelayDPulseExtended = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblRelayCDelayAct = new System.Windows.Forms.Label();
            this.lblRelayCPulseNormal = new System.Windows.Forms.Label();
            this.lblRelayCPulseExtended = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRelayBDelayAct = new System.Windows.Forms.Label();
            this.lblRelayBPulseNormal = new System.Windows.Forms.Label();
            this.lblRelayBPulseExtended = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRelayADelayAct = new System.Windows.Forms.Label();
            this.lblRelayAPulseNormal = new System.Windows.Forms.Label();
            this.lblRelayAPulseExtended = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlPPC = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPPCDetLeaveTimer = new System.Windows.Forms.Label();
            this.lblPPCLong = new System.Windows.Forms.Label();
            this.lblPPCMedium = new System.Windows.Forms.Label();
            this.lblPPCShort = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlDetectStop = new System.Windows.Forms.Panel();
            this.lblDetectStopSlowCheckTimer = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblDetectStopTimer = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlDCDD = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.lblDCDDTimer = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlSpeedTrap = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.tblMaximumSpeedErrors = new System.Windows.Forms.DataGridView();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorstPossibleMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximumErrorKMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximumErrorPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSpeedLoopDistance = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tmrUpdateConfigPacket = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlEventViewer = new System.Windows.Forms.Panel();
            this.lblLastJointEventCD = new System.Windows.Forms.Label();
            this.lblLastEventLoopD = new System.Windows.Forms.Label();
            this.lblLastEventLoopC = new System.Windows.Forms.Label();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLastJointEventAB = new System.Windows.Forms.Label();
            this.lblLastEventLoopB = new System.Windows.Forms.Label();
            this.lblLastEventLoopA = new System.Windows.Forms.Label();
            this.lblLoggingState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.pnlSignalAnalysis = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chAnalysisLoopA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chAnalysisLoopB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chAnalysisLoopC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chAnalysisLoopD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckAutoSaveAnalysisLoopA = new System.Windows.Forms.CheckBox();
            this.btnSaveAnalysisLoopA = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveAnalysisLoopB = new System.Windows.Forms.Button();
            this.ckAutoSaveAnalysisLoopB = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveAnalysisLoopC = new System.Windows.Forms.Button();
            this.ckAutoSaveAnalysisLoopC = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveAnalysisLoopD = new System.Windows.Forms.Button();
            this.ckAutoSaveAnalysisLoopD = new System.Windows.Forms.CheckBox();
            this.lblSignalAnalysis = new System.Windows.Forms.Label();
            this.btnSignalAnalysis = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.saveAnalysisDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveChartImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveLogDialog = new System.Windows.Forms.SaveFileDialog();
            this.tmrSpeedTrapErrorGenerator = new System.Windows.Forms.Timer(this.components);
            this.pnlMiscOptions = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblRuntimeRecalibTmr = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblSlowStartupTmr = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.uctbRelayDDelayAct = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayDPulseExtended = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayDPulseNormal = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayCDelayAct = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayCPulseExtended = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayCPulseNormal = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayBDelayAct = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayBPulseExtended = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayBPulseNormal = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayADelayAct = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayAPulseExtended = new QLDConfig1v2.ucTrackBar();
            this.uctbRelayAPulseNormal = new QLDConfig1v2.ucTrackBar();
            this.uctbSensitivityUndetectThreshold = new QLDConfig1v2.ucTrackBar();
            this.uctbSensitivityDetectThreshold = new QLDConfig1v2.ucTrackBar();
            this.uctbRuntimeRecalibTmr = new QLDConfig1v2.ucTrackBar();
            this.uctbSlowStartupTimer = new QLDConfig1v2.ucTrackBar();
            this.uctbFilteringAveraging = new QLDConfig1v2.ucTrackBar();
            this.uctbFilteringPositive = new QLDConfig1v2.ucTrackBar();
            this.uctbFilteringNegative = new QLDConfig1v2.ucTrackBar();
            this.uctbDCDDThreshold = new QLDConfig1v2.ucTrackBar();
            this.uctbDCDDTimer = new QLDConfig1v2.ucTrackBar();
            this.uctbDetStopSlowCheckerTimer = new QLDConfig1v2.ucTrackBar();
            this.uctbDetStopThreshold = new QLDConfig1v2.ucTrackBar();
            this.uctbDetStopTimer = new QLDConfig1v2.ucTrackBar();
            this.uctbSamplingSpeed = new QLDConfig1v2.ucTrackBar();
            this.uctbSpeedDistance = new QLDConfig1v2.ucTrackBar();
            this.uctbPPCDetLeftThreshold = new QLDConfig1v2.ucTrackBar();
            this.uctbPPCDetLeftTimer = new QLDConfig1v2.ucTrackBar();
            this.uctbPPCLong = new QLDConfig1v2.ucTrackBar();
            this.uctbPPCMedium = new QLDConfig1v2.ucTrackBar();
            this.uctbPPCShort = new QLDConfig1v2.ucTrackBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlOperatingMode.SuspendLayout();
            this.tcMainConfigDIPs.SuspendLayout();
            this.tabGeneralDIPs.SuspendLayout();
            this.gbDIP1.SuspendLayout();
            this.gbDIP2.SuspendLayout();
            this.tabChannelDIPs.SuspendLayout();
            this.gbCHDIP1.SuspendLayout();
            this.gbCHDIP2.SuspendLayout();
            this.gbCHDips.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.pnlSamplingSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreqVsSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSensitivityExamples)).BeginInit();
            this.pnlSensitivity.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlFilteringLevels.SuspendLayout();
            this.pnlRelayPulseDurations.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlPPC.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pnlDetectStop.SuspendLayout();
            this.pnlDCDD.SuspendLayout();
            this.pnlSpeedTrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMaximumSpeedErrors)).BeginInit();
            this.pnlEventViewer.SuspendLayout();
            this.pnlSignalAnalysis.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chAnalysisLoopA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAnalysisLoopB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAnalysisLoopC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAnalysisLoopD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlMiscOptions.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 16;
            this.lbMenu.Items.AddRange(new object[] {
            "Main configuration",
            "Sampling speed",
            "Sensitivity levels",
            "Filtering levels",
            "Output pulse durations",
            "Permanent presence cancellation",
            "Detect stop",
            "Drift compensation during detection",
            "Miscellaneous",
            "Event viewer",
            "Signal analysis"});
            this.lbMenu.Location = new System.Drawing.Point(0, 49);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(224, 671);
            this.lbMenu.TabIndex = 0;
            this.lbMenu.SelectedIndexChanged += new System.EventHandler(this.lbMenu_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.openProfileToolStripMenuItem,
            this.saveProfileToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newProfileToolStripMenuItem.Image")));
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.newProfileToolStripMenuItem.Text = "New profile";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
            // 
            // openProfileToolStripMenuItem
            // 
            this.openProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openProfileToolStripMenuItem.Image")));
            this.openProfileToolStripMenuItem.Name = "openProfileToolStripMenuItem";
            this.openProfileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProfileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.openProfileToolStripMenuItem.Text = "Open profile";
            this.openProfileToolStripMenuItem.Click += new System.EventHandler(this.openProfileToolStripMenuItem_Click);
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveProfileToolStripMenuItem.Image")));
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.saveProfileToolStripMenuItem.Text = "Save profile";
            this.saveProfileToolStripMenuItem.Click += new System.EventHandler(this.saveProfileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.settingsToolStripMenuItem.Text = "Connection settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripSeparator3,
            this.readFromDeviceToolStripMenuItem,
            this.programDeviceToolStripMenuItem,
            this.returnToRunningModeToolStripMenuItem,
            this.toolStripSeparator5,
            this.restartCPUToolStripMenuItem,
            this.toolStripSeparator4,
            this.factoryResetToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripMenuItem.Image")));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.connectToolStripMenuItem.Text = "Connect/Disconnect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(218, 6);
            // 
            // readFromDeviceToolStripMenuItem
            // 
            this.readFromDeviceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readFromDeviceToolStripMenuItem.Image")));
            this.readFromDeviceToolStripMenuItem.Name = "readFromDeviceToolStripMenuItem";
            this.readFromDeviceToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.readFromDeviceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.readFromDeviceToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.readFromDeviceToolStripMenuItem.Text = "Read from device";
            this.readFromDeviceToolStripMenuItem.Click += new System.EventHandler(this.readFromDeviceToolStripMenuItem_Click);
            // 
            // programDeviceToolStripMenuItem
            // 
            this.programDeviceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("programDeviceToolStripMenuItem.Image")));
            this.programDeviceToolStripMenuItem.Name = "programDeviceToolStripMenuItem";
            this.programDeviceToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            this.programDeviceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.programDeviceToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.programDeviceToolStripMenuItem.Text = "Program device";
            this.programDeviceToolStripMenuItem.Click += new System.EventHandler(this.programDeviceToolStripMenuItem_Click);
            // 
            // returnToRunningModeToolStripMenuItem
            // 
            this.returnToRunningModeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnToRunningModeToolStripMenuItem.Image")));
            this.returnToRunningModeToolStripMenuItem.Name = "returnToRunningModeToolStripMenuItem";
            this.returnToRunningModeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.returnToRunningModeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.returnToRunningModeToolStripMenuItem.Text = "Return to running mode";
            this.returnToRunningModeToolStripMenuItem.Click += new System.EventHandler(this.returnToRunningModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(218, 6);
            // 
            // restartCPUToolStripMenuItem
            // 
            this.restartCPUToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartCPUToolStripMenuItem.Image")));
            this.restartCPUToolStripMenuItem.Name = "restartCPUToolStripMenuItem";
            this.restartCPUToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.restartCPUToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.restartCPUToolStripMenuItem.Text = "Restart CPU";
            this.restartCPUToolStripMenuItem.Click += new System.EventHandler(this.restartCPUToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(218, 6);
            // 
            // factoryResetToolStripMenuItem
            // 
            this.factoryResetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("factoryResetToolStripMenuItem.Image")));
            this.factoryResetToolStripMenuItem.Name = "factoryResetToolStripMenuItem";
            this.factoryResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.factoryResetToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.factoryResetToolStripMenuItem.Text = "Factory reset";
            this.factoryResetToolStripMenuItem.Click += new System.EventHandler(this.factoryResetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem1.Image")));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDateTime,
            this.tssConnectionStatus,
            this.tssFrequencyLoopA,
            this.tssFrequencyLoopB,
            this.tssFrequencyLoopC,
            this.tssFrequencyLoopD,
            this.tssDeviceState,
            this.tssProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 720);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "ss1";
            // 
            // tssDateTime
            // 
            this.tssDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssDateTime.Name = "tssDateTime";
            this.tssDateTime.Size = new System.Drawing.Size(16, 17);
            this.tssDateTime.Text = "...";
            // 
            // tssConnectionStatus
            // 
            this.tssConnectionStatus.BackColor = System.Drawing.Color.PeachPuff;
            this.tssConnectionStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssConnectionStatus.Name = "tssConnectionStatus";
            this.tssConnectionStatus.Size = new System.Drawing.Size(117, 17);
            this.tssConnectionStatus.Tag = "Status: %";
            this.tssConnectionStatus.Text = "Status: Disconnected";
            // 
            // tssFrequencyLoopA
            // 
            this.tssFrequencyLoopA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssFrequencyLoopA.IsLink = true;
            this.tssFrequencyLoopA.Name = "tssFrequencyLoopA";
            this.tssFrequencyLoopA.Size = new System.Drawing.Size(102, 17);
            this.tssFrequencyLoopA.Tag = "Loop A: % kHz";
            this.tssFrequencyLoopA.Text = "Loop A: Unknown";
            this.tssFrequencyLoopA.Click += new System.EventHandler(this.tssFrequencyLoopA_Click);
            // 
            // tssFrequencyLoopB
            // 
            this.tssFrequencyLoopB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssFrequencyLoopB.IsLink = true;
            this.tssFrequencyLoopB.Name = "tssFrequencyLoopB";
            this.tssFrequencyLoopB.Size = new System.Drawing.Size(101, 17);
            this.tssFrequencyLoopB.Tag = "Loop B: % kHz";
            this.tssFrequencyLoopB.Text = "Loop B: Unknown";
            this.tssFrequencyLoopB.Click += new System.EventHandler(this.tssFrequencyLoopB_Click);
            // 
            // tssFrequencyLoopC
            // 
            this.tssFrequencyLoopC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssFrequencyLoopC.IsLink = true;
            this.tssFrequencyLoopC.Name = "tssFrequencyLoopC";
            this.tssFrequencyLoopC.Size = new System.Drawing.Size(102, 17);
            this.tssFrequencyLoopC.Tag = "Loop C: % kHz";
            this.tssFrequencyLoopC.Text = "Loop C: Unknown";
            this.tssFrequencyLoopC.Click += new System.EventHandler(this.tssFrequencyLoopC_Click);
            // 
            // tssFrequencyLoopD
            // 
            this.tssFrequencyLoopD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssFrequencyLoopD.IsLink = true;
            this.tssFrequencyLoopD.Name = "tssFrequencyLoopD";
            this.tssFrequencyLoopD.Size = new System.Drawing.Size(102, 17);
            this.tssFrequencyLoopD.Tag = "Loop D: % kHz";
            this.tssFrequencyLoopD.Text = "Loop D: Unknown";
            this.tssFrequencyLoopD.Click += new System.EventHandler(this.tssFrequencyLoopD_Click);
            // 
            // tssDeviceState
            // 
            this.tssDeviceState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssDeviceState.Name = "tssDeviceState";
            this.tssDeviceState.Size = new System.Drawing.Size(90, 17);
            this.tssDeviceState.Tag = "State: %";
            this.tssDeviceState.Text = "State: Unknown";
            // 
            // tssProgress
            // 
            this.tssProgress.Name = "tssProgress";
            this.tssProgress.Size = new System.Drawing.Size(100, 16);
            this.tssProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.tssProgress.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnectDisconnect,
            this.toolStripSeparator6,
            this.btnReadFromDevice,
            this.toolStripButton1,
            this.toolStripButton5,
            this.toolStripSeparator7,
            this.toolStripButton4,
            this.toolStripSeparator8,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConnectDisconnect
            // 
            this.tsbConnectDisconnect.BackColor = System.Drawing.Color.PeachPuff;
            this.tsbConnectDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnectDisconnect.Image")));
            this.tsbConnectDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnectDisconnect.Name = "tsbConnectDisconnect";
            this.tsbConnectDisconnect.Size = new System.Drawing.Size(159, 22);
            this.tsbConnectDisconnect.Text = "Connect/Disconnect (F1)";
            this.tsbConnectDisconnect.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnReadFromDevice
            // 
            this.btnReadFromDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnReadFromDevice.Image")));
            this.btnReadFromDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReadFromDevice.Name = "btnReadFromDevice";
            this.btnReadFromDevice.Size = new System.Drawing.Size(142, 22);
            this.btnReadFromDevice.Text = "Read from device (F2)";
            this.btnReadFromDevice.Click += new System.EventHandler(this.readFromDeviceToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(133, 22);
            this.toolStripButton1.Text = "Program device (F3)";
            this.toolStripButton1.Click += new System.EventHandler(this.programDeviceToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(178, 22);
            this.toolStripButton5.Text = "Return to running mode (F4)";
            this.toolStripButton5.Click += new System.EventHandler(this.returnToRunningModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackColor = System.Drawing.Color.Moccasin;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton4.Text = "Restart CPU (F5)";
            this.toolStripButton4.Click += new System.EventHandler(this.restartCPUToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(123, 22);
            this.toolStripButton3.Text = "Factory reset (F10)";
            this.toolStripButton3.Click += new System.EventHandler(this.factoryResetToolStripMenuItem_Click);
            // 
            // sp
            // 
            this.sp.BaudRate = 115200;
            this.sp.PortName = "COM3";
            this.sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 500;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // pnlOperatingMode
            // 
            this.pnlOperatingMode.Controls.Add(this.tcMainConfigDIPs);
            this.pnlOperatingMode.Controls.Add(this.tabControl1);
            this.pnlOperatingMode.Controls.Add(this.groupBox6);
            this.pnlOperatingMode.Controls.Add(this.label2);
            this.pnlOperatingMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperatingMode.Location = new System.Drawing.Point(224, 49);
            this.pnlOperatingMode.Name = "pnlOperatingMode";
            this.pnlOperatingMode.Size = new System.Drawing.Size(728, 671);
            this.pnlOperatingMode.TabIndex = 5;
            this.pnlOperatingMode.Tag = "0";
            // 
            // tcMainConfigDIPs
            // 
            this.tcMainConfigDIPs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainConfigDIPs.Controls.Add(this.tabGeneralDIPs);
            this.tcMainConfigDIPs.Controls.Add(this.tabChannelDIPs);
            this.tcMainConfigDIPs.Location = new System.Drawing.Point(6, 33);
            this.tcMainConfigDIPs.Name = "tcMainConfigDIPs";
            this.tcMainConfigDIPs.SelectedIndex = 0;
            this.tcMainConfigDIPs.Size = new System.Drawing.Size(719, 417);
            this.tcMainConfigDIPs.TabIndex = 13;
            this.tcMainConfigDIPs.SelectedIndexChanged += new System.EventHandler(this.tcMainConfigDIPs_SelectedIndexChanged);
            // 
            // tabGeneralDIPs
            // 
            this.tabGeneralDIPs.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeneralDIPs.Controls.Add(this.gbDIP1);
            this.tabGeneralDIPs.Controls.Add(this.gbDIP2);
            this.tabGeneralDIPs.Controls.Add(this.label26);
            this.tabGeneralDIPs.Controls.Add(this.ckUseSoftDIPs);
            this.tabGeneralDIPs.Controls.Add(this.label1);
            this.tabGeneralDIPs.Controls.Add(this.cbQuickPresets);
            this.tabGeneralDIPs.Controls.Add(this.btnReadDIPsFromDevice);
            this.tabGeneralDIPs.Controls.Add(this.label27);
            this.tabGeneralDIPs.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralDIPs.Name = "tabGeneralDIPs";
            this.tabGeneralDIPs.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralDIPs.Size = new System.Drawing.Size(711, 391);
            this.tabGeneralDIPs.TabIndex = 1;
            this.tabGeneralDIPs.Text = "General DIPs";
            // 
            // gbDIP1
            // 
            this.gbDIP1.Controls.Add(this.checkBox8);
            this.gbDIP1.Controls.Add(this.checkBox7);
            this.gbDIP1.Controls.Add(this.ckGenDIP1_6);
            this.gbDIP1.Controls.Add(this.ckGenDIP1_5);
            this.gbDIP1.Controls.Add(this.ckGenDIP1_4);
            this.gbDIP1.Controls.Add(this.ckGenDIP1_3);
            this.gbDIP1.Controls.Add(this.ckGenDIP1_2);
            this.gbDIP1.Controls.Add(this.ckGenDIP1_1);
            this.gbDIP1.Location = new System.Drawing.Point(5, 36);
            this.gbDIP1.Name = "gbDIP1";
            this.gbDIP1.Size = new System.Drawing.Size(340, 227);
            this.gbDIP1.TabIndex = 3;
            this.gbDIP1.TabStop = false;
            this.gbDIP1.Text = "DIP 1";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Location = new System.Drawing.Point(16, 195);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(94, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Tag = "7";
            this.checkBox8.Text = "8. - reserved  -";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Enabled = false;
            this.checkBox7.Location = new System.Drawing.Point(16, 172);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(91, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Tag = "6";
            this.checkBox7.Text = "7. - reserved -";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // ckGenDIP1_6
            // 
            this.ckGenDIP1_6.AutoSize = true;
            this.ckGenDIP1_6.Location = new System.Drawing.Point(16, 148);
            this.ckGenDIP1_6.Name = "ckGenDIP1_6";
            this.ckGenDIP1_6.Size = new System.Drawing.Size(141, 17);
            this.ckGenDIP1_6.TabIndex = 5;
            this.ckGenDIP1_6.Tag = "5";
            this.ckGenDIP1_6.Text = "6. C+D Directional mode";
            this.ckGenDIP1_6.UseVisualStyleBackColor = true;
            this.ckGenDIP1_6.CheckedChanged += new System.EventHandler(this.hndlChannelOnOffAndModeChange);
            // 
            // ckGenDIP1_5
            // 
            this.ckGenDIP1_5.AutoSize = true;
            this.ckGenDIP1_5.Location = new System.Drawing.Point(16, 125);
            this.ckGenDIP1_5.Name = "ckGenDIP1_5";
            this.ckGenDIP1_5.Size = new System.Drawing.Size(141, 17);
            this.ckGenDIP1_5.TabIndex = 4;
            this.ckGenDIP1_5.Tag = "4";
            this.ckGenDIP1_5.Text = "5. A+B Directional Mode";
            this.ckGenDIP1_5.UseVisualStyleBackColor = true;
            this.ckGenDIP1_5.CheckedChanged += new System.EventHandler(this.hndlChannelOnOffAndModeChange);
            // 
            // ckGenDIP1_4
            // 
            this.ckGenDIP1_4.AutoSize = true;
            this.ckGenDIP1_4.Location = new System.Drawing.Point(16, 102);
            this.ckGenDIP1_4.Name = "ckGenDIP1_4";
            this.ckGenDIP1_4.Size = new System.Drawing.Size(130, 17);
            this.ckGenDIP1_4.TabIndex = 3;
            this.ckGenDIP1_4.Tag = "3";
            this.ckGenDIP1_4.Text = "4. Channel D Enabled";
            this.ckGenDIP1_4.UseVisualStyleBackColor = true;
            this.ckGenDIP1_4.CheckedChanged += new System.EventHandler(this.hndlChannelOnOffAndModeChange);
            // 
            // ckGenDIP1_3
            // 
            this.ckGenDIP1_3.AutoSize = true;
            this.ckGenDIP1_3.Location = new System.Drawing.Point(16, 79);
            this.ckGenDIP1_3.Name = "ckGenDIP1_3";
            this.ckGenDIP1_3.Size = new System.Drawing.Size(129, 17);
            this.ckGenDIP1_3.TabIndex = 2;
            this.ckGenDIP1_3.Tag = "2";
            this.ckGenDIP1_3.Text = "3. Channel C Enabled";
            this.ckGenDIP1_3.UseVisualStyleBackColor = true;
            this.ckGenDIP1_3.CheckedChanged += new System.EventHandler(this.hndlChannelOnOffAndModeChange);
            // 
            // ckGenDIP1_2
            // 
            this.ckGenDIP1_2.AutoSize = true;
            this.ckGenDIP1_2.Location = new System.Drawing.Point(16, 56);
            this.ckGenDIP1_2.Name = "ckGenDIP1_2";
            this.ckGenDIP1_2.Size = new System.Drawing.Size(129, 17);
            this.ckGenDIP1_2.TabIndex = 1;
            this.ckGenDIP1_2.Tag = "1";
            this.ckGenDIP1_2.Text = "2. Channel B Enabled";
            this.ckGenDIP1_2.UseVisualStyleBackColor = true;
            this.ckGenDIP1_2.CheckedChanged += new System.EventHandler(this.hndlChannelOnOffAndModeChange);
            // 
            // ckGenDIP1_1
            // 
            this.ckGenDIP1_1.AutoSize = true;
            this.ckGenDIP1_1.Location = new System.Drawing.Point(16, 32);
            this.ckGenDIP1_1.Name = "ckGenDIP1_1";
            this.ckGenDIP1_1.Size = new System.Drawing.Size(129, 17);
            this.ckGenDIP1_1.TabIndex = 0;
            this.ckGenDIP1_1.Tag = "0";
            this.ckGenDIP1_1.Text = "1. Channel A Enabled";
            this.ckGenDIP1_1.UseVisualStyleBackColor = true;
            this.ckGenDIP1_1.CheckedChanged += new System.EventHandler(this.hndlChannelOnOffAndModeChange);
            // 
            // gbDIP2
            // 
            this.gbDIP2.Controls.Add(this.ckGenDIP2_8);
            this.gbDIP2.Controls.Add(this.ckGenDIP2_7);
            this.gbDIP2.Controls.Add(this.ckGenDIP2_6);
            this.gbDIP2.Controls.Add(this.ckGenDIP2_5);
            this.gbDIP2.Controls.Add(this.checkBox13);
            this.gbDIP2.Controls.Add(this.checkBox14);
            this.gbDIP2.Controls.Add(this.checkBox15);
            this.gbDIP2.Controls.Add(this.checkBox16);
            this.gbDIP2.Location = new System.Drawing.Point(362, 36);
            this.gbDIP2.Name = "gbDIP2";
            this.gbDIP2.Size = new System.Drawing.Size(340, 227);
            this.gbDIP2.TabIndex = 4;
            this.gbDIP2.TabStop = false;
            this.gbDIP2.Text = "DIP 2";
            // 
            // ckGenDIP2_8
            // 
            this.ckGenDIP2_8.AutoSize = true;
            this.ckGenDIP2_8.Enabled = false;
            this.ckGenDIP2_8.Location = new System.Drawing.Point(16, 195);
            this.ckGenDIP2_8.Name = "ckGenDIP2_8";
            this.ckGenDIP2_8.Size = new System.Drawing.Size(172, 17);
            this.ckGenDIP2_8.TabIndex = 7;
            this.ckGenDIP2_8.Tag = "7";
            this.ckGenDIP2_8.Text = "8. C+D Detect Reversing D->C";
            this.ckGenDIP2_8.UseVisualStyleBackColor = true;
            // 
            // ckGenDIP2_7
            // 
            this.ckGenDIP2_7.AutoSize = true;
            this.ckGenDIP2_7.Enabled = false;
            this.ckGenDIP2_7.Location = new System.Drawing.Point(16, 172);
            this.ckGenDIP2_7.Name = "ckGenDIP2_7";
            this.ckGenDIP2_7.Size = new System.Drawing.Size(172, 17);
            this.ckGenDIP2_7.TabIndex = 6;
            this.ckGenDIP2_7.Tag = "6";
            this.ckGenDIP2_7.Text = "7. C+D Detect Reversing C->D";
            this.ckGenDIP2_7.UseVisualStyleBackColor = true;
            // 
            // ckGenDIP2_6
            // 
            this.ckGenDIP2_6.AutoSize = true;
            this.ckGenDIP2_6.Enabled = false;
            this.ckGenDIP2_6.Location = new System.Drawing.Point(16, 148);
            this.ckGenDIP2_6.Name = "ckGenDIP2_6";
            this.ckGenDIP2_6.Size = new System.Drawing.Size(170, 17);
            this.ckGenDIP2_6.TabIndex = 5;
            this.ckGenDIP2_6.Tag = "5";
            this.ckGenDIP2_6.Text = "6. A+B Detect Reversing B->A";
            this.ckGenDIP2_6.UseVisualStyleBackColor = true;
            // 
            // ckGenDIP2_5
            // 
            this.ckGenDIP2_5.AutoSize = true;
            this.ckGenDIP2_5.Enabled = false;
            this.ckGenDIP2_5.Location = new System.Drawing.Point(16, 125);
            this.ckGenDIP2_5.Name = "ckGenDIP2_5";
            this.ckGenDIP2_5.Size = new System.Drawing.Size(170, 17);
            this.ckGenDIP2_5.TabIndex = 4;
            this.ckGenDIP2_5.Tag = "4";
            this.ckGenDIP2_5.Text = "5. A+B Detect Reversing A->B";
            this.ckGenDIP2_5.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(16, 102);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(133, 17);
            this.checkBox13.TabIndex = 3;
            this.checkBox13.Tag = "3";
            this.checkBox13.Text = "4. Autotune on Startup";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(16, 79);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(152, 17);
            this.checkBox14.TabIndex = 2;
            this.checkBox14.Tag = "2";
            this.checkBox14.Text = "3. Slow Startup (Warm Up)";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(16, 56);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(166, 17);
            this.checkBox15.TabIndex = 1;
            this.checkBox15.Tag = "1";
            this.checkBox15.Text = "2. Blink Frequency on Startup";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(16, 32);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(155, 17);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Tag = "0";
            this.checkBox16.Text = "1. Additional Signal Filtering";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(6, 272);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(693, 47);
            this.label26.TabIndex = 7;
            this.label26.Text = resources.GetString("label26.Text");
            // 
            // ckUseSoftDIPs
            // 
            this.ckUseSoftDIPs.AutoSize = true;
            this.ckUseSoftDIPs.Location = new System.Drawing.Point(437, 10);
            this.ckUseSoftDIPs.Name = "ckUseSoftDIPs";
            this.ckUseSoftDIPs.Size = new System.Drawing.Size(262, 17);
            this.ckUseSoftDIPs.TabIndex = 6;
            this.ckUseSoftDIPs.Tag = "UPDATE_CONFIG_PACKET";
            this.ckUseSoftDIPs.Text = "Use software DIPs (ignore DIP settings on device)";
            this.ckUseSoftDIPs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quick presets:";
            // 
            // cbQuickPresets
            // 
            this.cbQuickPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuickPresets.DropDownWidth = 380;
            this.cbQuickPresets.FormattingEnabled = true;
            this.cbQuickPresets.Items.AddRange(new object[] {
            "- Choose preset -",
            "Single Channel (A)",
            "Two Channels (A) and (B)",
            "Three Channels (A), (B) and (C)",
            "Four Channels (A), (B), (C) and (D)",
            "Two Channels Directional Logic (A + B)",
            "Two Channels Directional Logic (A + B) and One Channel (C)",
            "Two Channels Directional Logic (A + B) and Two Channels (C) and (D)",
            "Four Channels Directional Logic (A + B) and (C + D)"});
            this.cbQuickPresets.Location = new System.Drawing.Point(89, 8);
            this.cbQuickPresets.Name = "cbQuickPresets";
            this.cbQuickPresets.Size = new System.Drawing.Size(342, 21);
            this.cbQuickPresets.TabIndex = 0;
            this.cbQuickPresets.SelectedIndexChanged += new System.EventHandler(this.cbQuickPresets_SelectedIndexChanged);
            // 
            // btnReadDIPsFromDevice
            // 
            this.btnReadDIPsFromDevice.AutoSize = true;
            this.btnReadDIPsFromDevice.Location = new System.Drawing.Point(333, 322);
            this.btnReadDIPsFromDevice.Name = "btnReadDIPsFromDevice";
            this.btnReadDIPsFromDevice.Size = new System.Drawing.Size(105, 23);
            this.btnReadDIPsFromDevice.TabIndex = 9;
            this.btnReadDIPsFromDevice.Text = "Read from device";
            this.btnReadDIPsFromDevice.UseVisualStyleBackColor = true;
            this.btnReadDIPsFromDevice.Click += new System.EventHandler(this.btnReadDIPsFromDevice_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 327);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(319, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "If you want to read device\'s current configuration, click the button:";
            // 
            // tabChannelDIPs
            // 
            this.tabChannelDIPs.BackColor = System.Drawing.SystemColors.Control;
            this.tabChannelDIPs.Controls.Add(this.cbCopyCHDIPsFrom);
            this.tabChannelDIPs.Controls.Add(this.label34);
            this.tabChannelDIPs.Controls.Add(this.btnCHDipsCopyFrom);
            this.tabChannelDIPs.Controls.Add(this.gbCHDIP1);
            this.tabChannelDIPs.Controls.Add(this.gbCHDIP2);
            this.tabChannelDIPs.Controls.Add(this.gbCHDips);
            this.tabChannelDIPs.Location = new System.Drawing.Point(4, 22);
            this.tabChannelDIPs.Name = "tabChannelDIPs";
            this.tabChannelDIPs.Padding = new System.Windows.Forms.Padding(3);
            this.tabChannelDIPs.Size = new System.Drawing.Size(711, 391);
            this.tabChannelDIPs.TabIndex = 0;
            this.tabChannelDIPs.Text = "Channel DIPs";
            // 
            // cbCopyCHDIPsFrom
            // 
            this.cbCopyCHDIPsFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCopyCHDIPsFrom.FormattingEnabled = true;
            this.cbCopyCHDIPsFrom.Items.AddRange(new object[] {
            "Channel A",
            "Channel B",
            "Channel C",
            "Channel D"});
            this.cbCopyCHDIPsFrom.Location = new System.Drawing.Point(107, 303);
            this.cbCopyCHDIPsFrom.MaxDropDownItems = 4;
            this.cbCopyCHDIPsFrom.Name = "cbCopyCHDIPsFrom";
            this.cbCopyCHDIPsFrom.Size = new System.Drawing.Size(97, 21);
            this.cbCopyCHDIPsFrom.TabIndex = 9;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 307);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(96, 13);
            this.label34.TabIndex = 8;
            this.label34.Text = "Copy settings from:";
            // 
            // btnCHDipsCopyFrom
            // 
            this.btnCHDipsCopyFrom.AutoSize = true;
            this.btnCHDipsCopyFrom.Location = new System.Drawing.Point(210, 302);
            this.btnCHDipsCopyFrom.Name = "btnCHDipsCopyFrom";
            this.btnCHDipsCopyFrom.Size = new System.Drawing.Size(41, 23);
            this.btnCHDipsCopyFrom.TabIndex = 7;
            this.btnCHDipsCopyFrom.Text = "Copy";
            this.btnCHDipsCopyFrom.UseVisualStyleBackColor = true;
            this.btnCHDipsCopyFrom.Click += new System.EventHandler(this.btnCHDipsCopyFrom_Click);
            // 
            // gbCHDIP1
            // 
            this.gbCHDIP1.Controls.Add(this.ckCHDIP1_8);
            this.gbCHDIP1.Controls.Add(this.ckCHDIP1_7);
            this.gbCHDIP1.Controls.Add(this.ckCHDIP1_6);
            this.gbCHDIP1.Controls.Add(this.ckCHDIP1_5);
            this.gbCHDIP1.Controls.Add(this.ckCHDIP1_4);
            this.gbCHDIP1.Controls.Add(this.ckCHDIP1_3);
            this.gbCHDIP1.Controls.Add(this.ckCHDIP1_2);
            this.gbCHDIP1.Controls.Add(this.ckCHDIP1_1);
            this.gbCHDIP1.Location = new System.Drawing.Point(5, 69);
            this.gbCHDIP1.Name = "gbCHDIP1";
            this.gbCHDIP1.Size = new System.Drawing.Size(340, 227);
            this.gbCHDIP1.TabIndex = 5;
            this.gbCHDIP1.TabStop = false;
            this.gbCHDIP1.Tag = "DIP1";
            this.gbCHDIP1.Text = "DIP 1";
            // 
            // ckCHDIP1_8
            // 
            this.ckCHDIP1_8.AutoSize = true;
            this.ckCHDIP1_8.Location = new System.Drawing.Point(16, 195);
            this.ckCHDIP1_8.Name = "ckCHDIP1_8";
            this.ckCHDIP1_8.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP1_8.TabIndex = 7;
            this.ckCHDIP1_8.Tag = "7";
            this.ckCHDIP1_8.Text = "checkBox17";
            this.ckCHDIP1_8.UseVisualStyleBackColor = true;
            this.ckCHDIP1_8.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP1_7
            // 
            this.ckCHDIP1_7.AutoSize = true;
            this.ckCHDIP1_7.Location = new System.Drawing.Point(16, 172);
            this.ckCHDIP1_7.Name = "ckCHDIP1_7";
            this.ckCHDIP1_7.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP1_7.TabIndex = 6;
            this.ckCHDIP1_7.Tag = "6";
            this.ckCHDIP1_7.Text = "checkBox18";
            this.ckCHDIP1_7.UseVisualStyleBackColor = true;
            this.ckCHDIP1_7.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP1_6
            // 
            this.ckCHDIP1_6.AutoSize = true;
            this.ckCHDIP1_6.Location = new System.Drawing.Point(16, 148);
            this.ckCHDIP1_6.Name = "ckCHDIP1_6";
            this.ckCHDIP1_6.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP1_6.TabIndex = 5;
            this.ckCHDIP1_6.Tag = "5";
            this.ckCHDIP1_6.Text = "checkBox19";
            this.ckCHDIP1_6.UseVisualStyleBackColor = true;
            this.ckCHDIP1_6.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP1_5
            // 
            this.ckCHDIP1_5.AutoSize = true;
            this.ckCHDIP1_5.Location = new System.Drawing.Point(16, 125);
            this.ckCHDIP1_5.Name = "ckCHDIP1_5";
            this.ckCHDIP1_5.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP1_5.TabIndex = 4;
            this.ckCHDIP1_5.Tag = "4";
            this.ckCHDIP1_5.Text = "checkBox20";
            this.ckCHDIP1_5.UseVisualStyleBackColor = true;
            this.ckCHDIP1_5.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP1_4
            // 
            this.ckCHDIP1_4.AutoSize = true;
            this.ckCHDIP1_4.Location = new System.Drawing.Point(16, 102);
            this.ckCHDIP1_4.Name = "ckCHDIP1_4";
            this.ckCHDIP1_4.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP1_4.TabIndex = 3;
            this.ckCHDIP1_4.Tag = "3";
            this.ckCHDIP1_4.Text = "checkBox21";
            this.ckCHDIP1_4.UseVisualStyleBackColor = true;
            this.ckCHDIP1_4.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP1_3
            // 
            this.ckCHDIP1_3.AutoSize = true;
            this.ckCHDIP1_3.Location = new System.Drawing.Point(16, 79);
            this.ckCHDIP1_3.Name = "ckCHDIP1_3";
            this.ckCHDIP1_3.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP1_3.TabIndex = 2;
            this.ckCHDIP1_3.Tag = "2";
            this.ckCHDIP1_3.Text = "checkBox22";
            this.ckCHDIP1_3.UseVisualStyleBackColor = true;
            this.ckCHDIP1_3.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP1_2
            // 
            this.ckCHDIP1_2.AutoSize = true;
            this.ckCHDIP1_2.Location = new System.Drawing.Point(16, 56);
            this.ckCHDIP1_2.Name = "ckCHDIP1_2";
            this.ckCHDIP1_2.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP1_2.TabIndex = 1;
            this.ckCHDIP1_2.Tag = "1";
            this.ckCHDIP1_2.Text = "checkBox23";
            this.ckCHDIP1_2.UseVisualStyleBackColor = true;
            this.ckCHDIP1_2.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP1_1
            // 
            this.ckCHDIP1_1.AutoSize = true;
            this.ckCHDIP1_1.Location = new System.Drawing.Point(16, 32);
            this.ckCHDIP1_1.Name = "ckCHDIP1_1";
            this.ckCHDIP1_1.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP1_1.TabIndex = 0;
            this.ckCHDIP1_1.Tag = "0";
            this.ckCHDIP1_1.Text = "checkBox24";
            this.ckCHDIP1_1.UseVisualStyleBackColor = true;
            this.ckCHDIP1_1.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // gbCHDIP2
            // 
            this.gbCHDIP2.Controls.Add(this.ckCHDIP2_8);
            this.gbCHDIP2.Controls.Add(this.ckCHDIP2_7);
            this.gbCHDIP2.Controls.Add(this.ckCHDIP2_6);
            this.gbCHDIP2.Controls.Add(this.ckCHDIP2_5);
            this.gbCHDIP2.Controls.Add(this.ckCHDIP2_4);
            this.gbCHDIP2.Controls.Add(this.ckCHDIP2_3);
            this.gbCHDIP2.Controls.Add(this.ckCHDIP2_2);
            this.gbCHDIP2.Controls.Add(this.ckCHDIP2_1);
            this.gbCHDIP2.Location = new System.Drawing.Point(362, 69);
            this.gbCHDIP2.Name = "gbCHDIP2";
            this.gbCHDIP2.Size = new System.Drawing.Size(340, 227);
            this.gbCHDIP2.TabIndex = 6;
            this.gbCHDIP2.TabStop = false;
            this.gbCHDIP2.Tag = "DIP2";
            this.gbCHDIP2.Text = "DIP 2";
            // 
            // ckCHDIP2_8
            // 
            this.ckCHDIP2_8.AutoSize = true;
            this.ckCHDIP2_8.Enabled = false;
            this.ckCHDIP2_8.Location = new System.Drawing.Point(16, 195);
            this.ckCHDIP2_8.Name = "ckCHDIP2_8";
            this.ckCHDIP2_8.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP2_8.TabIndex = 7;
            this.ckCHDIP2_8.Tag = "7";
            this.ckCHDIP2_8.Text = "checkBox25";
            this.ckCHDIP2_8.UseVisualStyleBackColor = true;
            this.ckCHDIP2_8.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP2_7
            // 
            this.ckCHDIP2_7.AutoSize = true;
            this.ckCHDIP2_7.Enabled = false;
            this.ckCHDIP2_7.Location = new System.Drawing.Point(16, 172);
            this.ckCHDIP2_7.Name = "ckCHDIP2_7";
            this.ckCHDIP2_7.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP2_7.TabIndex = 6;
            this.ckCHDIP2_7.Tag = "6";
            this.ckCHDIP2_7.Text = "checkBox26";
            this.ckCHDIP2_7.UseVisualStyleBackColor = true;
            this.ckCHDIP2_7.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP2_6
            // 
            this.ckCHDIP2_6.AutoSize = true;
            this.ckCHDIP2_6.Location = new System.Drawing.Point(16, 148);
            this.ckCHDIP2_6.Name = "ckCHDIP2_6";
            this.ckCHDIP2_6.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP2_6.TabIndex = 5;
            this.ckCHDIP2_6.Tag = "5";
            this.ckCHDIP2_6.Text = "checkBox27";
            this.ckCHDIP2_6.UseVisualStyleBackColor = true;
            this.ckCHDIP2_6.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP2_5
            // 
            this.ckCHDIP2_5.AutoSize = true;
            this.ckCHDIP2_5.Location = new System.Drawing.Point(16, 125);
            this.ckCHDIP2_5.Name = "ckCHDIP2_5";
            this.ckCHDIP2_5.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP2_5.TabIndex = 4;
            this.ckCHDIP2_5.Tag = "4";
            this.ckCHDIP2_5.Text = "checkBox28";
            this.ckCHDIP2_5.UseVisualStyleBackColor = true;
            this.ckCHDIP2_5.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP2_4
            // 
            this.ckCHDIP2_4.AutoSize = true;
            this.ckCHDIP2_4.Location = new System.Drawing.Point(16, 102);
            this.ckCHDIP2_4.Name = "ckCHDIP2_4";
            this.ckCHDIP2_4.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP2_4.TabIndex = 3;
            this.ckCHDIP2_4.Tag = "3";
            this.ckCHDIP2_4.Text = "checkBox29";
            this.ckCHDIP2_4.UseVisualStyleBackColor = true;
            this.ckCHDIP2_4.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP2_3
            // 
            this.ckCHDIP2_3.AutoSize = true;
            this.ckCHDIP2_3.Location = new System.Drawing.Point(16, 79);
            this.ckCHDIP2_3.Name = "ckCHDIP2_3";
            this.ckCHDIP2_3.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP2_3.TabIndex = 2;
            this.ckCHDIP2_3.Tag = "2";
            this.ckCHDIP2_3.Text = "checkBox30";
            this.ckCHDIP2_3.UseVisualStyleBackColor = true;
            this.ckCHDIP2_3.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP2_2
            // 
            this.ckCHDIP2_2.AutoSize = true;
            this.ckCHDIP2_2.Location = new System.Drawing.Point(16, 56);
            this.ckCHDIP2_2.Name = "ckCHDIP2_2";
            this.ckCHDIP2_2.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP2_2.TabIndex = 1;
            this.ckCHDIP2_2.Tag = "1";
            this.ckCHDIP2_2.Text = "checkBox31";
            this.ckCHDIP2_2.UseVisualStyleBackColor = true;
            this.ckCHDIP2_2.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // ckCHDIP2_1
            // 
            this.ckCHDIP2_1.AutoSize = true;
            this.ckCHDIP2_1.Location = new System.Drawing.Point(16, 32);
            this.ckCHDIP2_1.Name = "ckCHDIP2_1";
            this.ckCHDIP2_1.Size = new System.Drawing.Size(86, 17);
            this.ckCHDIP2_1.TabIndex = 0;
            this.ckCHDIP2_1.Tag = "0";
            this.ckCHDIP2_1.Text = "checkBox32";
            this.ckCHDIP2_1.UseVisualStyleBackColor = true;
            this.ckCHDIP2_1.CheckedChanged += new System.EventHandler(this.ckCHDIP_Changed);
            // 
            // gbCHDips
            // 
            this.gbCHDips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCHDips.Controls.Add(this.lblShowingDIPsForChannel);
            this.gbCHDips.Controls.Add(this.pnlGroupedCD);
            this.gbCHDips.Controls.Add(this.pnlGroupedAB);
            this.gbCHDips.Controls.Add(this.rbCHDIPsD);
            this.gbCHDips.Controls.Add(this.rbCHDIPsC);
            this.gbCHDips.Controls.Add(this.rbCHDIPsB);
            this.gbCHDips.Controls.Add(this.rbCHDIPsA);
            this.gbCHDips.Location = new System.Drawing.Point(5, 6);
            this.gbCHDips.Name = "gbCHDips";
            this.gbCHDips.Size = new System.Drawing.Size(701, 57);
            this.gbCHDips.TabIndex = 0;
            this.gbCHDips.TabStop = false;
            this.gbCHDips.Text = "Channel";
            // 
            // lblShowingDIPsForChannel
            // 
            this.lblShowingDIPsForChannel.AutoSize = true;
            this.lblShowingDIPsForChannel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblShowingDIPsForChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowingDIPsForChannel.Location = new System.Drawing.Point(370, 25);
            this.lblShowingDIPsForChannel.Name = "lblShowingDIPsForChannel";
            this.lblShowingDIPsForChannel.Size = new System.Drawing.Size(19, 13);
            this.lblShowingDIPsForChannel.TabIndex = 6;
            this.lblShowingDIPsForChannel.Tag = "Showing DIPs for Channel %";
            this.lblShowingDIPsForChannel.Text = "...";
            // 
            // pnlGroupedCD
            // 
            this.pnlGroupedCD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlGroupedCD.Location = new System.Drawing.Point(183, 43);
            this.pnlGroupedCD.Name = "pnlGroupedCD";
            this.pnlGroupedCD.Size = new System.Drawing.Size(170, 5);
            this.pnlGroupedCD.TabIndex = 5;
            this.pnlGroupedCD.Visible = false;
            // 
            // pnlGroupedAB
            // 
            this.pnlGroupedAB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlGroupedAB.Location = new System.Drawing.Point(7, 43);
            this.pnlGroupedAB.Name = "pnlGroupedAB";
            this.pnlGroupedAB.Size = new System.Drawing.Size(170, 5);
            this.pnlGroupedAB.TabIndex = 4;
            this.pnlGroupedAB.Visible = false;
            // 
            // rbCHDIPsD
            // 
            this.rbCHDIPsD.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCHDIPsD.Location = new System.Drawing.Point(271, 19);
            this.rbCHDIPsD.Name = "rbCHDIPsD";
            this.rbCHDIPsD.Size = new System.Drawing.Size(82, 23);
            this.rbCHDIPsD.TabIndex = 3;
            this.rbCHDIPsD.TabStop = true;
            this.rbCHDIPsD.Tag = "3";
            this.rbCHDIPsD.Text = "Channel D";
            this.rbCHDIPsD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCHDIPsD.UseVisualStyleBackColor = true;
            this.rbCHDIPsD.CheckedChanged += new System.EventHandler(this.rbCHDIPs_Changed);
            // 
            // rbCHDIPsC
            // 
            this.rbCHDIPsC.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCHDIPsC.Location = new System.Drawing.Point(183, 19);
            this.rbCHDIPsC.Name = "rbCHDIPsC";
            this.rbCHDIPsC.Size = new System.Drawing.Size(82, 23);
            this.rbCHDIPsC.TabIndex = 2;
            this.rbCHDIPsC.TabStop = true;
            this.rbCHDIPsC.Tag = "2";
            this.rbCHDIPsC.Text = "Channel C";
            this.rbCHDIPsC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCHDIPsC.UseVisualStyleBackColor = true;
            this.rbCHDIPsC.CheckedChanged += new System.EventHandler(this.rbCHDIPs_Changed);
            // 
            // rbCHDIPsB
            // 
            this.rbCHDIPsB.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCHDIPsB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rbCHDIPsB.Location = new System.Drawing.Point(95, 19);
            this.rbCHDIPsB.Name = "rbCHDIPsB";
            this.rbCHDIPsB.Size = new System.Drawing.Size(82, 23);
            this.rbCHDIPsB.TabIndex = 1;
            this.rbCHDIPsB.TabStop = true;
            this.rbCHDIPsB.Tag = "1";
            this.rbCHDIPsB.Text = "Channel B";
            this.rbCHDIPsB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCHDIPsB.UseVisualStyleBackColor = false;
            this.rbCHDIPsB.CheckedChanged += new System.EventHandler(this.rbCHDIPs_Changed);
            // 
            // rbCHDIPsA
            // 
            this.rbCHDIPsA.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCHDIPsA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rbCHDIPsA.Location = new System.Drawing.Point(7, 19);
            this.rbCHDIPsA.Name = "rbCHDIPsA";
            this.rbCHDIPsA.Size = new System.Drawing.Size(82, 23);
            this.rbCHDIPsA.TabIndex = 0;
            this.rbCHDIPsA.TabStop = true;
            this.rbCHDIPsA.Tag = "0";
            this.rbCHDIPsA.Text = "Channel A";
            this.rbCHDIPsA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCHDIPsA.UseVisualStyleBackColor = false;
            this.rbCHDIPsA.CheckedChanged += new System.EventHandler(this.rbCHDIPs_Changed);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 453);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(270, 209);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(262, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "v1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.cbBaudRate);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Location = new System.Drawing.Point(280, 461);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(441, 199);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "UART speed";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.Location = new System.Drawing.Point(6, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(429, 33);
            this.label33.TabIndex = 13;
            this.label33.Text = "After changing UART port speed in device and resetting it, do not forget to open " +
    "File -> Connection settings, and set the same port speed.";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "115200",
            "57600",
            "19200",
            "9600"});
            this.cbBaudRate.Location = new System.Drawing.Point(149, 22);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudRate.TabIndex = 12;
            this.cbBaudRate.Tag = "UPDATE_CONFIG_PACKET";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 25);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(137, 13);
            this.label32.TabIndex = 11;
            this.label32.Text = "Device\'s UART port speed:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(728, 27);
            this.label2.TabIndex = 2;
            this.label2.Tag = "title";
            this.label2.Text = "main config";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSamplingSpeed
            // 
            this.pnlSamplingSpeed.Controls.Add(this.chartFreqVsSens);
            this.pnlSamplingSpeed.Controls.Add(this.label5);
            this.pnlSamplingSpeed.Controls.Add(this.tblSensitivityExamples);
            this.pnlSamplingSpeed.Controls.Add(this.lblTmr1SamplingSpeed);
            this.pnlSamplingSpeed.Controls.Add(this.uctbSamplingSpeed);
            this.pnlSamplingSpeed.Controls.Add(this.label4);
            this.pnlSamplingSpeed.Controls.Add(this.label3);
            this.pnlSamplingSpeed.Location = new System.Drawing.Point(224, 49);
            this.pnlSamplingSpeed.Name = "pnlSamplingSpeed";
            this.pnlSamplingSpeed.Size = new System.Drawing.Size(728, 639);
            this.pnlSamplingSpeed.TabIndex = 6;
            this.pnlSamplingSpeed.Tag = "1";
            // 
            // chartFreqVsSens
            // 
            this.chartFreqVsSens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFreqVsSens.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFreqVsSens.Legends.Add(legend1);
            this.chartFreqVsSens.Location = new System.Drawing.Point(290, 173);
            this.chartFreqVsSens.Name = "chartFreqVsSens";
            this.chartFreqVsSens.Size = new System.Drawing.Size(426, 456);
            this.chartFreqVsSens.TabIndex = 10;
            this.chartFreqVsSens.Text = "Frequency vs Sensitivity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Best possible sensitivities for chosen sampling speed:";
            // 
            // tblSensitivityExamples
            // 
            this.tblSensitivityExamples.AllowUserToAddRows = false;
            this.tblSensitivityExamples.AllowUserToDeleteRows = false;
            this.tblSensitivityExamples.AllowUserToResizeColumns = false;
            this.tblSensitivityExamples.AllowUserToResizeRows = false;
            this.tblSensitivityExamples.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tblSensitivityExamples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSensitivityExamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSensitivityExamples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Frequency,
            this.Sensitivity});
            this.tblSensitivityExamples.Location = new System.Drawing.Point(9, 174);
            this.tblSensitivityExamples.MultiSelect = false;
            this.tblSensitivityExamples.Name = "tblSensitivityExamples";
            this.tblSensitivityExamples.ReadOnly = true;
            this.tblSensitivityExamples.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tblSensitivityExamples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSensitivityExamples.ShowCellErrors = false;
            this.tblSensitivityExamples.ShowEditingIcon = false;
            this.tblSensitivityExamples.ShowRowErrors = false;
            this.tblSensitivityExamples.Size = new System.Drawing.Size(275, 455);
            this.tblSensitivityExamples.TabIndex = 8;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency [kHz]";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // Sensitivity
            // 
            this.Sensitivity.HeaderText = "Sensitivity [Hz]";
            this.Sensitivity.Name = "Sensitivity";
            this.Sensitivity.ReadOnly = true;
            // 
            // lblTmr1SamplingSpeed
            // 
            this.lblTmr1SamplingSpeed.AutoSize = true;
            this.lblTmr1SamplingSpeed.Location = new System.Drawing.Point(7, 130);
            this.lblTmr1SamplingSpeed.Name = "lblTmr1SamplingSpeed";
            this.lblTmr1SamplingSpeed.Size = new System.Drawing.Size(175, 13);
            this.lblTmr1SamplingSpeed.TabIndex = 7;
            this.lblTmr1SamplingSpeed.Tag = "Sampling speed for each loop: % ms";
            this.lblTmr1SamplingSpeed.Text = "Sampling speed for each loop: ? ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sampling speed:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(728, 27);
            this.label3.TabIndex = 3;
            this.label3.Tag = "title";
            this.label3.Text = "sampling speed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSensitivitiesExampleGenerator
            // 
            this.tmrSensitivitiesExampleGenerator.Interval = 350;
            this.tmrSensitivitiesExampleGenerator.Tick += new System.EventHandler(this.tmrSensitivitiesExampleGenerator_Tick);
            // 
            // pnlSensitivity
            // 
            this.pnlSensitivity.Controls.Add(this.groupBox2);
            this.pnlSensitivity.Controls.Add(this.groupBox1);
            this.pnlSensitivity.Controls.Add(this.label6);
            this.pnlSensitivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSensitivity.Location = new System.Drawing.Point(224, 49);
            this.pnlSensitivity.Name = "pnlSensitivity";
            this.pnlSensitivity.Size = new System.Drawing.Size(728, 671);
            this.pnlSensitivity.TabIndex = 7;
            this.pnlSensitivity.Tag = "2";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cbSensitivityD);
            this.groupBox2.Controls.Add(this.cbSensitivityC);
            this.groupBox2.Controls.Add(this.cbSensitivityB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbSensitivityA);
            this.groupBox2.Location = new System.Drawing.Point(9, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channel sensitivities";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Channel D:";
            // 
            // cbSensitivityD
            // 
            this.cbSensitivityD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSensitivityD.FormattingEnabled = true;
            this.cbSensitivityD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbSensitivityD.Location = new System.Drawing.Point(96, 108);
            this.cbSensitivityD.Name = "cbSensitivityD";
            this.cbSensitivityD.Size = new System.Drawing.Size(47, 21);
            this.cbSensitivityD.TabIndex = 3;
            this.cbSensitivityD.Tag = "UPDATE_CONFIG_PACKET";
            this.cbSensitivityD.SelectedIndexChanged += new System.EventHandler(this.cbSensitivityD_SelectedIndexChanged);
            // 
            // cbSensitivityC
            // 
            this.cbSensitivityC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSensitivityC.FormattingEnabled = true;
            this.cbSensitivityC.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbSensitivityC.Location = new System.Drawing.Point(96, 81);
            this.cbSensitivityC.Name = "cbSensitivityC";
            this.cbSensitivityC.Size = new System.Drawing.Size(47, 21);
            this.cbSensitivityC.TabIndex = 2;
            this.cbSensitivityC.Tag = "UPDATE_CONFIG_PACKET";
            this.cbSensitivityC.SelectedIndexChanged += new System.EventHandler(this.cbSensitivityC_SelectedIndexChanged);
            // 
            // cbSensitivityB
            // 
            this.cbSensitivityB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSensitivityB.FormattingEnabled = true;
            this.cbSensitivityB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbSensitivityB.Location = new System.Drawing.Point(96, 54);
            this.cbSensitivityB.Name = "cbSensitivityB";
            this.cbSensitivityB.Size = new System.Drawing.Size(47, 21);
            this.cbSensitivityB.TabIndex = 1;
            this.cbSensitivityB.Tag = "UPDATE_CONFIG_PACKET";
            this.cbSensitivityB.SelectedIndexChanged += new System.EventHandler(this.cbSensitivityB_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Channel C:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Channel B:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Channel A:";
            // 
            // cbSensitivityA
            // 
            this.cbSensitivityA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSensitivityA.FormattingEnabled = true;
            this.cbSensitivityA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbSensitivityA.Location = new System.Drawing.Point(96, 26);
            this.cbSensitivityA.Name = "cbSensitivityA";
            this.cbSensitivityA.Size = new System.Drawing.Size(47, 21);
            this.cbSensitivityA.TabIndex = 0;
            this.cbSensitivityA.Tag = "UPDATE_CONFIG_PACKET";
            this.cbSensitivityA.SelectedIndexChanged += new System.EventHandler(this.cbSensitivityA_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uctbSensitivityUndetectThreshold);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.uctbSensitivityDetectThreshold);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbSensitivityForBank);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(9, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensitivity bank thresholds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Undetect threshold:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Detect threshold:";
            // 
            // cbSensitivityForBank
            // 
            this.cbSensitivityForBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSensitivityForBank.FormattingEnabled = true;
            this.cbSensitivityForBank.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbSensitivityForBank.Location = new System.Drawing.Point(96, 19);
            this.cbSensitivityForBank.Name = "cbSensitivityForBank";
            this.cbSensitivityForBank.Size = new System.Drawing.Size(47, 21);
            this.cbSensitivityForBank.TabIndex = 0;
            this.cbSensitivityForBank.Tag = "UPDATE_CONFIG_PACKET";
            this.cbSensitivityForBank.SelectedIndexChanged += new System.EventHandler(this.cbSensitivityForBank_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sensitivity bank:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(728, 27);
            this.label6.TabIndex = 4;
            this.label6.Tag = "title";
            this.label6.Text = "sensitivity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilteringLevels
            // 
            this.pnlFilteringLevels.Controls.Add(this.label17);
            this.pnlFilteringLevels.Controls.Add(this.uctbFilteringAveraging);
            this.pnlFilteringLevels.Controls.Add(this.lblFilteringPositive);
            this.pnlFilteringLevels.Controls.Add(this.uctbFilteringPositive);
            this.pnlFilteringLevels.Controls.Add(this.lblFilteringNegative);
            this.pnlFilteringLevels.Controls.Add(this.uctbFilteringNegative);
            this.pnlFilteringLevels.Controls.Add(this.cbFilteringLevel);
            this.pnlFilteringLevels.Controls.Add(this.label14);
            this.pnlFilteringLevels.Controls.Add(this.label13);
            this.pnlFilteringLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilteringLevels.Location = new System.Drawing.Point(224, 49);
            this.pnlFilteringLevels.Name = "pnlFilteringLevels";
            this.pnlFilteringLevels.Size = new System.Drawing.Size(728, 671);
            this.pnlFilteringLevels.TabIndex = 8;
            this.pnlFilteringLevels.Tag = "3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Signal averaging:";
            // 
            // lblFilteringPositive
            // 
            this.lblFilteringPositive.AutoSize = true;
            this.lblFilteringPositive.Location = new System.Drawing.Point(6, 154);
            this.lblFilteringPositive.Name = "lblFilteringPositive";
            this.lblFilteringPositive.Size = new System.Drawing.Size(117, 13);
            this.lblFilteringPositive.TabIndex = 11;
            this.lblFilteringPositive.Tag = "Positive drift timer: % ms";
            this.lblFilteringPositive.Text = "Positive drift timer: ? ms";
            // 
            // lblFilteringNegative
            // 
            this.lblFilteringNegative.AutoSize = true;
            this.lblFilteringNegative.Location = new System.Drawing.Point(6, 70);
            this.lblFilteringNegative.Name = "lblFilteringNegative";
            this.lblFilteringNegative.Size = new System.Drawing.Size(123, 13);
            this.lblFilteringNegative.TabIndex = 9;
            this.lblFilteringNegative.Tag = "Negative drift timer: % ms";
            this.lblFilteringNegative.Text = "Negative drift timer: ? ms";
            // 
            // cbFilteringLevel
            // 
            this.cbFilteringLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilteringLevel.FormattingEnabled = true;
            this.cbFilteringLevel.Items.AddRange(new object[] {
            "Normal filtering",
            "Additional signal filtering"});
            this.cbFilteringLevel.Location = new System.Drawing.Point(83, 35);
            this.cbFilteringLevel.Name = "cbFilteringLevel";
            this.cbFilteringLevel.Size = new System.Drawing.Size(173, 21);
            this.cbFilteringLevel.TabIndex = 7;
            this.cbFilteringLevel.Tag = "";
            this.cbFilteringLevel.SelectedIndexChanged += new System.EventHandler(this.cbFilteringLevel_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Filtering level:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(728, 27);
            this.label13.TabIndex = 5;
            this.label13.Tag = "title";
            this.label13.Text = "filtering";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRelayPulseDurations
            // 
            this.pnlRelayPulseDurations.Controls.Add(this.groupBox8);
            this.pnlRelayPulseDurations.Controls.Add(this.groupBox7);
            this.pnlRelayPulseDurations.Controls.Add(this.groupBox4);
            this.pnlRelayPulseDurations.Controls.Add(this.groupBox3);
            this.pnlRelayPulseDurations.Controls.Add(this.label15);
            this.pnlRelayPulseDurations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRelayPulseDurations.Location = new System.Drawing.Point(224, 49);
            this.pnlRelayPulseDurations.Name = "pnlRelayPulseDurations";
            this.pnlRelayPulseDurations.Size = new System.Drawing.Size(728, 671);
            this.pnlRelayPulseDurations.TabIndex = 9;
            this.pnlRelayPulseDurations.Tag = "4";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.lblRelayDDelayAct);
            this.groupBox8.Controls.Add(this.lblRelayDPulseNormal);
            this.groupBox8.Controls.Add(this.uctbRelayDDelayAct);
            this.groupBox8.Controls.Add(this.uctbRelayDPulseExtended);
            this.groupBox8.Controls.Add(this.uctbRelayDPulseNormal);
            this.groupBox8.Controls.Add(this.lblRelayDPulseExtended);
            this.groupBox8.Location = new System.Drawing.Point(6, 444);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(715, 131);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Output D";
            // 
            // lblRelayDDelayAct
            // 
            this.lblRelayDDelayAct.AutoSize = true;
            this.lblRelayDDelayAct.Location = new System.Drawing.Point(475, 23);
            this.lblRelayDDelayAct.Name = "lblRelayDDelayAct";
            this.lblRelayDDelayAct.Size = new System.Drawing.Size(144, 13);
            this.lblRelayDDelayAct.TabIndex = 17;
            this.lblRelayDDelayAct.Tag = "Output activation delay: % ms";
            this.lblRelayDDelayAct.Text = "Output activation delay: ? ms";
            // 
            // lblRelayDPulseNormal
            // 
            this.lblRelayDPulseNormal.AutoSize = true;
            this.lblRelayDPulseNormal.Location = new System.Drawing.Point(6, 24);
            this.lblRelayDPulseNormal.Name = "lblRelayDPulseNormal";
            this.lblRelayDPulseNormal.Size = new System.Drawing.Size(137, 13);
            this.lblRelayDPulseNormal.TabIndex = 6;
            this.lblRelayDPulseNormal.Tag = "Normal pulse duration: % ms";
            this.lblRelayDPulseNormal.Text = "Normal pulse duration: ? ms";
            // 
            // lblRelayDPulseExtended
            // 
            this.lblRelayDPulseExtended.AutoSize = true;
            this.lblRelayDPulseExtended.Location = new System.Drawing.Point(245, 26);
            this.lblRelayDPulseExtended.Name = "lblRelayDPulseExtended";
            this.lblRelayDPulseExtended.Size = new System.Drawing.Size(149, 13);
            this.lblRelayDPulseExtended.TabIndex = 8;
            this.lblRelayDPulseExtended.Tag = "Extended pulse duration: % ms";
            this.lblRelayDPulseExtended.Text = "Extended pulse duration: ? ms";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.lblRelayCDelayAct);
            this.groupBox7.Controls.Add(this.lblRelayCPulseNormal);
            this.groupBox7.Controls.Add(this.uctbRelayCDelayAct);
            this.groupBox7.Controls.Add(this.uctbRelayCPulseExtended);
            this.groupBox7.Controls.Add(this.uctbRelayCPulseNormal);
            this.groupBox7.Controls.Add(this.lblRelayCPulseExtended);
            this.groupBox7.Location = new System.Drawing.Point(6, 307);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(715, 131);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Output C";
            // 
            // lblRelayCDelayAct
            // 
            this.lblRelayCDelayAct.AutoSize = true;
            this.lblRelayCDelayAct.Location = new System.Drawing.Point(475, 23);
            this.lblRelayCDelayAct.Name = "lblRelayCDelayAct";
            this.lblRelayCDelayAct.Size = new System.Drawing.Size(144, 13);
            this.lblRelayCDelayAct.TabIndex = 15;
            this.lblRelayCDelayAct.Tag = "Output activation delay: % ms";
            this.lblRelayCDelayAct.Text = "Output activation delay: ? ms";
            // 
            // lblRelayCPulseNormal
            // 
            this.lblRelayCPulseNormal.AutoSize = true;
            this.lblRelayCPulseNormal.Location = new System.Drawing.Point(6, 24);
            this.lblRelayCPulseNormal.Name = "lblRelayCPulseNormal";
            this.lblRelayCPulseNormal.Size = new System.Drawing.Size(137, 13);
            this.lblRelayCPulseNormal.TabIndex = 6;
            this.lblRelayCPulseNormal.Tag = "Normal pulse duration: % ms";
            this.lblRelayCPulseNormal.Text = "Normal pulse duration: ? ms";
            // 
            // lblRelayCPulseExtended
            // 
            this.lblRelayCPulseExtended.AutoSize = true;
            this.lblRelayCPulseExtended.Location = new System.Drawing.Point(245, 26);
            this.lblRelayCPulseExtended.Name = "lblRelayCPulseExtended";
            this.lblRelayCPulseExtended.Size = new System.Drawing.Size(149, 13);
            this.lblRelayCPulseExtended.TabIndex = 8;
            this.lblRelayCPulseExtended.Tag = "Extended pulse duration: % ms";
            this.lblRelayCPulseExtended.Text = "Extended pulse duration: ? ms";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblRelayBDelayAct);
            this.groupBox4.Controls.Add(this.uctbRelayBDelayAct);
            this.groupBox4.Controls.Add(this.lblRelayBPulseNormal);
            this.groupBox4.Controls.Add(this.uctbRelayBPulseExtended);
            this.groupBox4.Controls.Add(this.uctbRelayBPulseNormal);
            this.groupBox4.Controls.Add(this.lblRelayBPulseExtended);
            this.groupBox4.Location = new System.Drawing.Point(6, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(715, 131);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output B";
            // 
            // lblRelayBDelayAct
            // 
            this.lblRelayBDelayAct.AutoSize = true;
            this.lblRelayBDelayAct.Location = new System.Drawing.Point(475, 21);
            this.lblRelayBDelayAct.Name = "lblRelayBDelayAct";
            this.lblRelayBDelayAct.Size = new System.Drawing.Size(144, 13);
            this.lblRelayBDelayAct.TabIndex = 13;
            this.lblRelayBDelayAct.Tag = "Output activation delay: % ms";
            this.lblRelayBDelayAct.Text = "Output activation delay: ? ms";
            // 
            // lblRelayBPulseNormal
            // 
            this.lblRelayBPulseNormal.AutoSize = true;
            this.lblRelayBPulseNormal.Location = new System.Drawing.Point(6, 24);
            this.lblRelayBPulseNormal.Name = "lblRelayBPulseNormal";
            this.lblRelayBPulseNormal.Size = new System.Drawing.Size(137, 13);
            this.lblRelayBPulseNormal.TabIndex = 6;
            this.lblRelayBPulseNormal.Tag = "Normal pulse duration: % ms";
            this.lblRelayBPulseNormal.Text = "Normal pulse duration: ? ms";
            // 
            // lblRelayBPulseExtended
            // 
            this.lblRelayBPulseExtended.AutoSize = true;
            this.lblRelayBPulseExtended.Location = new System.Drawing.Point(245, 24);
            this.lblRelayBPulseExtended.Name = "lblRelayBPulseExtended";
            this.lblRelayBPulseExtended.Size = new System.Drawing.Size(149, 13);
            this.lblRelayBPulseExtended.TabIndex = 8;
            this.lblRelayBPulseExtended.Tag = "Extended pulse duration: % ms";
            this.lblRelayBPulseExtended.Text = "Extended pulse duration: ? ms";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblRelayADelayAct);
            this.groupBox3.Controls.Add(this.uctbRelayADelayAct);
            this.groupBox3.Controls.Add(this.lblRelayAPulseNormal);
            this.groupBox3.Controls.Add(this.uctbRelayAPulseExtended);
            this.groupBox3.Controls.Add(this.uctbRelayAPulseNormal);
            this.groupBox3.Controls.Add(this.lblRelayAPulseExtended);
            this.groupBox3.Location = new System.Drawing.Point(6, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 131);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output A";
            // 
            // lblRelayADelayAct
            // 
            this.lblRelayADelayAct.AutoSize = true;
            this.lblRelayADelayAct.Location = new System.Drawing.Point(475, 25);
            this.lblRelayADelayAct.Name = "lblRelayADelayAct";
            this.lblRelayADelayAct.Size = new System.Drawing.Size(144, 13);
            this.lblRelayADelayAct.TabIndex = 11;
            this.lblRelayADelayAct.Tag = "Output activation delay: % ms";
            this.lblRelayADelayAct.Text = "Output activation delay: ? ms";
            // 
            // lblRelayAPulseNormal
            // 
            this.lblRelayAPulseNormal.AutoSize = true;
            this.lblRelayAPulseNormal.Location = new System.Drawing.Point(6, 24);
            this.lblRelayAPulseNormal.Name = "lblRelayAPulseNormal";
            this.lblRelayAPulseNormal.Size = new System.Drawing.Size(137, 13);
            this.lblRelayAPulseNormal.TabIndex = 6;
            this.lblRelayAPulseNormal.Tag = "Normal pulse duration: % ms";
            this.lblRelayAPulseNormal.Text = "Normal pulse duration: ? ms";
            // 
            // lblRelayAPulseExtended
            // 
            this.lblRelayAPulseExtended.AutoSize = true;
            this.lblRelayAPulseExtended.Location = new System.Drawing.Point(245, 26);
            this.lblRelayAPulseExtended.Name = "lblRelayAPulseExtended";
            this.lblRelayAPulseExtended.Size = new System.Drawing.Size(149, 13);
            this.lblRelayAPulseExtended.TabIndex = 8;
            this.lblRelayAPulseExtended.Tag = "Extended pulse duration: % ms";
            this.lblRelayAPulseExtended.Text = "Extended pulse duration: ? ms";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(728, 27);
            this.label15.TabIndex = 5;
            this.label15.Tag = "title";
            this.label15.Text = "relay pulse durations";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPPC
            // 
            this.pnlPPC.Controls.Add(this.groupBox5);
            this.pnlPPC.Controls.Add(this.uctbPPCLong);
            this.pnlPPC.Controls.Add(this.lblPPCLong);
            this.pnlPPC.Controls.Add(this.uctbPPCMedium);
            this.pnlPPC.Controls.Add(this.lblPPCMedium);
            this.pnlPPC.Controls.Add(this.uctbPPCShort);
            this.pnlPPC.Controls.Add(this.lblPPCShort);
            this.pnlPPC.Controls.Add(this.label18);
            this.pnlPPC.Location = new System.Drawing.Point(588, 200);
            this.pnlPPC.Name = "pnlPPC";
            this.pnlPPC.Size = new System.Drawing.Size(176, 138);
            this.pnlPPC.TabIndex = 10;
            this.pnlPPC.Tag = "5";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.uctbPPCDetLeftThreshold);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.uctbPPCDetLeftTimer);
            this.groupBox5.Controls.Add(this.lblPPCDetLeaveTimer);
            this.groupBox5.Location = new System.Drawing.Point(6, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 204);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detect-leave algorithm parameters";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 13);
            this.label21.TabIndex = 15;
            this.label21.Tag = "Detect leave threshold:";
            this.label21.Text = "Detect leave threshold:";
            // 
            // lblPPCDetLeaveTimer
            // 
            this.lblPPCDetLeaveTimer.AutoSize = true;
            this.lblPPCDetLeaveTimer.Location = new System.Drawing.Point(8, 20);
            this.lblPPCDetLeaveTimer.Name = "lblPPCDetLeaveTimer";
            this.lblPPCDetLeaveTimer.Size = new System.Drawing.Size(121, 13);
            this.lblPPCDetLeaveTimer.TabIndex = 13;
            this.lblPPCDetLeaveTimer.Tag = "Detect leave timer: % ms";
            this.lblPPCDetLeaveTimer.Text = "Detect leave timer: ? ms";
            // 
            // lblPPCLong
            // 
            this.lblPPCLong.AutoSize = true;
            this.lblPPCLong.Location = new System.Drawing.Point(9, 220);
            this.lblPPCLong.Name = "lblPPCLong";
            this.lblPPCLong.Size = new System.Drawing.Size(240, 13);
            this.lblPPCLong.TabIndex = 15;
            this.lblPPCLong.Tag = "Permanent presence cancellation long: % (hh:mm)";
            this.lblPPCLong.Text = "Permanent presence cancellation long: ? (hh:mm)";
            // 
            // lblPPCMedium
            // 
            this.lblPPCMedium.AutoSize = true;
            this.lblPPCMedium.Location = new System.Drawing.Point(9, 129);
            this.lblPPCMedium.Name = "lblPPCMedium";
            this.lblPPCMedium.Size = new System.Drawing.Size(256, 13);
            this.lblPPCMedium.TabIndex = 13;
            this.lblPPCMedium.Tag = "Permanent presence cancellation medium: % (hh:mm)";
            this.lblPPCMedium.Text = "Permanent presence cancellation medium: ? (hh:mm)";
            // 
            // lblPPCShort
            // 
            this.lblPPCShort.AutoSize = true;
            this.lblPPCShort.Location = new System.Drawing.Point(9, 38);
            this.lblPPCShort.Name = "lblPPCShort";
            this.lblPPCShort.Size = new System.Drawing.Size(243, 13);
            this.lblPPCShort.TabIndex = 7;
            this.lblPPCShort.Tag = "Permanent presence cancellation short: % (hh:mm)";
            this.lblPPCShort.Text = "Permanent presence cancellation short: ? (hh:mm)";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 27);
            this.label18.TabIndex = 6;
            this.label18.Tag = "title";
            this.label18.Text = "ppc";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDetectStop
            // 
            this.pnlDetectStop.Controls.Add(this.lblDetectStopSlowCheckTimer);
            this.pnlDetectStop.Controls.Add(this.uctbDetStopSlowCheckerTimer);
            this.pnlDetectStop.Controls.Add(this.label22);
            this.pnlDetectStop.Controls.Add(this.lblDetectStopTimer);
            this.pnlDetectStop.Controls.Add(this.uctbDetStopThreshold);
            this.pnlDetectStop.Controls.Add(this.uctbDetStopTimer);
            this.pnlDetectStop.Controls.Add(this.label19);
            this.pnlDetectStop.Location = new System.Drawing.Point(233, 356);
            this.pnlDetectStop.Name = "pnlDetectStop";
            this.pnlDetectStop.Size = new System.Drawing.Size(168, 148);
            this.pnlDetectStop.TabIndex = 11;
            this.pnlDetectStop.Tag = "6";
            // 
            // lblDetectStopSlowCheckTimer
            // 
            this.lblDetectStopSlowCheckTimer.AutoSize = true;
            this.lblDetectStopSlowCheckTimer.Location = new System.Drawing.Point(6, 216);
            this.lblDetectStopSlowCheckTimer.Name = "lblDetectStopSlowCheckTimer";
            this.lblDetectStopSlowCheckTimer.Size = new System.Drawing.Size(116, 13);
            this.lblDetectStopSlowCheckTimer.TabIndex = 13;
            this.lblDetectStopSlowCheckTimer.Tag = "Slow check timer: % ms";
            this.lblDetectStopSlowCheckTimer.Text = "Slow check timer: ? ms";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Detect stop threshold:";
            // 
            // lblDetectStopTimer
            // 
            this.lblDetectStopTimer.AutoSize = true;
            this.lblDetectStopTimer.Location = new System.Drawing.Point(3, 34);
            this.lblDetectStopTimer.Name = "lblDetectStopTimer";
            this.lblDetectStopTimer.Size = new System.Drawing.Size(115, 13);
            this.lblDetectStopTimer.TabIndex = 10;
            this.lblDetectStopTimer.Tag = "Detect stop timer: % ms";
            this.lblDetectStopTimer.Text = "Detect stop timer: ? ms";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 27);
            this.label19.TabIndex = 7;
            this.label19.Tag = "title";
            this.label19.Text = "detect stop";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDCDD
            // 
            this.pnlDCDD.Controls.Add(this.uctbDCDDThreshold);
            this.pnlDCDD.Controls.Add(this.label25);
            this.pnlDCDD.Controls.Add(this.uctbDCDDTimer);
            this.pnlDCDD.Controls.Add(this.lblDCDDTimer);
            this.pnlDCDD.Controls.Add(this.label23);
            this.pnlDCDD.Controls.Add(this.label20);
            this.pnlDCDD.Location = new System.Drawing.Point(407, 357);
            this.pnlDCDD.Name = "pnlDCDD";
            this.pnlDCDD.Size = new System.Drawing.Size(157, 147);
            this.pnlDCDD.TabIndex = 12;
            this.pnlDCDD.Tag = "7";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 129);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(169, 13);
            this.label25.TabIndex = 12;
            this.label25.Text = "No movement detection threshold:";
            // 
            // lblDCDDTimer
            // 
            this.lblDCDDTimer.AutoSize = true;
            this.lblDCDDTimer.Location = new System.Drawing.Point(6, 38);
            this.lblDCDDTimer.Name = "lblDCDDTimer";
            this.lblDCDDTimer.Size = new System.Drawing.Size(157, 13);
            this.lblDCDDTimer.TabIndex = 10;
            this.lblDCDDTimer.Tag = "No movement detection timer: %";
            this.lblDCDDTimer.Text = "No movement detection timer: ?";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 13);
            this.label23.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 27);
            this.label20.TabIndex = 8;
            this.label20.Tag = "title";
            this.label20.Text = "DCDD";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSpeedTrap
            // 
            this.pnlSpeedTrap.Controls.Add(this.label31);
            this.pnlSpeedTrap.Controls.Add(this.tblMaximumSpeedErrors);
            this.pnlSpeedTrap.Controls.Add(this.uctbSpeedDistance);
            this.pnlSpeedTrap.Controls.Add(this.lblSpeedLoopDistance);
            this.pnlSpeedTrap.Controls.Add(this.label24);
            this.pnlSpeedTrap.Location = new System.Drawing.Point(224, 49);
            this.pnlSpeedTrap.Name = "pnlSpeedTrap";
            this.pnlSpeedTrap.Size = new System.Drawing.Size(728, 639);
            this.pnlSpeedTrap.TabIndex = 13;
            this.pnlSpeedTrap.Tag = "8";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 130);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(205, 13);
            this.label31.TabIndex = 14;
            this.label31.Text = "Maximum possible error at various speeds:";
            // 
            // tblMaximumSpeedErrors
            // 
            this.tblMaximumSpeedErrors.AllowUserToAddRows = false;
            this.tblMaximumSpeedErrors.AllowUserToDeleteRows = false;
            this.tblMaximumSpeedErrors.AllowUserToResizeColumns = false;
            this.tblMaximumSpeedErrors.AllowUserToResizeRows = false;
            this.tblMaximumSpeedErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMaximumSpeedErrors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblMaximumSpeedErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMaximumSpeedErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Speed,
            this.WorstPossibleMeasurement,
            this.MaximumErrorKMH,
            this.MaximumErrorPercent});
            this.tblMaximumSpeedErrors.Location = new System.Drawing.Point(9, 151);
            this.tblMaximumSpeedErrors.MultiSelect = false;
            this.tblMaximumSpeedErrors.Name = "tblMaximumSpeedErrors";
            this.tblMaximumSpeedErrors.ReadOnly = true;
            this.tblMaximumSpeedErrors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tblMaximumSpeedErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblMaximumSpeedErrors.ShowCellErrors = false;
            this.tblMaximumSpeedErrors.ShowEditingIcon = false;
            this.tblMaximumSpeedErrors.ShowRowErrors = false;
            this.tblMaximumSpeedErrors.Size = new System.Drawing.Size(712, 478);
            this.tblMaximumSpeedErrors.TabIndex = 13;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed [km/h]";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // WorstPossibleMeasurement
            // 
            this.WorstPossibleMeasurement.HeaderText = "Worst possible measurement [km/h]";
            this.WorstPossibleMeasurement.Name = "WorstPossibleMeasurement";
            this.WorstPossibleMeasurement.ReadOnly = true;
            // 
            // MaximumErrorKMH
            // 
            this.MaximumErrorKMH.HeaderText = "Maximum Error [km/h]";
            this.MaximumErrorKMH.Name = "MaximumErrorKMH";
            this.MaximumErrorKMH.ReadOnly = true;
            // 
            // MaximumErrorPercent
            // 
            this.MaximumErrorPercent.HeaderText = "Maximum error [%]";
            this.MaximumErrorPercent.Name = "MaximumErrorPercent";
            this.MaximumErrorPercent.ReadOnly = true;
            // 
            // lblSpeedLoopDistance
            // 
            this.lblSpeedLoopDistance.AutoSize = true;
            this.lblSpeedLoopDistance.Location = new System.Drawing.Point(7, 40);
            this.lblSpeedLoopDistance.Name = "lblSpeedLoopDistance";
            this.lblSpeedLoopDistance.Size = new System.Drawing.Size(133, 13);
            this.lblSpeedLoopDistance.TabIndex = 10;
            this.lblSpeedLoopDistance.Tag = "Distance between loops: %";
            this.lblSpeedLoopDistance.Text = "Distance between loops: ?";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(728, 27);
            this.label24.TabIndex = 9;
            this.label24.Tag = "title";
            this.label24.Text = "speed trap";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrUpdateConfigPacket
            // 
            this.tmrUpdateConfigPacket.Interval = 350;
            this.tmrUpdateConfigPacket.Tick += new System.EventHandler(this.tmrUpdateConfigPacket_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.FileName = "profile.xml";
            this.openFileDialog.Filter = "DLD Profiles|*.xml";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.FileName = "profile.xml";
            this.saveFileDialog.Filter = "DLD Profiles|*.xml";
            // 
            // pnlEventViewer
            // 
            this.pnlEventViewer.Controls.Add(this.lblLastJointEventCD);
            this.pnlEventViewer.Controls.Add(this.lblLastEventLoopD);
            this.pnlEventViewer.Controls.Add(this.lblLastEventLoopC);
            this.pnlEventViewer.Controls.Add(this.btnSaveLog);
            this.pnlEventViewer.Controls.Add(this.btnClearLog);
            this.pnlEventViewer.Controls.Add(this.label29);
            this.pnlEventViewer.Controls.Add(this.txtLog);
            this.pnlEventViewer.Controls.Add(this.lblLastJointEventAB);
            this.pnlEventViewer.Controls.Add(this.lblLastEventLoopB);
            this.pnlEventViewer.Controls.Add(this.lblLastEventLoopA);
            this.pnlEventViewer.Controls.Add(this.lblLoggingState);
            this.pnlEventViewer.Controls.Add(this.button1);
            this.pnlEventViewer.Controls.Add(this.label28);
            this.pnlEventViewer.Location = new System.Drawing.Point(224, 49);
            this.pnlEventViewer.Name = "pnlEventViewer";
            this.pnlEventViewer.Size = new System.Drawing.Size(728, 639);
            this.pnlEventViewer.TabIndex = 14;
            this.pnlEventViewer.Tag = "9";
            // 
            // lblLastJointEventCD
            // 
            this.lblLastJointEventCD.AutoSize = true;
            this.lblLastJointEventCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastJointEventCD.Location = new System.Drawing.Point(9, 183);
            this.lblLastJointEventCD.Name = "lblLastJointEventCD";
            this.lblLastJointEventCD.Size = new System.Drawing.Size(190, 16);
            this.lblLastJointEventCD.TabIndex = 20;
            this.lblLastJointEventCD.Tag = "Last C+D joint event: %";
            this.lblLastJointEventCD.Text = "Last C+D joint event: None";
            // 
            // lblLastEventLoopD
            // 
            this.lblLastEventLoopD.AutoSize = true;
            this.lblLastEventLoopD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEventLoopD.Location = new System.Drawing.Point(9, 159);
            this.lblLastEventLoopD.Name = "lblLastEventLoopD";
            this.lblLastEventLoopD.Size = new System.Drawing.Size(174, 16);
            this.lblLastEventLoopD.TabIndex = 19;
            this.lblLastEventLoopD.Tag = "Last event loop D: %";
            this.lblLastEventLoopD.Text = "Last event loop D: None";
            // 
            // lblLastEventLoopC
            // 
            this.lblLastEventLoopC.AutoSize = true;
            this.lblLastEventLoopC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEventLoopC.Location = new System.Drawing.Point(9, 135);
            this.lblLastEventLoopC.Name = "lblLastEventLoopC";
            this.lblLastEventLoopC.Size = new System.Drawing.Size(173, 16);
            this.lblLastEventLoopC.TabIndex = 18;
            this.lblLastEventLoopC.Tag = "Last event loop C: %";
            this.lblLastEventLoopC.Text = "Last event loop C: None";
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLog.Location = new System.Drawing.Point(539, 603);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(85, 23);
            this.btnSaveLog.TabIndex = 17;
            this.btnSaveLog.Text = "Save log";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(630, 603);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(85, 23);
            this.btnClearLog.TabIndex = 16;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 217);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 13);
            this.label29.TabIndex = 15;
            this.label29.Text = "Event logger:";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(9, 233);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(707, 363);
            this.txtLog.TabIndex = 14;
            this.txtLog.WordWrap = false;
            // 
            // lblLastJointEventAB
            // 
            this.lblLastJointEventAB.AutoSize = true;
            this.lblLastJointEventAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastJointEventAB.Location = new System.Drawing.Point(9, 112);
            this.lblLastJointEventAB.Name = "lblLastJointEventAB";
            this.lblLastJointEventAB.Size = new System.Drawing.Size(189, 16);
            this.lblLastJointEventAB.TabIndex = 13;
            this.lblLastJointEventAB.Tag = "Last A+B joint event: %";
            this.lblLastJointEventAB.Text = "Last A+B joint event: None";
            // 
            // lblLastEventLoopB
            // 
            this.lblLastEventLoopB.AutoSize = true;
            this.lblLastEventLoopB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEventLoopB.Location = new System.Drawing.Point(9, 88);
            this.lblLastEventLoopB.Name = "lblLastEventLoopB";
            this.lblLastEventLoopB.Size = new System.Drawing.Size(173, 16);
            this.lblLastEventLoopB.TabIndex = 12;
            this.lblLastEventLoopB.Tag = "Last event loop B: %";
            this.lblLastEventLoopB.Text = "Last event loop B: None";
            // 
            // lblLastEventLoopA
            // 
            this.lblLastEventLoopA.AutoSize = true;
            this.lblLastEventLoopA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEventLoopA.Location = new System.Drawing.Point(9, 64);
            this.lblLastEventLoopA.Name = "lblLastEventLoopA";
            this.lblLastEventLoopA.Size = new System.Drawing.Size(173, 16);
            this.lblLastEventLoopA.TabIndex = 11;
            this.lblLastEventLoopA.Tag = "Last event loop A: %";
            this.lblLastEventLoopA.Text = "Last event loop A: None";
            // 
            // lblLoggingState
            // 
            this.lblLoggingState.AutoSize = true;
            this.lblLoggingState.Location = new System.Drawing.Point(143, 37);
            this.lblLoggingState.Name = "lblLoggingState";
            this.lblLoggingState.Size = new System.Drawing.Size(118, 13);
            this.lblLoggingState.TabIndex = 10;
            this.lblLoggingState.Tag = "Logging is currently: %";
            this.lblLoggingState.Text = "Logging is currently: Off";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Event logging on/off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label28.Dock = System.Windows.Forms.DockStyle.Top;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(728, 27);
            this.label28.TabIndex = 8;
            this.label28.Tag = "title";
            this.label28.Text = "event viewer";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSignalAnalysis
            // 
            this.pnlSignalAnalysis.Controls.Add(this.tableLayoutPanel1);
            this.pnlSignalAnalysis.Controls.Add(this.lblSignalAnalysis);
            this.pnlSignalAnalysis.Controls.Add(this.btnSignalAnalysis);
            this.pnlSignalAnalysis.Controls.Add(this.label30);
            this.pnlSignalAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSignalAnalysis.Location = new System.Drawing.Point(224, 49);
            this.pnlSignalAnalysis.Name = "pnlSignalAnalysis";
            this.pnlSignalAnalysis.Size = new System.Drawing.Size(728, 671);
            this.pnlSignalAnalysis.TabIndex = 15;
            this.pnlSignalAnalysis.Tag = "10";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chAnalysisLoopA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chAnalysisLoopB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chAnalysisLoopC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chAnalysisLoopD, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 607);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // chAnalysisLoopA
            // 
            chartArea2.Name = "ChartArea1";
            this.chAnalysisLoopA.ChartAreas.Add(chartArea2);
            this.chAnalysisLoopA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chAnalysisLoopA.Legends.Add(legend2);
            this.chAnalysisLoopA.Location = new System.Drawing.Point(3, 3);
            this.chAnalysisLoopA.Name = "chAnalysisLoopA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chAnalysisLoopA.Series.Add(series1);
            this.chAnalysisLoopA.Size = new System.Drawing.Size(346, 247);
            this.chAnalysisLoopA.TabIndex = 13;
            this.chAnalysisLoopA.Text = "LOOP A";
            this.chAnalysisLoopA.DoubleClick += new System.EventHandler(this.chAnalysisLoopA_DoubleClick);
            // 
            // chAnalysisLoopB
            // 
            chartArea3.Name = "ChartArea1";
            this.chAnalysisLoopB.ChartAreas.Add(chartArea3);
            this.chAnalysisLoopB.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chAnalysisLoopB.Legends.Add(legend3);
            this.chAnalysisLoopB.Location = new System.Drawing.Point(365, 3);
            this.chAnalysisLoopB.Name = "chAnalysisLoopB";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chAnalysisLoopB.Series.Add(series2);
            this.chAnalysisLoopB.Size = new System.Drawing.Size(346, 247);
            this.chAnalysisLoopB.TabIndex = 14;
            this.chAnalysisLoopB.Text = "LOOP B";
            this.chAnalysisLoopB.Click += new System.EventHandler(this.chAnalysisLoopB_Click);
            // 
            // chAnalysisLoopC
            // 
            chartArea4.Name = "ChartArea1";
            this.chAnalysisLoopC.ChartAreas.Add(chartArea4);
            this.chAnalysisLoopC.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chAnalysisLoopC.Legends.Add(legend4);
            this.chAnalysisLoopC.Location = new System.Drawing.Point(3, 306);
            this.chAnalysisLoopC.Name = "chAnalysisLoopC";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chAnalysisLoopC.Series.Add(series3);
            this.chAnalysisLoopC.Size = new System.Drawing.Size(346, 247);
            this.chAnalysisLoopC.TabIndex = 19;
            this.chAnalysisLoopC.Text = "LOOP B";
            // 
            // chAnalysisLoopD
            // 
            chartArea5.Name = "ChartArea1";
            this.chAnalysisLoopD.ChartAreas.Add(chartArea5);
            this.chAnalysisLoopD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chAnalysisLoopD.Legends.Add(legend5);
            this.chAnalysisLoopD.Location = new System.Drawing.Point(365, 306);
            this.chAnalysisLoopD.Name = "chAnalysisLoopD";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chAnalysisLoopD.Series.Add(series4);
            this.chAnalysisLoopD.Size = new System.Drawing.Size(346, 247);
            this.chAnalysisLoopD.TabIndex = 22;
            this.chAnalysisLoopD.Text = "LOOP B";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckAutoSaveAnalysisLoopA);
            this.panel1.Controls.Add(this.btnSaveAnalysisLoopA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 44);
            this.panel1.TabIndex = 23;
            // 
            // ckAutoSaveAnalysisLoopA
            // 
            this.ckAutoSaveAnalysisLoopA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckAutoSaveAnalysisLoopA.AutoSize = true;
            this.ckAutoSaveAnalysisLoopA.Location = new System.Drawing.Point(185, 9);
            this.ckAutoSaveAnalysisLoopA.Name = "ckAutoSaveAnalysisLoopA";
            this.ckAutoSaveAnalysisLoopA.Size = new System.Drawing.Size(74, 17);
            this.ckAutoSaveAnalysisLoopA.TabIndex = 17;
            this.ckAutoSaveAnalysisLoopA.Text = "Auto save";
            this.ckAutoSaveAnalysisLoopA.UseVisualStyleBackColor = true;
            // 
            // btnSaveAnalysisLoopA
            // 
            this.btnSaveAnalysisLoopA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAnalysisLoopA.Location = new System.Drawing.Point(265, 5);
            this.btnSaveAnalysisLoopA.Name = "btnSaveAnalysisLoopA";
            this.btnSaveAnalysisLoopA.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAnalysisLoopA.TabIndex = 15;
            this.btnSaveAnalysisLoopA.Text = "Save";
            this.btnSaveAnalysisLoopA.UseVisualStyleBackColor = true;
            this.btnSaveAnalysisLoopA.Click += new System.EventHandler(this.btnSaveAnalysisLoopA_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveAnalysisLoopB);
            this.panel2.Controls.Add(this.ckAutoSaveAnalysisLoopB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(365, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 44);
            this.panel2.TabIndex = 24;
            // 
            // btnSaveAnalysisLoopB
            // 
            this.btnSaveAnalysisLoopB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAnalysisLoopB.Location = new System.Drawing.Point(265, 5);
            this.btnSaveAnalysisLoopB.Name = "btnSaveAnalysisLoopB";
            this.btnSaveAnalysisLoopB.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAnalysisLoopB.TabIndex = 16;
            this.btnSaveAnalysisLoopB.Text = "Save";
            this.btnSaveAnalysisLoopB.UseVisualStyleBackColor = true;
            this.btnSaveAnalysisLoopB.Click += new System.EventHandler(this.btnSaveAnalysisLoopB_Click);
            // 
            // ckAutoSaveAnalysisLoopB
            // 
            this.ckAutoSaveAnalysisLoopB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckAutoSaveAnalysisLoopB.AutoSize = true;
            this.ckAutoSaveAnalysisLoopB.Location = new System.Drawing.Point(185, 9);
            this.ckAutoSaveAnalysisLoopB.Name = "ckAutoSaveAnalysisLoopB";
            this.ckAutoSaveAnalysisLoopB.Size = new System.Drawing.Size(74, 17);
            this.ckAutoSaveAnalysisLoopB.TabIndex = 18;
            this.ckAutoSaveAnalysisLoopB.Text = "Auto save";
            this.ckAutoSaveAnalysisLoopB.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveAnalysisLoopC);
            this.panel3.Controls.Add(this.ckAutoSaveAnalysisLoopC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 45);
            this.panel3.TabIndex = 25;
            // 
            // btnSaveAnalysisLoopC
            // 
            this.btnSaveAnalysisLoopC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAnalysisLoopC.Location = new System.Drawing.Point(265, 5);
            this.btnSaveAnalysisLoopC.Name = "btnSaveAnalysisLoopC";
            this.btnSaveAnalysisLoopC.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAnalysisLoopC.TabIndex = 20;
            this.btnSaveAnalysisLoopC.Text = "Save";
            this.btnSaveAnalysisLoopC.UseVisualStyleBackColor = true;
            this.btnSaveAnalysisLoopC.Click += new System.EventHandler(this.btnSaveAnalysisLoopC_Click);
            // 
            // ckAutoSaveAnalysisLoopC
            // 
            this.ckAutoSaveAnalysisLoopC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckAutoSaveAnalysisLoopC.AutoSize = true;
            this.ckAutoSaveAnalysisLoopC.Location = new System.Drawing.Point(185, 9);
            this.ckAutoSaveAnalysisLoopC.Name = "ckAutoSaveAnalysisLoopC";
            this.ckAutoSaveAnalysisLoopC.Size = new System.Drawing.Size(74, 17);
            this.ckAutoSaveAnalysisLoopC.TabIndex = 21;
            this.ckAutoSaveAnalysisLoopC.Text = "Auto save";
            this.ckAutoSaveAnalysisLoopC.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveAnalysisLoopD);
            this.panel4.Controls.Add(this.ckAutoSaveAnalysisLoopD);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(365, 559);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 45);
            this.panel4.TabIndex = 26;
            // 
            // btnSaveAnalysisLoopD
            // 
            this.btnSaveAnalysisLoopD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAnalysisLoopD.Location = new System.Drawing.Point(265, 5);
            this.btnSaveAnalysisLoopD.Name = "btnSaveAnalysisLoopD";
            this.btnSaveAnalysisLoopD.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAnalysisLoopD.TabIndex = 23;
            this.btnSaveAnalysisLoopD.Text = "Save";
            this.btnSaveAnalysisLoopD.UseVisualStyleBackColor = true;
            this.btnSaveAnalysisLoopD.Click += new System.EventHandler(this.btnSaveAnalysisLoopD_Click);
            // 
            // ckAutoSaveAnalysisLoopD
            // 
            this.ckAutoSaveAnalysisLoopD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckAutoSaveAnalysisLoopD.AutoSize = true;
            this.ckAutoSaveAnalysisLoopD.Location = new System.Drawing.Point(185, 9);
            this.ckAutoSaveAnalysisLoopD.Name = "ckAutoSaveAnalysisLoopD";
            this.ckAutoSaveAnalysisLoopD.Size = new System.Drawing.Size(74, 17);
            this.ckAutoSaveAnalysisLoopD.TabIndex = 24;
            this.ckAutoSaveAnalysisLoopD.Text = "Auto save";
            this.ckAutoSaveAnalysisLoopD.UseVisualStyleBackColor = true;
            // 
            // lblSignalAnalysis
            // 
            this.lblSignalAnalysis.AutoSize = true;
            this.lblSignalAnalysis.Location = new System.Drawing.Point(143, 37);
            this.lblSignalAnalysis.Name = "lblSignalAnalysis";
            this.lblSignalAnalysis.Size = new System.Drawing.Size(149, 13);
            this.lblSignalAnalysis.TabIndex = 12;
            this.lblSignalAnalysis.Tag = "Signal analysis is currently: %";
            this.lblSignalAnalysis.Text = "Signal analysis is currently: Off";
            // 
            // btnSignalAnalysis
            // 
            this.btnSignalAnalysis.Location = new System.Drawing.Point(6, 32);
            this.btnSignalAnalysis.Name = "btnSignalAnalysis";
            this.btnSignalAnalysis.Size = new System.Drawing.Size(129, 23);
            this.btnSignalAnalysis.TabIndex = 11;
            this.btnSignalAnalysis.Text = "Signal analysis on/off";
            this.btnSignalAnalysis.UseVisualStyleBackColor = true;
            this.btnSignalAnalysis.Click += new System.EventHandler(this.btnSignalAnalysis_Click);
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label30.Dock = System.Windows.Forms.DockStyle.Top;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label30.Location = new System.Drawing.Point(0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(728, 27);
            this.label30.TabIndex = 10;
            this.label30.Tag = "title";
            this.label30.Text = "signal analysis";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveAnalysisDialog
            // 
            this.saveAnalysisDialog.DefaultExt = "txt";
            this.saveAnalysisDialog.Filter = "Text File|*.txt";
            // 
            // saveChartImageDialog
            // 
            this.saveChartImageDialog.DefaultExt = "jpg";
            this.saveChartImageDialog.Filter = "Images|*.jpg";
            // 
            // saveLogDialog
            // 
            this.saveLogDialog.DefaultExt = "txt";
            this.saveLogDialog.Filter = "Log file|*.txt";
            // 
            // tmrSpeedTrapErrorGenerator
            // 
            this.tmrSpeedTrapErrorGenerator.Interval = 350;
            this.tmrSpeedTrapErrorGenerator.Tick += new System.EventHandler(this.tmrSpeedTrapErrorGenerator_Tick);
            // 
            // pnlMiscOptions
            // 
            this.pnlMiscOptions.Controls.Add(this.groupBox10);
            this.pnlMiscOptions.Controls.Add(this.groupBox9);
            this.pnlMiscOptions.Controls.Add(this.label35);
            this.pnlMiscOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiscOptions.Location = new System.Drawing.Point(224, 49);
            this.pnlMiscOptions.Name = "pnlMiscOptions";
            this.pnlMiscOptions.Size = new System.Drawing.Size(728, 671);
            this.pnlMiscOptions.TabIndex = 10;
            this.pnlMiscOptions.Tag = "8";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.lblRuntimeRecalibTmr);
            this.groupBox10.Controls.Add(this.uctbRuntimeRecalibTmr);
            this.groupBox10.Location = new System.Drawing.Point(6, 173);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(712, 129);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Runtime Re-Calibration delayer";
            // 
            // lblRuntimeRecalibTmr
            // 
            this.lblRuntimeRecalibTmr.AutoSize = true;
            this.lblRuntimeRecalibTmr.Location = new System.Drawing.Point(9, 28);
            this.lblRuntimeRecalibTmr.Name = "lblRuntimeRecalibTmr";
            this.lblRuntimeRecalibTmr.Size = new System.Drawing.Size(143, 13);
            this.lblRuntimeRecalibTmr.TabIndex = 10;
            this.lblRuntimeRecalibTmr.Tag = "Runtime recalibration timer: %";
            this.lblRuntimeRecalibTmr.Text = "Runtime recalibration timer: ?";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.lblSlowStartupTmr);
            this.groupBox9.Controls.Add(this.uctbSlowStartupTimer);
            this.groupBox9.Location = new System.Drawing.Point(6, 35);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(712, 129);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Slow startup (warm up)";
            // 
            // lblSlowStartupTmr
            // 
            this.lblSlowStartupTmr.AutoSize = true;
            this.lblSlowStartupTmr.Location = new System.Drawing.Point(10, 25);
            this.lblSlowStartupTmr.Name = "lblSlowStartupTmr";
            this.lblSlowStartupTmr.Size = new System.Drawing.Size(134, 13);
            this.lblSlowStartupTmr.TabIndex = 8;
            this.lblSlowStartupTmr.Tag = "Sensitivity increase timer: %";
            this.lblSlowStartupTmr.Text = "Sensitivity increase timer: ?";
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label35.Dock = System.Windows.Forms.DockStyle.Top;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label35.Location = new System.Drawing.Point(0, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(728, 27);
            this.label35.TabIndex = 3;
            this.label35.Tag = "title";
            this.label35.Text = "misc options";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uctbRelayDDelayAct
            // 
            this.uctbRelayDDelayAct.LargeChange = 5;
            this.uctbRelayDDelayAct.Location = new System.Drawing.Point(478, 43);
            this.uctbRelayDDelayAct.Maximum = 255;
            this.uctbRelayDDelayAct.Minimum = 1;
            this.uctbRelayDDelayAct.Name = "uctbRelayDDelayAct";
            this.uctbRelayDDelayAct.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayDDelayAct.SmallChange = 1;
            this.uctbRelayDDelayAct.TabIndex = 16;
            this.uctbRelayDDelayAct.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayDDelayAct.TickFrequency = 5;
            this.uctbRelayDDelayAct.Value = 1;
            this.uctbRelayDDelayAct.TrackbarChanged += new System.EventHandler(this.uctbRelayDDelayAct_TrackbarChanged);
            // 
            // uctbRelayDPulseExtended
            // 
            this.uctbRelayDPulseExtended.LargeChange = 5;
            this.uctbRelayDPulseExtended.Location = new System.Drawing.Point(242, 43);
            this.uctbRelayDPulseExtended.Maximum = 255;
            this.uctbRelayDPulseExtended.Minimum = 1;
            this.uctbRelayDPulseExtended.Name = "uctbRelayDPulseExtended";
            this.uctbRelayDPulseExtended.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayDPulseExtended.SmallChange = 1;
            this.uctbRelayDPulseExtended.TabIndex = 9;
            this.uctbRelayDPulseExtended.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayDPulseExtended.TickFrequency = 5;
            this.uctbRelayDPulseExtended.Value = 1;
            this.uctbRelayDPulseExtended.TrackbarChanged += new System.EventHandler(this.uctbRelayDPulseExtended_TrackbarChanged);
            // 
            // uctbRelayDPulseNormal
            // 
            this.uctbRelayDPulseNormal.LargeChange = 5;
            this.uctbRelayDPulseNormal.Location = new System.Drawing.Point(6, 43);
            this.uctbRelayDPulseNormal.Maximum = 255;
            this.uctbRelayDPulseNormal.Minimum = 1;
            this.uctbRelayDPulseNormal.Name = "uctbRelayDPulseNormal";
            this.uctbRelayDPulseNormal.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayDPulseNormal.SmallChange = 1;
            this.uctbRelayDPulseNormal.TabIndex = 7;
            this.uctbRelayDPulseNormal.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayDPulseNormal.TickFrequency = 5;
            this.uctbRelayDPulseNormal.Value = 1;
            this.uctbRelayDPulseNormal.TrackbarChanged += new System.EventHandler(this.uctbRelayDPulseNormal_TrackbarChanged);
            // 
            // uctbRelayCDelayAct
            // 
            this.uctbRelayCDelayAct.LargeChange = 5;
            this.uctbRelayCDelayAct.Location = new System.Drawing.Point(478, 43);
            this.uctbRelayCDelayAct.Maximum = 255;
            this.uctbRelayCDelayAct.Minimum = 1;
            this.uctbRelayCDelayAct.Name = "uctbRelayCDelayAct";
            this.uctbRelayCDelayAct.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayCDelayAct.SmallChange = 1;
            this.uctbRelayCDelayAct.TabIndex = 14;
            this.uctbRelayCDelayAct.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayCDelayAct.TickFrequency = 5;
            this.uctbRelayCDelayAct.Value = 1;
            this.uctbRelayCDelayAct.TrackbarChanged += new System.EventHandler(this.uctbRelayCDelayAct_TrackbarChanged);
            // 
            // uctbRelayCPulseExtended
            // 
            this.uctbRelayCPulseExtended.LargeChange = 5;
            this.uctbRelayCPulseExtended.Location = new System.Drawing.Point(242, 43);
            this.uctbRelayCPulseExtended.Maximum = 255;
            this.uctbRelayCPulseExtended.Minimum = 1;
            this.uctbRelayCPulseExtended.Name = "uctbRelayCPulseExtended";
            this.uctbRelayCPulseExtended.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayCPulseExtended.SmallChange = 1;
            this.uctbRelayCPulseExtended.TabIndex = 9;
            this.uctbRelayCPulseExtended.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayCPulseExtended.TickFrequency = 5;
            this.uctbRelayCPulseExtended.Value = 1;
            this.uctbRelayCPulseExtended.TrackbarChanged += new System.EventHandler(this.uctbRelayCPulseExtended_TrackbarChanged);
            // 
            // uctbRelayCPulseNormal
            // 
            this.uctbRelayCPulseNormal.LargeChange = 5;
            this.uctbRelayCPulseNormal.Location = new System.Drawing.Point(6, 43);
            this.uctbRelayCPulseNormal.Maximum = 255;
            this.uctbRelayCPulseNormal.Minimum = 1;
            this.uctbRelayCPulseNormal.Name = "uctbRelayCPulseNormal";
            this.uctbRelayCPulseNormal.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayCPulseNormal.SmallChange = 1;
            this.uctbRelayCPulseNormal.TabIndex = 7;
            this.uctbRelayCPulseNormal.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayCPulseNormal.TickFrequency = 5;
            this.uctbRelayCPulseNormal.Value = 1;
            this.uctbRelayCPulseNormal.TrackbarChanged += new System.EventHandler(this.uctbRelayCPulseNormal_TrackbarChanged);
            // 
            // uctbRelayBDelayAct
            // 
            this.uctbRelayBDelayAct.LargeChange = 5;
            this.uctbRelayBDelayAct.Location = new System.Drawing.Point(478, 41);
            this.uctbRelayBDelayAct.Maximum = 255;
            this.uctbRelayBDelayAct.Minimum = 1;
            this.uctbRelayBDelayAct.Name = "uctbRelayBDelayAct";
            this.uctbRelayBDelayAct.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayBDelayAct.SmallChange = 1;
            this.uctbRelayBDelayAct.TabIndex = 12;
            this.uctbRelayBDelayAct.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayBDelayAct.TickFrequency = 5;
            this.uctbRelayBDelayAct.Value = 1;
            this.uctbRelayBDelayAct.TrackbarChanged += new System.EventHandler(this.uctbRelayBDelayAct_TrackbarChanged);
            // 
            // uctbRelayBPulseExtended
            // 
            this.uctbRelayBPulseExtended.LargeChange = 5;
            this.uctbRelayBPulseExtended.Location = new System.Drawing.Point(242, 41);
            this.uctbRelayBPulseExtended.Maximum = 255;
            this.uctbRelayBPulseExtended.Minimum = 1;
            this.uctbRelayBPulseExtended.Name = "uctbRelayBPulseExtended";
            this.uctbRelayBPulseExtended.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayBPulseExtended.SmallChange = 1;
            this.uctbRelayBPulseExtended.TabIndex = 9;
            this.uctbRelayBPulseExtended.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayBPulseExtended.TickFrequency = 5;
            this.uctbRelayBPulseExtended.Value = 1;
            this.uctbRelayBPulseExtended.TrackbarChanged += new System.EventHandler(this.uctbRelayBPulseExtended_TrackbarChanged);
            // 
            // uctbRelayBPulseNormal
            // 
            this.uctbRelayBPulseNormal.LargeChange = 5;
            this.uctbRelayBPulseNormal.Location = new System.Drawing.Point(6, 43);
            this.uctbRelayBPulseNormal.Maximum = 255;
            this.uctbRelayBPulseNormal.Minimum = 1;
            this.uctbRelayBPulseNormal.Name = "uctbRelayBPulseNormal";
            this.uctbRelayBPulseNormal.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayBPulseNormal.SmallChange = 1;
            this.uctbRelayBPulseNormal.TabIndex = 7;
            this.uctbRelayBPulseNormal.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayBPulseNormal.TickFrequency = 5;
            this.uctbRelayBPulseNormal.Value = 1;
            this.uctbRelayBPulseNormal.TrackbarChanged += new System.EventHandler(this.uctbRelayBPulseNormal_TrackbarChanged);
            // 
            // uctbRelayADelayAct
            // 
            this.uctbRelayADelayAct.LargeChange = 5;
            this.uctbRelayADelayAct.Location = new System.Drawing.Point(478, 43);
            this.uctbRelayADelayAct.Maximum = 255;
            this.uctbRelayADelayAct.Minimum = 1;
            this.uctbRelayADelayAct.Name = "uctbRelayADelayAct";
            this.uctbRelayADelayAct.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayADelayAct.SmallChange = 1;
            this.uctbRelayADelayAct.TabIndex = 10;
            this.uctbRelayADelayAct.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayADelayAct.TickFrequency = 5;
            this.uctbRelayADelayAct.Value = 1;
            this.uctbRelayADelayAct.TrackbarChanged += new System.EventHandler(this.uctbRelayADelayAct_TrackbarChanged);
            // 
            // uctbRelayAPulseExtended
            // 
            this.uctbRelayAPulseExtended.LargeChange = 5;
            this.uctbRelayAPulseExtended.Location = new System.Drawing.Point(242, 43);
            this.uctbRelayAPulseExtended.Maximum = 255;
            this.uctbRelayAPulseExtended.Minimum = 1;
            this.uctbRelayAPulseExtended.Name = "uctbRelayAPulseExtended";
            this.uctbRelayAPulseExtended.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayAPulseExtended.SmallChange = 1;
            this.uctbRelayAPulseExtended.TabIndex = 9;
            this.uctbRelayAPulseExtended.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayAPulseExtended.TickFrequency = 5;
            this.uctbRelayAPulseExtended.Value = 1;
            this.uctbRelayAPulseExtended.TrackbarChanged += new System.EventHandler(this.uctbRelayAPulseExtended_TrackbarChanged);
            // 
            // uctbRelayAPulseNormal
            // 
            this.uctbRelayAPulseNormal.LargeChange = 5;
            this.uctbRelayAPulseNormal.Location = new System.Drawing.Point(6, 43);
            this.uctbRelayAPulseNormal.Maximum = 255;
            this.uctbRelayAPulseNormal.Minimum = 1;
            this.uctbRelayAPulseNormal.Name = "uctbRelayAPulseNormal";
            this.uctbRelayAPulseNormal.Size = new System.Drawing.Size(230, 69);
            this.uctbRelayAPulseNormal.SmallChange = 1;
            this.uctbRelayAPulseNormal.TabIndex = 7;
            this.uctbRelayAPulseNormal.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRelayAPulseNormal.TickFrequency = 5;
            this.uctbRelayAPulseNormal.Value = 1;
            this.uctbRelayAPulseNormal.TrackbarChanged += new System.EventHandler(this.uctbRelayAPulseNormal_TrackbarChanged);
            // 
            // uctbSensitivityUndetectThreshold
            // 
            this.uctbSensitivityUndetectThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbSensitivityUndetectThreshold.LargeChange = 5;
            this.uctbSensitivityUndetectThreshold.Location = new System.Drawing.Point(6, 149);
            this.uctbSensitivityUndetectThreshold.Maximum = 1000;
            this.uctbSensitivityUndetectThreshold.Minimum = 1;
            this.uctbSensitivityUndetectThreshold.Name = "uctbSensitivityUndetectThreshold";
            this.uctbSensitivityUndetectThreshold.Size = new System.Drawing.Size(695, 60);
            this.uctbSensitivityUndetectThreshold.SmallChange = 1;
            this.uctbSensitivityUndetectThreshold.TabIndex = 2;
            this.uctbSensitivityUndetectThreshold.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbSensitivityUndetectThreshold.TickFrequency = 10;
            this.uctbSensitivityUndetectThreshold.Value = 1;
            // 
            // uctbSensitivityDetectThreshold
            // 
            this.uctbSensitivityDetectThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbSensitivityDetectThreshold.LargeChange = 5;
            this.uctbSensitivityDetectThreshold.Location = new System.Drawing.Point(6, 70);
            this.uctbSensitivityDetectThreshold.Maximum = 1000;
            this.uctbSensitivityDetectThreshold.Minimum = 1;
            this.uctbSensitivityDetectThreshold.Name = "uctbSensitivityDetectThreshold";
            this.uctbSensitivityDetectThreshold.Size = new System.Drawing.Size(695, 60);
            this.uctbSensitivityDetectThreshold.SmallChange = 1;
            this.uctbSensitivityDetectThreshold.TabIndex = 1;
            this.uctbSensitivityDetectThreshold.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbSensitivityDetectThreshold.TickFrequency = 10;
            this.uctbSensitivityDetectThreshold.Value = 1;
            // 
            // uctbRuntimeRecalibTmr
            // 
            this.uctbRuntimeRecalibTmr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbRuntimeRecalibTmr.LargeChange = 5;
            this.uctbRuntimeRecalibTmr.Location = new System.Drawing.Point(9, 47);
            this.uctbRuntimeRecalibTmr.Maximum = 255;
            this.uctbRuntimeRecalibTmr.Minimum = 1;
            this.uctbRuntimeRecalibTmr.Name = "uctbRuntimeRecalibTmr";
            this.uctbRuntimeRecalibTmr.Size = new System.Drawing.Size(694, 69);
            this.uctbRuntimeRecalibTmr.SmallChange = 1;
            this.uctbRuntimeRecalibTmr.TabIndex = 11;
            this.uctbRuntimeRecalibTmr.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbRuntimeRecalibTmr.TickFrequency = 5;
            this.uctbRuntimeRecalibTmr.Value = 1;
            this.uctbRuntimeRecalibTmr.TrackbarChanged += new System.EventHandler(this.uctbRuntimeRecalibTmr_TrackbarChanged);
            // 
            // uctbSlowStartupTimer
            // 
            this.uctbSlowStartupTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbSlowStartupTimer.LargeChange = 5;
            this.uctbSlowStartupTimer.Location = new System.Drawing.Point(10, 44);
            this.uctbSlowStartupTimer.Maximum = 255;
            this.uctbSlowStartupTimer.Minimum = 1;
            this.uctbSlowStartupTimer.Name = "uctbSlowStartupTimer";
            this.uctbSlowStartupTimer.Size = new System.Drawing.Size(694, 69);
            this.uctbSlowStartupTimer.SmallChange = 1;
            this.uctbSlowStartupTimer.TabIndex = 9;
            this.uctbSlowStartupTimer.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbSlowStartupTimer.TickFrequency = 5;
            this.uctbSlowStartupTimer.Value = 1;
            this.uctbSlowStartupTimer.TrackbarChanged += new System.EventHandler(this.uctbSlowStartupTimer_TrackbarChanged);
            // 
            // uctbFilteringAveraging
            // 
            this.uctbFilteringAveraging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbFilteringAveraging.LargeChange = 1;
            this.uctbFilteringAveraging.Location = new System.Drawing.Point(6, 255);
            this.uctbFilteringAveraging.Maximum = 8;
            this.uctbFilteringAveraging.Minimum = 1;
            this.uctbFilteringAveraging.Name = "uctbFilteringAveraging";
            this.uctbFilteringAveraging.Size = new System.Drawing.Size(715, 59);
            this.uctbFilteringAveraging.SmallChange = 1;
            this.uctbFilteringAveraging.TabIndex = 12;
            this.uctbFilteringAveraging.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbFilteringAveraging.TickFrequency = 1;
            this.uctbFilteringAveraging.Value = 1;
            // 
            // uctbFilteringPositive
            // 
            this.uctbFilteringPositive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbFilteringPositive.LargeChange = 5;
            this.uctbFilteringPositive.Location = new System.Drawing.Point(6, 170);
            this.uctbFilteringPositive.Maximum = 255;
            this.uctbFilteringPositive.Minimum = 1;
            this.uctbFilteringPositive.Name = "uctbFilteringPositive";
            this.uctbFilteringPositive.Size = new System.Drawing.Size(715, 60);
            this.uctbFilteringPositive.SmallChange = 1;
            this.uctbFilteringPositive.TabIndex = 10;
            this.uctbFilteringPositive.Tag = "TMR1BEST_CHANGE;UPDATE_CONFIG_PACKET";
            this.uctbFilteringPositive.TickFrequency = 5;
            this.uctbFilteringPositive.Value = 1;
            this.uctbFilteringPositive.TrackbarChanged += new System.EventHandler(this.uctbFilteringPositive_TrackbarChanged);
            // 
            // uctbFilteringNegative
            // 
            this.uctbFilteringNegative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbFilteringNegative.LargeChange = 5;
            this.uctbFilteringNegative.Location = new System.Drawing.Point(6, 86);
            this.uctbFilteringNegative.Maximum = 255;
            this.uctbFilteringNegative.Minimum = 1;
            this.uctbFilteringNegative.Name = "uctbFilteringNegative";
            this.uctbFilteringNegative.Size = new System.Drawing.Size(715, 60);
            this.uctbFilteringNegative.SmallChange = 1;
            this.uctbFilteringNegative.TabIndex = 8;
            this.uctbFilteringNegative.Tag = "TMR1BEST_CHANGE;UPDATE_CONFIG_PACKET";
            this.uctbFilteringNegative.TickFrequency = 5;
            this.uctbFilteringNegative.Value = 1;
            this.uctbFilteringNegative.TrackbarChanged += new System.EventHandler(this.uctbFilteringNegative_TrackbarChanged);
            // 
            // uctbDCDDThreshold
            // 
            this.uctbDCDDThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbDCDDThreshold.LargeChange = 5;
            this.uctbDCDDThreshold.Location = new System.Drawing.Point(6, 148);
            this.uctbDCDDThreshold.Maximum = 255;
            this.uctbDCDDThreshold.Minimum = 1;
            this.uctbDCDDThreshold.Name = "uctbDCDDThreshold";
            this.uctbDCDDThreshold.Size = new System.Drawing.Size(143, 71);
            this.uctbDCDDThreshold.SmallChange = 1;
            this.uctbDCDDThreshold.TabIndex = 13;
            this.uctbDCDDThreshold.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbDCDDThreshold.TickFrequency = 5;
            this.uctbDCDDThreshold.Value = 1;
            // 
            // uctbDCDDTimer
            // 
            this.uctbDCDDTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbDCDDTimer.LargeChange = 5;
            this.uctbDCDDTimer.Location = new System.Drawing.Point(6, 55);
            this.uctbDCDDTimer.Maximum = 65535;
            this.uctbDCDDTimer.Minimum = 1;
            this.uctbDCDDTimer.Name = "uctbDCDDTimer";
            this.uctbDCDDTimer.Size = new System.Drawing.Size(144, 71);
            this.uctbDCDDTimer.SmallChange = 1;
            this.uctbDCDDTimer.TabIndex = 11;
            this.uctbDCDDTimer.Tag = "TMR1BEST_CHANGE;UPDATE_CONFIG_PACKET";
            this.uctbDCDDTimer.TickFrequency = 512;
            this.uctbDCDDTimer.Value = 1;
            this.uctbDCDDTimer.TrackbarChanged += new System.EventHandler(this.uctbDCDDTimer_TrackbarChanged);
            // 
            // uctbDetStopSlowCheckerTimer
            // 
            this.uctbDetStopSlowCheckerTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbDetStopSlowCheckerTimer.LargeChange = 5;
            this.uctbDetStopSlowCheckerTimer.Location = new System.Drawing.Point(6, 232);
            this.uctbDetStopSlowCheckerTimer.Maximum = 255;
            this.uctbDetStopSlowCheckerTimer.Minimum = 1;
            this.uctbDetStopSlowCheckerTimer.Name = "uctbDetStopSlowCheckerTimer";
            this.uctbDetStopSlowCheckerTimer.Size = new System.Drawing.Size(155, 71);
            this.uctbDetStopSlowCheckerTimer.SmallChange = 1;
            this.uctbDetStopSlowCheckerTimer.TabIndex = 12;
            this.uctbDetStopSlowCheckerTimer.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbDetStopSlowCheckerTimer.TickFrequency = 5;
            this.uctbDetStopSlowCheckerTimer.Value = 1;
            this.uctbDetStopSlowCheckerTimer.TrackbarChanged += new System.EventHandler(this.uctbDetStopSlowCheckerTimer_TrackbarChanged);
            // 
            // uctbDetStopThreshold
            // 
            this.uctbDetStopThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbDetStopThreshold.LargeChange = 5;
            this.uctbDetStopThreshold.Location = new System.Drawing.Point(6, 141);
            this.uctbDetStopThreshold.Maximum = 255;
            this.uctbDetStopThreshold.Minimum = 1;
            this.uctbDetStopThreshold.Name = "uctbDetStopThreshold";
            this.uctbDetStopThreshold.Size = new System.Drawing.Size(155, 71);
            this.uctbDetStopThreshold.SmallChange = 1;
            this.uctbDetStopThreshold.TabIndex = 9;
            this.uctbDetStopThreshold.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbDetStopThreshold.TickFrequency = 5;
            this.uctbDetStopThreshold.Value = 1;
            // 
            // uctbDetStopTimer
            // 
            this.uctbDetStopTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbDetStopTimer.LargeChange = 5;
            this.uctbDetStopTimer.Location = new System.Drawing.Point(6, 50);
            this.uctbDetStopTimer.Maximum = 255;
            this.uctbDetStopTimer.Minimum = 1;
            this.uctbDetStopTimer.Name = "uctbDetStopTimer";
            this.uctbDetStopTimer.Size = new System.Drawing.Size(155, 71);
            this.uctbDetStopTimer.SmallChange = 1;
            this.uctbDetStopTimer.TabIndex = 8;
            this.uctbDetStopTimer.Tag = "TMR1BEST_CHANGE;UPDATE_CONFIG_PACKET";
            this.uctbDetStopTimer.TickFrequency = 5;
            this.uctbDetStopTimer.Value = 1;
            this.uctbDetStopTimer.TrackbarChanged += new System.EventHandler(this.uctbDetStopTimer_TrackbarChanged);
            // 
            // uctbSamplingSpeed
            // 
            this.uctbSamplingSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbSamplingSpeed.LargeChange = 50;
            this.uctbSamplingSpeed.Location = new System.Drawing.Point(7, 55);
            this.uctbSamplingSpeed.Maximum = 50000;
            this.uctbSamplingSpeed.Minimum = 12000;
            this.uctbSamplingSpeed.Name = "uctbSamplingSpeed";
            this.uctbSamplingSpeed.Size = new System.Drawing.Size(709, 71);
            this.uctbSamplingSpeed.SmallChange = 10;
            this.uctbSamplingSpeed.TabIndex = 6;
            this.uctbSamplingSpeed.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbSamplingSpeed.TickFrequency = 100;
            this.uctbSamplingSpeed.Value = 35000;
            this.uctbSamplingSpeed.TrackbarChanged += new System.EventHandler(this.ucTrackBar1_TrackbarChanged);
            // 
            // uctbSpeedDistance
            // 
            this.uctbSpeedDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbSpeedDistance.LargeChange = 5;
            this.uctbSpeedDistance.Location = new System.Drawing.Point(6, 58);
            this.uctbSpeedDistance.Maximum = 1000;
            this.uctbSpeedDistance.Minimum = 1;
            this.uctbSpeedDistance.Name = "uctbSpeedDistance";
            this.uctbSpeedDistance.Size = new System.Drawing.Size(715, 71);
            this.uctbSpeedDistance.SmallChange = 1;
            this.uctbSpeedDistance.TabIndex = 11;
            this.uctbSpeedDistance.Tag = "UPDATE_CONFIG_PACKET;TMR1BEST_CHANGE";
            this.uctbSpeedDistance.TickFrequency = 5;
            this.uctbSpeedDistance.Value = 1;
            this.uctbSpeedDistance.TrackbarChanged += new System.EventHandler(this.uctbSpeedDistance_TrackbarChanged);
            // 
            // uctbPPCDetLeftThreshold
            // 
            this.uctbPPCDetLeftThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbPPCDetLeftThreshold.LargeChange = 5;
            this.uctbPPCDetLeftThreshold.Location = new System.Drawing.Point(8, 126);
            this.uctbPPCDetLeftThreshold.Maximum = 255;
            this.uctbPPCDetLeftThreshold.Minimum = 1;
            this.uctbPPCDetLeftThreshold.Name = "uctbPPCDetLeftThreshold";
            this.uctbPPCDetLeftThreshold.Size = new System.Drawing.Size(149, 71);
            this.uctbPPCDetLeftThreshold.SmallChange = 1;
            this.uctbPPCDetLeftThreshold.TabIndex = 16;
            this.uctbPPCDetLeftThreshold.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbPPCDetLeftThreshold.TickFrequency = 5;
            this.uctbPPCDetLeftThreshold.Value = 1;
            // 
            // uctbPPCDetLeftTimer
            // 
            this.uctbPPCDetLeftTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbPPCDetLeftTimer.LargeChange = 5;
            this.uctbPPCDetLeftTimer.Location = new System.Drawing.Point(8, 36);
            this.uctbPPCDetLeftTimer.Maximum = 255;
            this.uctbPPCDetLeftTimer.Minimum = 1;
            this.uctbPPCDetLeftTimer.Name = "uctbPPCDetLeftTimer";
            this.uctbPPCDetLeftTimer.Size = new System.Drawing.Size(149, 70);
            this.uctbPPCDetLeftTimer.SmallChange = 1;
            this.uctbPPCDetLeftTimer.TabIndex = 14;
            this.uctbPPCDetLeftTimer.Tag = "TMR1BEST_CHANGE;UPDATE_CONFIG_PACKET";
            this.uctbPPCDetLeftTimer.TickFrequency = 5;
            this.uctbPPCDetLeftTimer.Value = 1;
            this.uctbPPCDetLeftTimer.TrackbarChanged += new System.EventHandler(this.uctbPPCDetLeftTimer_TrackbarChanged);
            // 
            // uctbPPCLong
            // 
            this.uctbPPCLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbPPCLong.LargeChange = 5;
            this.uctbPPCLong.Location = new System.Drawing.Point(9, 240);
            this.uctbPPCLong.Maximum = 255;
            this.uctbPPCLong.Minimum = 1;
            this.uctbPPCLong.Name = "uctbPPCLong";
            this.uctbPPCLong.Size = new System.Drawing.Size(160, 71);
            this.uctbPPCLong.SmallChange = 1;
            this.uctbPPCLong.TabIndex = 16;
            this.uctbPPCLong.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbPPCLong.TickFrequency = 5;
            this.uctbPPCLong.Value = 1;
            this.uctbPPCLong.TrackbarChanged += new System.EventHandler(this.uctbPPCLong_TrackbarChanged);
            // 
            // uctbPPCMedium
            // 
            this.uctbPPCMedium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbPPCMedium.LargeChange = 5;
            this.uctbPPCMedium.Location = new System.Drawing.Point(9, 149);
            this.uctbPPCMedium.Maximum = 255;
            this.uctbPPCMedium.Minimum = 1;
            this.uctbPPCMedium.Name = "uctbPPCMedium";
            this.uctbPPCMedium.Size = new System.Drawing.Size(160, 71);
            this.uctbPPCMedium.SmallChange = 1;
            this.uctbPPCMedium.TabIndex = 14;
            this.uctbPPCMedium.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbPPCMedium.TickFrequency = 5;
            this.uctbPPCMedium.Value = 1;
            this.uctbPPCMedium.TrackbarChanged += new System.EventHandler(this.uctbPPCMedium_TrackbarChanged);
            // 
            // uctbPPCShort
            // 
            this.uctbPPCShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctbPPCShort.LargeChange = 5;
            this.uctbPPCShort.Location = new System.Drawing.Point(9, 58);
            this.uctbPPCShort.Maximum = 255;
            this.uctbPPCShort.Minimum = 1;
            this.uctbPPCShort.Name = "uctbPPCShort";
            this.uctbPPCShort.Size = new System.Drawing.Size(160, 71);
            this.uctbPPCShort.SmallChange = 1;
            this.uctbPPCShort.TabIndex = 8;
            this.uctbPPCShort.Tag = "UPDATE_CONFIG_PACKET";
            this.uctbPPCShort.TickFrequency = 5;
            this.uctbPPCShort.Value = 1;
            this.uctbPPCShort.TrackbarChanged += new System.EventHandler(this.uctbPPC_TrackbarChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 742);
            this.Controls.Add(this.pnlMiscOptions);
            this.Controls.Add(this.pnlRelayPulseDurations);
            this.Controls.Add(this.pnlOperatingMode);
            this.Controls.Add(this.pnlSensitivity);
            this.Controls.Add(this.pnlFilteringLevels);
            this.Controls.Add(this.pnlSignalAnalysis);
            this.Controls.Add(this.pnlEventViewer);
            this.Controls.Add(this.pnlDCDD);
            this.Controls.Add(this.pnlDetectStop);
            this.Controls.Add(this.pnlSamplingSpeed);
            this.Controls.Add(this.pnlSpeedTrap);
            this.Controls.Add(this.pnlPPC);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quad Channel Inductive Loop Vehicle Detector - www.elektronika.ba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlOperatingMode.ResumeLayout(false);
            this.tcMainConfigDIPs.ResumeLayout(false);
            this.tabGeneralDIPs.ResumeLayout(false);
            this.tabGeneralDIPs.PerformLayout();
            this.gbDIP1.ResumeLayout(false);
            this.gbDIP1.PerformLayout();
            this.gbDIP2.ResumeLayout(false);
            this.gbDIP2.PerformLayout();
            this.tabChannelDIPs.ResumeLayout(false);
            this.tabChannelDIPs.PerformLayout();
            this.gbCHDIP1.ResumeLayout(false);
            this.gbCHDIP1.PerformLayout();
            this.gbCHDIP2.ResumeLayout(false);
            this.gbCHDIP2.PerformLayout();
            this.gbCHDips.ResumeLayout(false);
            this.gbCHDips.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.pnlSamplingSpeed.ResumeLayout(false);
            this.pnlSamplingSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreqVsSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSensitivityExamples)).EndInit();
            this.pnlSensitivity.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlFilteringLevels.ResumeLayout(false);
            this.pnlFilteringLevels.PerformLayout();
            this.pnlRelayPulseDurations.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlPPC.ResumeLayout(false);
            this.pnlPPC.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pnlDetectStop.ResumeLayout(false);
            this.pnlDetectStop.PerformLayout();
            this.pnlDCDD.ResumeLayout(false);
            this.pnlDCDD.PerformLayout();
            this.pnlSpeedTrap.ResumeLayout(false);
            this.pnlSpeedTrap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMaximumSpeedErrors)).EndInit();
            this.pnlEventViewer.ResumeLayout(false);
            this.pnlEventViewer.PerformLayout();
            this.pnlSignalAnalysis.ResumeLayout(false);
            this.pnlSignalAnalysis.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chAnalysisLoopA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAnalysisLoopB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAnalysisLoopC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAnalysisLoopD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlMiscOptions.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReadFromDevice;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.ToolStripStatusLabel tssDateTime;
        private System.Windows.Forms.ToolStripStatusLabel tssConnectionStatus;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.ToolStripProgressBar tssProgress;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel pnlOperatingMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuickPresets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDIP1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox ckGenDIP1_6;
        private System.Windows.Forms.CheckBox ckGenDIP1_5;
        private System.Windows.Forms.CheckBox ckGenDIP1_4;
        private System.Windows.Forms.CheckBox ckGenDIP1_3;
        private System.Windows.Forms.CheckBox ckGenDIP1_2;
        private System.Windows.Forms.CheckBox ckGenDIP1_1;
        private System.Windows.Forms.GroupBox gbDIP2;
        private System.Windows.Forms.CheckBox ckGenDIP2_8;
        private System.Windows.Forms.CheckBox ckGenDIP2_7;
        private System.Windows.Forms.CheckBox ckGenDIP2_6;
        private System.Windows.Forms.CheckBox ckGenDIP2_5;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbConnectDisconnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel pnlSamplingSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ucTrackBar uctbSamplingSpeed;
        private System.Windows.Forms.Label lblTmr1SamplingSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tblSensitivityExamples;
        private System.Windows.Forms.Timer tmrSensitivitiesExampleGenerator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sensitivity;
        private System.Windows.Forms.Panel pnlSensitivity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSensitivityForBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ucTrackBar uctbSensitivityDetectThreshold;
        private System.Windows.Forms.Label label9;
        private ucTrackBar uctbSensitivityUndetectThreshold;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSensitivityA;
        private System.Windows.Forms.Panel pnlFilteringLevels;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbFilteringLevel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFilteringNegative;
        private ucTrackBar uctbFilteringNegative;
        private System.Windows.Forms.Label label17;
        private ucTrackBar uctbFilteringAveraging;
        private System.Windows.Forms.Label lblFilteringPositive;
        private ucTrackBar uctbFilteringPositive;
        private System.Windows.Forms.Panel pnlRelayPulseDurations;
        private System.Windows.Forms.Label label15;
        private ucTrackBar uctbRelayAPulseExtended;
        private System.Windows.Forms.Label lblRelayAPulseExtended;
        private ucTrackBar uctbRelayAPulseNormal;
        private System.Windows.Forms.Label lblRelayAPulseNormal;
        private System.Windows.Forms.Panel pnlPPC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPPCShort;
        private ucTrackBar uctbPPCShort;
        private System.Windows.Forms.Panel pnlDetectStop;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFreqVsSens;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblDetectStopTimer;
        private ucTrackBar uctbDetStopThreshold;
        private ucTrackBar uctbDetStopTimer;
        private System.Windows.Forms.Label lblDetectStopSlowCheckTimer;
        private ucTrackBar uctbDetStopSlowCheckerTimer;
        private System.Windows.Forms.Panel pnlDCDD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private ucTrackBar uctbDCDDThreshold;
        private System.Windows.Forms.Label label25;
        private ucTrackBar uctbDCDDTimer;
        private System.Windows.Forms.Label lblDCDDTimer;
        private System.Windows.Forms.Panel pnlSpeedTrap;
        private System.Windows.Forms.Label label24;
        private ucTrackBar uctbSpeedDistance;
        private System.Windows.Forms.Label lblSpeedLoopDistance;
        private System.Windows.Forms.ToolStripStatusLabel tssFrequencyLoopA;
        private System.Windows.Forms.ToolStripStatusLabel tssFrequencyLoopB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem factoryResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem restartCPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Timer tmrUpdateConfigPacket;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRelayBPulseNormal;
        private ucTrackBar uctbRelayBPulseExtended;
        private ucTrackBar uctbRelayBPulseNormal;
        private System.Windows.Forms.Label lblRelayBPulseExtended;
        private System.Windows.Forms.CheckBox ckUseSoftDIPs;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssDeviceState;
        private System.Windows.Forms.GroupBox groupBox5;
        private ucTrackBar uctbPPCDetLeftThreshold;
        private System.Windows.Forms.Label label21;
        private ucTrackBar uctbPPCDetLeftTimer;
        private System.Windows.Forms.Label lblPPCDetLeaveTimer;
        private ucTrackBar uctbPPCLong;
        private System.Windows.Forms.Label lblPPCLong;
        private ucTrackBar uctbPPCMedium;
        private System.Windows.Forms.Label lblPPCMedium;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ToolStripMenuItem returnToRunningModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button btnReadDIPsFromDevice;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel pnlEventViewer;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLoggingState;
        private System.Windows.Forms.Label lblLastEventLoopA;
        private System.Windows.Forms.Label lblLastEventLoopB;
        private System.Windows.Forms.Label lblLastJointEventAB;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Panel pnlSignalAnalysis;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnSignalAnalysis;
        private System.Windows.Forms.Label lblSignalAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chAnalysisLoopB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chAnalysisLoopA;
        private System.Windows.Forms.Button btnSaveAnalysisLoopB;
        private System.Windows.Forms.Button btnSaveAnalysisLoopA;
        private System.Windows.Forms.CheckBox ckAutoSaveAnalysisLoopB;
        private System.Windows.Forms.CheckBox ckAutoSaveAnalysisLoopA;
        private System.Windows.Forms.SaveFileDialog saveAnalysisDialog;
        private System.Windows.Forms.SaveFileDialog saveChartImageDialog;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.SaveFileDialog saveLogDialog;
        private System.Windows.Forms.DataGridView tblMaximumSpeedErrors;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Timer tmrSpeedTrapErrorGenerator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorstPossibleMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximumErrorKMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximumErrorPercent;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tcMainConfigDIPs;
        private System.Windows.Forms.TabPage tabChannelDIPs;
        private System.Windows.Forms.TabPage tabGeneralDIPs;
        private System.Windows.Forms.GroupBox gbCHDips;
        private System.Windows.Forms.RadioButton rbCHDIPsB;
        private System.Windows.Forms.RadioButton rbCHDIPsA;
        private System.Windows.Forms.RadioButton rbCHDIPsD;
        private System.Windows.Forms.RadioButton rbCHDIPsC;
        private System.Windows.Forms.GroupBox gbCHDIP1;
        private System.Windows.Forms.CheckBox ckCHDIP1_8;
        private System.Windows.Forms.CheckBox ckCHDIP1_7;
        private System.Windows.Forms.CheckBox ckCHDIP1_6;
        private System.Windows.Forms.CheckBox ckCHDIP1_5;
        private System.Windows.Forms.CheckBox ckCHDIP1_4;
        private System.Windows.Forms.CheckBox ckCHDIP1_3;
        private System.Windows.Forms.CheckBox ckCHDIP1_2;
        private System.Windows.Forms.CheckBox ckCHDIP1_1;
        private System.Windows.Forms.GroupBox gbCHDIP2;
        private System.Windows.Forms.CheckBox ckCHDIP2_8;
        private System.Windows.Forms.CheckBox ckCHDIP2_7;
        private System.Windows.Forms.CheckBox ckCHDIP2_6;
        private System.Windows.Forms.CheckBox ckCHDIP2_5;
        private System.Windows.Forms.CheckBox ckCHDIP2_4;
        private System.Windows.Forms.CheckBox ckCHDIP2_3;
        private System.Windows.Forms.CheckBox ckCHDIP2_2;
        private System.Windows.Forms.CheckBox ckCHDIP2_1;
        private System.Windows.Forms.Button btnCHDipsCopyFrom;
        private System.Windows.Forms.ComboBox cbCopyCHDIPsFrom;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ToolStripStatusLabel tssFrequencyLoopC;
        private System.Windows.Forms.ToolStripStatusLabel tssFrequencyLoopD;
        private System.Windows.Forms.Label lblShowingDIPsForChannel;
        private System.Windows.Forms.Panel pnlGroupedCD;
        private System.Windows.Forms.Panel pnlGroupedAB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbSensitivityD;
        private System.Windows.Forms.ComboBox cbSensitivityC;
        private System.Windows.Forms.ComboBox cbSensitivityB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblRelayDPulseNormal;
        private ucTrackBar uctbRelayDPulseExtended;
        private ucTrackBar uctbRelayDPulseNormal;
        private System.Windows.Forms.Label lblRelayDPulseExtended;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblRelayCPulseNormal;
        private ucTrackBar uctbRelayCPulseExtended;
        private ucTrackBar uctbRelayCPulseNormal;
        private System.Windows.Forms.Label lblRelayCPulseExtended;
        private System.Windows.Forms.Label lblRelayDDelayAct;
        private ucTrackBar uctbRelayDDelayAct;
        private System.Windows.Forms.Label lblRelayCDelayAct;
        private ucTrackBar uctbRelayCDelayAct;
        private System.Windows.Forms.Label lblRelayBDelayAct;
        private ucTrackBar uctbRelayBDelayAct;
        private System.Windows.Forms.Label lblRelayADelayAct;
        private ucTrackBar uctbRelayADelayAct;
        private System.Windows.Forms.Panel pnlMiscOptions;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblSlowStartupTmr;
        private ucTrackBar uctbSlowStartupTimer;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblRuntimeRecalibTmr;
        private ucTrackBar uctbRuntimeRecalibTmr;
        private System.Windows.Forms.Label lblLastJointEventCD;
        private System.Windows.Forms.Label lblLastEventLoopD;
        private System.Windows.Forms.Label lblLastEventLoopC;
        private System.Windows.Forms.CheckBox ckAutoSaveAnalysisLoopD;
        private System.Windows.Forms.Button btnSaveAnalysisLoopD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chAnalysisLoopD;
        private System.Windows.Forms.CheckBox ckAutoSaveAnalysisLoopC;
        private System.Windows.Forms.Button btnSaveAnalysisLoopC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chAnalysisLoopC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

