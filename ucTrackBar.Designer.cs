namespace QLDConfig1v2
{
    partial class ucTrackBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb = new System.Windows.Forms.TrackBar();
            this.lblR = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.Location = new System.Drawing.Point(3, 22);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(365, 45);
            this.tb.TabIndex = 0;
            this.tb.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // lblR
            // 
            this.lblR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblR.Location = new System.Drawing.Point(217, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(154, 23);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "?/?";
            this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblL
            // 
            this.lblL.Location = new System.Drawing.Point(0, 0);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(158, 23);
            this.lblL.TabIndex = 2;
            this.lblL.Text = "?/?";
            this.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.tb);
            this.Name = "ucTrackBar";
            this.Size = new System.Drawing.Size(371, 71);
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tb;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblL;
    }
}
