namespace SSMSDiag
{
    partial class fSQLToolsDiag
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
            this.btnStartSSSMSLogging = new System.Windows.Forms.Button();
            this.btnCollectSSMSInstallLogs = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn2015SetupLogs = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSSDTSetupLogs = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnVSIXSetupLogs = new System.Windows.Forms.Button();
            this.btnSSISSetupLogs = new System.Windows.Forms.Button();
            this.btnStopSSDTLogging = new System.Windows.Forms.Button();
            this.btnStartSSDTLogging = new System.Windows.Forms.Button();
            this.bwStartSSMS = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspbProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bwCopyFiles = new System.ComponentModel.BackgroundWorker();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnDEALogs = new System.Windows.Forms.Button();
            this.btnDEASetup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartSSSMSLogging
            // 
            this.btnStartSSSMSLogging.Location = new System.Drawing.Point(22, 66);
            this.btnStartSSSMSLogging.Name = "btnStartSSSMSLogging";
            this.btnStartSSSMSLogging.Size = new System.Drawing.Size(216, 43);
            this.btnStartSSSMSLogging.TabIndex = 0;
            this.btnStartSSSMSLogging.Text = "Start SSMS with Logging ";
            this.btnStartSSSMSLogging.UseVisualStyleBackColor = true;
            this.btnStartSSSMSLogging.Click += new System.EventHandler(this.btnStartSSSMSLogging_Click);
            // 
            // btnCollectSSMSInstallLogs
            // 
            this.btnCollectSSMSInstallLogs.Location = new System.Drawing.Point(247, 66);
            this.btnCollectSSMSInstallLogs.Name = "btnCollectSSMSInstallLogs";
            this.btnCollectSSMSInstallLogs.Size = new System.Drawing.Size(216, 43);
            this.btnCollectSSMSInstallLogs.TabIndex = 1;
            this.btnCollectSSMSInstallLogs.Text = "Collect SSMS Install Logs";
            this.btnCollectSSMSInstallLogs.UseVisualStyleBackColor = true;
            this.btnCollectSSMSInstallLogs.Click += new System.EventHandler(this.btnCollectSSMSInstallLogs_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 199);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 264);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnStartSSSMSLogging);
            this.tabPage1.Controls.Add(this.btnCollectSSMSInstallLogs);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SSMS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Collect SSMS config Logs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.btnStopSSDTLogging);
            this.tabPage2.Controls.Add(this.btnStartSSDTLogging);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SSDT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(275, 14);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(468, 215);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn2015SetupLogs);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(460, 186);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "2015";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn2015SetupLogs
            // 
            this.btn2015SetupLogs.Location = new System.Drawing.Point(76, 26);
            this.btn2015SetupLogs.Name = "btn2015SetupLogs";
            this.btn2015SetupLogs.Size = new System.Drawing.Size(216, 43);
            this.btn2015SetupLogs.TabIndex = 6;
            this.btn2015SetupLogs.Text = "Collect SSDT 15 Setup Logs";
            this.btn2015SetupLogs.UseVisualStyleBackColor = true;
            this.btn2015SetupLogs.Click += new System.EventHandler(this.btn2015SetupLogs_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSSDTSetupLogs);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(460, 186);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "2017";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSSDTSetupLogs
            // 
            this.btnSSDTSetupLogs.Location = new System.Drawing.Point(76, 26);
            this.btnSSDTSetupLogs.Name = "btnSSDTSetupLogs";
            this.btnSSDTSetupLogs.Size = new System.Drawing.Size(216, 43);
            this.btnSSDTSetupLogs.TabIndex = 5;
            this.btnSSDTSetupLogs.Text = "Collect SSDT 17 Setup Logs";
            this.btnSSDTSetupLogs.UseVisualStyleBackColor = true;
            this.btnSSDTSetupLogs.Click += new System.EventHandler(this.btnSSDTSetupLogs_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnVSIXSetupLogs);
            this.tabPage4.Controls.Add(this.btnSSISSetupLogs);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(460, 186);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "2019";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnVSIXSetupLogs
            // 
            this.btnVSIXSetupLogs.Location = new System.Drawing.Point(219, 26);
            this.btnVSIXSetupLogs.Name = "btnVSIXSetupLogs";
            this.btnVSIXSetupLogs.Size = new System.Drawing.Size(183, 42);
            this.btnVSIXSetupLogs.TabIndex = 1;
            this.btnVSIXSetupLogs.Text = "Collect AS/RS Setup Logs";
            this.btnVSIXSetupLogs.UseVisualStyleBackColor = true;
            this.btnVSIXSetupLogs.Click += new System.EventHandler(this.btnVSIXSetupLogs_Click);
            // 
            // btnSSISSetupLogs
            // 
            this.btnSSISSetupLogs.Location = new System.Drawing.Point(19, 26);
            this.btnSSISSetupLogs.Name = "btnSSISSetupLogs";
            this.btnSSISSetupLogs.Size = new System.Drawing.Size(183, 42);
            this.btnSSISSetupLogs.TabIndex = 0;
            this.btnSSISSetupLogs.Text = "Collect IS Setup Logs";
            this.btnSSISSetupLogs.UseVisualStyleBackColor = true;
            this.btnSSISSetupLogs.Click += new System.EventHandler(this.btnSSISSetupLogs_Click);
            // 
            // btnStopSSDTLogging
            // 
            this.btnStopSSDTLogging.Location = new System.Drawing.Point(6, 77);
            this.btnStopSSDTLogging.Name = "btnStopSSDTLogging";
            this.btnStopSSDTLogging.Size = new System.Drawing.Size(216, 43);
            this.btnStopSSDTLogging.TabIndex = 4;
            this.btnStopSSDTLogging.Text = "Stop SSDT Logging";
            this.btnStopSSDTLogging.UseVisualStyleBackColor = true;
            this.btnStopSSDTLogging.Click += new System.EventHandler(this.btnStopSSDTLogging_Click);
            // 
            // btnStartSSDTLogging
            // 
            this.btnStartSSDTLogging.Location = new System.Drawing.Point(6, 14);
            this.btnStartSSDTLogging.Name = "btnStartSSDTLogging";
            this.btnStartSSDTLogging.Size = new System.Drawing.Size(216, 43);
            this.btnStartSSDTLogging.TabIndex = 2;
            this.btnStartSSDTLogging.Text = "Start SSDT Logging ";
            this.btnStartSSDTLogging.UseVisualStyleBackColor = true;
            this.btnStartSSDTLogging.Click += new System.EventHandler(this.btnStartSSDTLogging_Click);
            // 
            // bwStartSSMS
            // 
            this.bwStartSSMS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwStartSSMS_DoWork);
            this.bwStartSSMS.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwStartSSMS_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbProcess,
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspbProcess
            // 
            this.tspbProcess.MarqueeAnimationSpeed = 0;
            this.tspbProcess.Name = "tspbProcess";
            this.tspbProcess.Size = new System.Drawing.Size(100, 19);
            this.tspbProcess.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(50, 20);
            this.tsslStatus.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 92);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remember that SQLToolsDiag has to \r\nrun as admin";
            // 
            // bwCopyFiles
            // 
            this.bwCopyFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCopyFiles_DoWork);
            this.bwCopyFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCopyFiles_RunWorkerCompleted);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnDEALogs);
            this.tabPage6.Controls.Add(this.btnDEASetup);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(746, 235);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "DEA";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnDEALogs
            // 
            this.btnDEALogs.Location = new System.Drawing.Point(6, 77);
            this.btnDEALogs.Name = "btnDEALogs";
            this.btnDEALogs.Size = new System.Drawing.Size(216, 43);
            this.btnDEALogs.TabIndex = 6;
            this.btnDEALogs.Text = "DEA Logs";
            this.btnDEALogs.UseVisualStyleBackColor = true;
            this.btnDEALogs.Click += new System.EventHandler(this.btnDEALogs_Click);
            // 
            // btnDEASetup
            // 
            this.btnDEASetup.Location = new System.Drawing.Point(6, 14);
            this.btnDEASetup.Name = "btnDEASetup";
            this.btnDEASetup.Size = new System.Drawing.Size(216, 43);
            this.btnDEASetup.TabIndex = 5;
            this.btnDEASetup.Text = "Setup Logs";
            this.btnDEASetup.UseVisualStyleBackColor = true;
            this.btnDEASetup.Click += new System.EventHandler(this.btnDEASetup_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // fSQLToolsDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "fSQLToolsDiag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLToolsDiag ";
            this.Load += new System.EventHandler(this.fSQLToolsDiag_Load);
            this.Shown += new System.EventHandler(this.fSQLToolsDiag_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSSSMSLogging;
        private System.Windows.Forms.Button btnCollectSSMSInstallLogs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStartSSDTLogging;
        private System.Windows.Forms.Button btnStopSSDTLogging;
        private System.ComponentModel.BackgroundWorker bwStartSSMS;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tspbProcess;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bwCopyFiles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSSDTSetupLogs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnVSIXSetupLogs;
        private System.Windows.Forms.Button btnSSISSetupLogs;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn2015SetupLogs;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnDEALogs;
        private System.Windows.Forms.Button btnDEASetup;
        private System.Windows.Forms.TextBox textBox1;
    }
}

