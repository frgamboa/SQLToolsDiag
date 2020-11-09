using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SSMSDiag
{
    public partial class fSQLToolsDiag : Form
    {
        string SQLToolsDiagDir = @"c:\SQLToolsDiag";
        string TempFolder = Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
        public fSQLToolsDiag()
        {
            InitializeComponent();
        }

        public void stopMarquee(string msg)
        {
            tsslStatus.Text = msg; // "SSMS Started";
            tspbProcess.MarqueeAnimationSpeed = 0;
        }
        #region SSMS
        private void btnStartSSSMSLogging_Click(object sender, EventArgs e)
        {
            tsslStatus.Text = "Starting SSMS";
            tspbProcess.MarqueeAnimationSpeed = 30;
            bwStartSSMS.RunWorkerAsync();

        }

        /*
         * Background worker to start SSMS, so the main thread will be responsive 
         */
        private void bwStartSSMS_DoWork(object sender, DoWorkEventArgs e)
        {
            
            startSSMS();
        }

        /*
         * Invokes SSMS with logging options
         */
        private void startSSMS()
        {
            string location = getSSMSLocation();
            Process.Start(location, "-log " + SQLToolsDiagDir +@"\SSMSLog.xml");
        }

        /*
         * Read the registry to get the install folder for SSMS
         */
        private string getSSMSLocation()
        {
            string ret = "";
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\SQL Server Management Studio\18.0_IsoShell_Config");
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("InstallDir");
                        if (o != null)
                        {
                            ret = (o as String);
                            ret += @"\Common7\IDE\ssms.exe";
                        }
                    }
                }
               
                key.Close();
            }
            catch (Exception ex)  
            {
                
            }
            return ret;
        }

        private void bwStartSSMS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopMarquee("SSMS Started");
        }

        private void btnCollectSSMSInstallLogs_Click(object sender, EventArgs e)
        {
            tsslStatus.Text = "Copying SSMS Setup files";
            tspbProcess.MarqueeAnimationSpeed = 30;
            bwCopyFiles.RunWorkerAsync("SSMS");
        }

        #endregion


        private void fSQLToolsDiag_Shown(object sender, EventArgs e)
        {
            //checks if the folder exists, else it creates it
            bool createDir = true;
            try
            {
                if (Directory.Exists(SQLToolsDiagDir))
                {
                    if (MessageBox.Show("There is already a folder for the data collection, would you like to replace it?", "SQLToolsDiag", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Directory.Delete(SQLToolsDiagDir, true);
                    }
                    else
                    {
                        createDir = false;
                    }
                }
                if (createDir)
                {
                    Directory.CreateDirectory(SQLToolsDiagDir);
                }
            }
            catch (Exception ex)
            {
            }
        }

        #region Copy Setup Files
        private void bwCopyFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            string folder = "";
            string fileStartsWith = "";
            switch (e.Argument)
            {
                case "SSMS":
                    folder = TempFolder + @"\ssmssetup";
                    break;
                case "SSDT":
                    folder = TempFolder + @"\SsdtSetup";
                    break;
                case "IS":
                    folder = TempFolder + @"\SsdtisSetup";
                    break;
                case "VSIX":
                    folder = TempFolder;
                    fileStartsWith = "dd_VSIXInstaller_";
                    break;
                case "SSDT15":
                    folder = TempFolder;
                    fileStartsWith = "sql_SSDT_";
                    break;
                case "DEA":
                    folder = TempFolder + @"\DEA";
                    break;
                case "DEASetup":
                    folder = TempFolder;
                    fileStartsWith = "Database_Experimentation_Assistant_";
                    break;
                case "DMA":
                    break;
                case "SSMA":
                    break;
            }
            CopySetupLogs(folder, fileStartsWith);
        }

        public void CopySetupLogs(string setupDir, string fileStartsWith)
        {
            if (fileStartsWith == "")
            {
                foreach (string dirPath in Directory.GetDirectories(setupDir, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(setupDir, SQLToolsDiagDir));
                }
                foreach (string newPath in Directory.GetFiles(setupDir, "*.*", SearchOption.TopDirectoryOnly))
                {
                    File.Copy(newPath, newPath.Replace(setupDir, SQLToolsDiagDir), true);
                }
            }
            else {
                foreach (string newPath in Directory.GetFiles(setupDir, fileStartsWith +"*.*", SearchOption.TopDirectoryOnly))
                {
                    File.Copy(newPath, newPath.Replace(setupDir, SQLToolsDiagDir), true);
                }
            }
            
        }


        private void bwCopyFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopMarquee("Files copied!");
        }

        #endregion
        #region SSDT
        private void btnCollectSSDTInstallLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("SSDT");
        }


        private void btnVSIXSetupLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("VSIX");
        }

        private void btnSSISSetupLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("IS");
        }

        private void btnSSDTSetupLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("SSDT");
        }

        private void btn2015SetupLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("SSDT15");
        }

        private void btnStartSSDTLogging_Click(object sender, EventArgs e)
        {
            string createDacFxTrace = "/C logman.exe create trace -n DacFxDebug -p \"Microsoft-SQLServerDataTools\" 0x800 -o \"" + SQLToolsDiagDir + "\\DacFxDebug.etl\" -ets";
            string createSSDTTrace = "/C logman.exe create trace -n SSDTDebug  -p \"Microsoft-SQLServerDataToolsVS\" 0x800 -o \"" + SQLToolsDiagDir + "\\SSDTDebug.etl\" -ets";
            textBox1.Text = createDacFxTrace;
            Process.Start("cmd.exe", createDacFxTrace);
            Process.Start("cmd.exe", createSSDTTrace);
        }

        private void btnStopSSDTLogging_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c Logman.exe stop DacFxDebug -ets");
            Process.Start("cmd.exe", "/c Logman.exe stop SSDTDebug -ets");
        }

        #endregion

        #region DEA
        private void btnDEASetup_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("DEASetup");
        }

        private void btnDEALogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("DEA");
        }


        #endregion

        private void fSQLToolsDiag_Load(object sender, EventArgs e)
        {

        }
    }
}


