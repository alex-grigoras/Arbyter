using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Arbyter
{
    public partial class MainWindow : Form
    {
        AutoCopy _autoCopy;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BrowseSourceButton_Click(object sender, EventArgs e)
        {
            FolderBrowser.Description = "Select source folder:";
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
                SourceTextBox.Text = FolderBrowser.SelectedPath;
        }

        private void BrowseDestinationButton_Click(object sender, EventArgs e)
        {
            FolderBrowser.Description = "Select destination folder:";
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
                DestinationTextBox.Text = FolderBrowser.SelectedPath;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {

            if (!ValidPaths()) return;
                
            var arbyterCopyInstance = ArbyterCoreFactory.Instance.GetArbyterCopy();
            ActionReport syncReport = arbyterCopyInstance.RunCopy(new TransferLocations(SourceTextBox.Text,
                                                                                        DestinationTextBox.Text,
                                                                                        Logging.Checked));
            if (syncReport.Result == ActionResult.Success)
            {
                MessageBox.Show(String.Format("{0} file(s) copied", syncReport.FilesAffected),
                                "Job done",
                                MessageBoxButtons.OK);
            }
            else
            {
                ErrorManager.Appologise(syncReport.Exception);
            }            
            
        }

        
        private bool ValidPaths()
        {
            if (SourceTextBox.Text.Equals("") ||
                    DestinationTextBox.Text.Equals(""))
            {
                MessageBox.Show(Resources.EmptyPathNotification,
                           "Path Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
               return false;
            }
            if (SourceTextBox.Text.Equals(DestinationTextBox.Text))
            {
                MessageBox.Show(Resources.SamePathNotification,
                           "Path Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void StartAutoCopy_Click(object sender, EventArgs e)
        {
            if(!ValidPaths()) return;

            StartAutoCopy.Enabled = false;
            CleanButton.Enabled = false;
            CopyButton.Enabled = false;

            _autoCopy = new AutoCopy(new TransferLocations(SourceTextBox.Text,
                                                                     DestinationTextBox.Text,
                                                                     Logging.Checked));
            //the timer value is in milliseconds, but the interval is in minutes
            _autoCopy.CopyInterval = (double)CopyInterval.Value * 60 * 1000;

            _autoCopy.StartIntervalCopy();

            StopAutoCopy.Enabled = true;
        }

        private void StopAutoCopy_Click(object sender, EventArgs e)
        {
            StopAutoCopy.Enabled = false;

            _autoCopy.StopIntervalCopy();

            StartAutoCopy.Enabled = true;
            CleanButton.Enabled = true;
            CopyButton.Enabled = true;
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            if (!ValidPaths()) return;

            var arbyterCleanInstance = ArbyterCoreFactory.Instance.GetArbyterClean();
            ActionReport cleanReport = arbyterCleanInstance.RunClean(new TransferLocations(SourceTextBox.Text,
                                                                                        DestinationTextBox.Text,
                                                                                        Logging.Checked));
            if (cleanReport.Result == ActionResult.Success)
            {
                MessageBox.Show(String.Format("{0} file(s) deleted", cleanReport.FilesAffected),
                                "Job done",
                                MessageBoxButtons.OK);
            }
            else
            {
                ErrorManager.Appologise(cleanReport.Exception);
            }
        }

        private void ToTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
                Hide();
                this.ToTray.Visible = true;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(Resources.ClosingString,
                                                "Bye-bye",
                                                MessageBoxButtons.YesNo);
                if (result == DialogResult.No) e.Cancel = true;
            }
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            ToTray.Icon = Resources.TrayIcon;
        }

    }
}
