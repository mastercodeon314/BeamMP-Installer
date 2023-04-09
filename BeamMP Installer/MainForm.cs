using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using DarkControls;

namespace BeamMP_Installer
{
    public partial class MainForm : Form
    {
        private string InstallLocation;

        FileDownloader launcherDownloader;
        FileDownloader clientDownloader;

        FirewallRuleChecker firewallRuleChecker;
        FirewallRuleCreator firewallRuleCreator;


        protected override CreateParams CreateParams
        {
            get
            {
                // Activate double buffering at the form level.  All child controls will be double buffered as well.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        List<TabPage> installerTabsBackup = new List<TabPage>();
        int tabIndex = 0;
        public MainForm()
        {

            InitializeComponent();

            appIcon1.DragForm = this;

            for (int i = 0; i < installerTabs.TabPages.Count; i++)
            {
                installerTabsBackup.Add(installerTabs.TabPages[i]);
            }

            tabIndex = 0;
            SetTab();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            this.closeBtn.Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, closeBtn.Width, closeBtn.Height, 10, 10));

            launcherDownloader = new FileDownloader();
            launcherDownloader.DownloadProgressChanged += LauncherDownloader_DownloadProgressChanged;
            launcherDownloader.DownloadCompleted += LauncherDownloader_DownloadCompleted;

            clientDownloader = new FileDownloader();
            clientDownloader.DownloadProgressChanged += ClientDownloader_DownloadProgressChanged;
            clientDownloader.DownloadCompleted += ClientDownloader_DownloadCompleted;

            firewallRuleCreator = new FirewallRuleCreator();
            firewallRuleCreator.RuleCreated += FirewallRuleCreator_RuleCreated;
            firewallRuleCreator.LogMessage += FirewallRuleCreator_LogMessage;
        }

        private void FirewallRuleCreator_LogMessage(object sender, string e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    firewallLogBox.Text += e + Environment.NewLine;
                    firewallLogBox.Select(firewallLogBox.Text.Length - 1, 0);
                    firewallLogBox.ScrollToCaret();
                }));
            }
        }

        private void FirewallRuleCreator_RuleCreated(object sender, bool e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<object, bool>((sendr, ee) =>
                {
                    if (ee)
                    {
                        firewallProgress.Value += 25;
                        firewallProgressLbl.Text = firewallProgress.Value.ToString() + "%";
                    }

                    if (firewallProgress.Value == 100)
                    {
                        nextInstallFinishBtn_Click(this, null);
                    }
                }), new object[] { sender, e });
            }
        }

        private void SetTab()
        {
            installerTabs.TabPages.Clear();

            installerTabs.TabPages.Add(installerTabsBackup[tabIndex]);

            installerTabs.TabPages[0].Controls.Add(nextInstallFinishBtn);

            DoInstaller();
        }

        private async void DoInstaller()
        {
            switch (tabIndex)
            {
                case 0: // Welcome/install Dir select page
                {
                    break;
                }
                case 1: // Launcher downloader page
                {
                    await launcherDownloader.DownloadFileAsync("https://backend.beammp.com/builds/launcher?download=true&pk=&branch=default", InstallLocation + @"\BeamMP-Launcher.exe");
                    nextInstallFinishBtn.Enabled = false;

                    break;
                }
                case 2: // Client mod downloader page
                {
                    string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    string modsFolderPath = Path.Combine(localAppDataPath, @"BeamNG.drive\0.28\mods");

                    if (!Directory.Exists(modsFolderPath + @"\multiplayer"))
                    {
                        Directory.CreateDirectory(modsFolderPath + @"\multiplayer");
                    }

                    await clientDownloader.DownloadFileAsync("https://backend.beammp.com/builds/client?download=true", modsFolderPath + @"\multiplayer\BeamMP.zip");
                    nextInstallFinishBtn.Enabled = false;

                    break;
                }
                case 3: // Firewall rule page
                {
                    string BeamNgPath = BeamMP_Utils.GetBeamNgPath();

                    await firewallRuleCreator.Create_Inbound_FirewallRuleAsync(InstallLocation + @"\BeamMP-Launcher.exe", "BeamMP_Launcher_Rule");
                    await firewallRuleCreator.Create_Outbound_FirewallRuleAsync(InstallLocation + @"\BeamMP-Launcher.exe", "BeamMP_Launcher_Rule");

                    await firewallRuleCreator.Create_Inbound_FirewallRuleAsync(BeamNgPath, "BeamNG_Drive_Rule");
                    await firewallRuleCreator.Create_Outbound_FirewallRuleAsync(BeamNgPath, "BeamNG_Drive_Rule");
                    
                    break;
                }
                case 4: // Finished page
                {
                    break;
                }
            }
        }

        private void LauncherDownloader_DownloadCompleted(object sender, string e)
        {
            launcherDownloader.Dispose();
            nextInstallFinishBtn_Click(this, null);
        }

        private void LauncherDownloader_DownloadProgressChanged(object sender, double[] e)
        {
            int val = (int)(e[0] * 1000);
            if (val >= launcherDL_Progress.Maximum)
            {
                launcherDL_Progress.Value = launcherDL_Progress.Maximum;
            }
            else
            {
                launcherDL_Progress.Value = val;
            }

            launcherDL_ProgressLbl.Text = launcherDL_Progress.Value.ToString() + "%";
        }

        private void ClientDownloader_DownloadCompleted(object sender, string e)
        {
            clientDownloader.Dispose();

            nextInstallFinishBtn_Click(this, null);
        }

        private void ClientDownloader_DownloadProgressChanged(object sender, double[] e)
        {
            int val = (int)(e[0] * 1000);
            if (val >= clientDL_Progress.Maximum)
            {
                clientDL_Progress.Value = clientDL_Progress.Maximum;
            }
            else
            {
                clientDL_Progress.Value = val;
            }

            clientDL_ProgressLbl.Text = clientDL_Progress.Value.ToString() + "%";
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == Utils.WM_NCHITTEST)
                m.Result = (IntPtr)(Utils.HT_CAPTION);
        }

        private void nextInstallFinishBtn_Click(object sender, EventArgs e)
        {
            if (nextInstallFinishBtn.Text == "Finish")
            {
                if (runLauncherOnExitBox.Checked)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.UseShellExecute = true;
                    startInfo.FileName = InstallLocation + @"\BeamMP-Launcher.exe";
                    Process.Start(startInfo);
                }
                this.Close();
            }

            if (nextInstallFinishBtn.Text == "Next")
            {
                nextInstallFinishBtn.Enabled = false;
                if (tabIndex + 1 == installerTabsBackup.Count)
                {
                    return;
                }

                tabIndex++;
                SetTab();

                if (tabIndex == installerTabsBackup.Count - 1)
                {
                    nextInstallFinishBtn.Text = "Finish";
                    nextInstallFinishBtn.Enabled = true;
                }
            }
        }

        private void selectInstallFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                InstallLocation = installFolderPathBox.Text = dialog.SelectedPath;
                nextInstallFinishBtn.Enabled = true;
            }
        }
    }
}
