namespace BeamMP_Installer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.installerTabs = new VisualStudioTabControl.VisualStudioTabControl();
            this.dirPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nextInstallFinishBtn = new DarkControls.Controls.DarkButton();
            this.selectInstallFolderBtn = new DarkControls.Controls.DarkButton();
            this.installFolderPathBox = new DarkControls.Controls.DarkTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dl_LauncherPage = new System.Windows.Forms.TabPage();
            this.launcherDL_ProgressLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.launcherDL_Progress = new DarkControls.Controls.ProgressBarEx();
            this.dl_ModPage = new System.Windows.Forms.TabPage();
            this.clientDL_ProgressLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientDL_Progress = new DarkControls.Controls.ProgressBarEx();
            this.firewallRulesPage = new System.Windows.Forms.TabPage();
            this.firewallLogBox = new DarkControls.Controls.DarkTextBox();
            this.firewallProgressLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firewallProgress = new DarkControls.Controls.ProgressBarEx();
            this.finishedPage = new System.Windows.Forms.TabPage();
            this.runLauncherOnExitBox = new DarkControls.Controls.DarkCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transparentLabel1 = new DarkControls.Controls.TransparentLabel();
            this.closeBtn = new DarkControls.Controls.WindowsDefaultTitleBarButton();
            this.appIcon1 = new DarkControls.Controls.AppIcon();
            this.installerTabs.SuspendLayout();
            this.dirPage.SuspendLayout();
            this.dl_LauncherPage.SuspendLayout();
            this.dl_ModPage.SuspendLayout();
            this.firewallRulesPage.SuspendLayout();
            this.finishedPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // installerTabs
            // 
            this.installerTabs.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.installerTabs.AllowDrop = true;
            this.installerTabs.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.installerTabs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.installerTabs.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.installerTabs.ClosingMessage = null;
            this.installerTabs.Controls.Add(this.dirPage);
            this.installerTabs.Controls.Add(this.dl_LauncherPage);
            this.installerTabs.Controls.Add(this.dl_ModPage);
            this.installerTabs.Controls.Add(this.firewallRulesPage);
            this.installerTabs.Controls.Add(this.finishedPage);
            this.installerTabs.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.installerTabs.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.installerTabs.ItemSize = new System.Drawing.Size(240, 16);
            this.installerTabs.Location = new System.Drawing.Point(12, 51);
            this.installerTabs.Name = "installerTabs";
            this.installerTabs.SelectedIndex = 0;
            this.installerTabs.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.installerTabs.ShowClosingButton = false;
            this.installerTabs.ShowClosingMessage = false;
            this.installerTabs.Size = new System.Drawing.Size(695, 252);
            this.installerTabs.TabIndex = 22;
            this.installerTabs.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // dirPage
            // 
            this.dirPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dirPage.Controls.Add(this.label2);
            this.dirPage.Controls.Add(this.label1);
            this.dirPage.Controls.Add(this.nextInstallFinishBtn);
            this.dirPage.Controls.Add(this.selectInstallFolderBtn);
            this.dirPage.Controls.Add(this.installFolderPathBox);
            this.dirPage.Controls.Add(this.label17);
            this.dirPage.Location = new System.Drawing.Point(4, 20);
            this.dirPage.Name = "dirPage";
            this.dirPage.Padding = new System.Windows.Forms.Padding(3);
            this.dirPage.Size = new System.Drawing.Size(687, 228);
            this.dirPage.TabIndex = 0;
            this.dirPage.Text = "Select install dir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Please select a folder to install the BeamMP Launcher too.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to the BeamMP Installer";
            // 
            // nextInstallFinishBtn
            // 
            this.nextInstallFinishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nextInstallFinishBtn.Enabled = false;
            this.nextInstallFinishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextInstallFinishBtn.ForeColor = System.Drawing.Color.Silver;
            this.nextInstallFinishBtn.Location = new System.Drawing.Point(605, 202);
            this.nextInstallFinishBtn.Name = "nextInstallFinishBtn";
            this.nextInstallFinishBtn.Size = new System.Drawing.Size(75, 23);
            this.nextInstallFinishBtn.TabIndex = 22;
            this.nextInstallFinishBtn.Text = "Next";
            this.nextInstallFinishBtn.UseVisualStyleBackColor = true;
            this.nextInstallFinishBtn.Click += new System.EventHandler(this.nextInstallFinishBtn_Click);
            // 
            // selectInstallFolderBtn
            // 
            this.selectInstallFolderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.selectInstallFolderBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectInstallFolderBtn.FlatAppearance.BorderSize = 0;
            this.selectInstallFolderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.selectInstallFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectInstallFolderBtn.ForeColor = System.Drawing.Color.Silver;
            this.selectInstallFolderBtn.Image = global::BeamMP_Installer.Properties.Resources.selectFileBtn_Image;
            this.selectInstallFolderBtn.Location = new System.Drawing.Point(6, 102);
            this.selectInstallFolderBtn.Name = "selectInstallFolderBtn";
            this.selectInstallFolderBtn.Size = new System.Drawing.Size(32, 32);
            this.selectInstallFolderBtn.TabIndex = 19;
            this.selectInstallFolderBtn.UseVisualStyleBackColor = true;
            this.selectInstallFolderBtn.Click += new System.EventHandler(this.selectInstallFolderBtn_Click);
            // 
            // installFolderPathBox
            // 
            this.installFolderPathBox.AllowDrop = true;
            this.installFolderPathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.installFolderPathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.installFolderPathBox.ForeColor = System.Drawing.Color.Silver;
            this.installFolderPathBox.Location = new System.Drawing.Point(43, 114);
            this.installFolderPathBox.Name = "installFolderPathBox";
            this.installFolderPathBox.ReadOnly = true;
            this.installFolderPathBox.Size = new System.Drawing.Size(637, 20);
            this.installFolderPathBox.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Selected install path";
            // 
            // dl_LauncherPage
            // 
            this.dl_LauncherPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dl_LauncherPage.Controls.Add(this.launcherDL_ProgressLbl);
            this.dl_LauncherPage.Controls.Add(this.label3);
            this.dl_LauncherPage.Controls.Add(this.launcherDL_Progress);
            this.dl_LauncherPage.Location = new System.Drawing.Point(4, 20);
            this.dl_LauncherPage.Name = "dl_LauncherPage";
            this.dl_LauncherPage.Padding = new System.Windows.Forms.Padding(3);
            this.dl_LauncherPage.Size = new System.Drawing.Size(687, 228);
            this.dl_LauncherPage.TabIndex = 1;
            this.dl_LauncherPage.Text = "Dowloading the launcher...";
            // 
            // launcherDL_ProgressLbl
            // 
            this.launcherDL_ProgressLbl.AutoSize = true;
            this.launcherDL_ProgressLbl.Location = new System.Drawing.Point(320, 85);
            this.launcherDL_ProgressLbl.Name = "launcherDL_ProgressLbl";
            this.launcherDL_ProgressLbl.Size = new System.Drawing.Size(21, 13);
            this.launcherDL_ProgressLbl.TabIndex = 2;
            this.launcherDL_ProgressLbl.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hang on while we download the launcher for ya,\r\nStraight from BeamMP servers. ";
            // 
            // launcherDL_Progress
            // 
            this.launcherDL_Progress.Location = new System.Drawing.Point(6, 101);
            this.launcherDL_Progress.Name = "launcherDL_Progress";
            this.launcherDL_Progress.Size = new System.Drawing.Size(675, 23);
            this.launcherDL_Progress.TabIndex = 0;
            // 
            // dl_ModPage
            // 
            this.dl_ModPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dl_ModPage.Controls.Add(this.clientDL_ProgressLbl);
            this.dl_ModPage.Controls.Add(this.label4);
            this.dl_ModPage.Controls.Add(this.clientDL_Progress);
            this.dl_ModPage.Location = new System.Drawing.Point(4, 20);
            this.dl_ModPage.Name = "dl_ModPage";
            this.dl_ModPage.Size = new System.Drawing.Size(687, 228);
            this.dl_ModPage.TabIndex = 2;
            this.dl_ModPage.Text = "Downloading the mod...";
            // 
            // clientDL_ProgressLbl
            // 
            this.clientDL_ProgressLbl.AutoSize = true;
            this.clientDL_ProgressLbl.Location = new System.Drawing.Point(320, 85);
            this.clientDL_ProgressLbl.Name = "clientDL_ProgressLbl";
            this.clientDL_ProgressLbl.Size = new System.Drawing.Size(21, 13);
            this.clientDL_ProgressLbl.TabIndex = 4;
            this.clientDL_ProgressLbl.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(580, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "One more second while we download the mod for you as well.\r\nOnce again, directly " +
    "from BeamMP servers. ";
            // 
            // clientDL_Progress
            // 
            this.clientDL_Progress.Location = new System.Drawing.Point(6, 101);
            this.clientDL_Progress.Name = "clientDL_Progress";
            this.clientDL_Progress.Size = new System.Drawing.Size(675, 16);
            this.clientDL_Progress.TabIndex = 2;
            // 
            // firewallRulesPage
            // 
            this.firewallRulesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.firewallRulesPage.Controls.Add(this.firewallLogBox);
            this.firewallRulesPage.Controls.Add(this.firewallProgressLbl);
            this.firewallRulesPage.Controls.Add(this.label5);
            this.firewallRulesPage.Controls.Add(this.firewallProgress);
            this.firewallRulesPage.Location = new System.Drawing.Point(4, 20);
            this.firewallRulesPage.Name = "firewallRulesPage";
            this.firewallRulesPage.Size = new System.Drawing.Size(687, 228);
            this.firewallRulesPage.TabIndex = 3;
            this.firewallRulesPage.Text = "Adding firewall rules";
            // 
            // firewallLogBox
            // 
            this.firewallLogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.firewallLogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firewallLogBox.ForeColor = System.Drawing.Color.Silver;
            this.firewallLogBox.Location = new System.Drawing.Point(6, 130);
            this.firewallLogBox.Multiline = true;
            this.firewallLogBox.Name = "firewallLogBox";
            this.firewallLogBox.ReadOnly = true;
            this.firewallLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.firewallLogBox.Size = new System.Drawing.Size(675, 100);
            this.firewallLogBox.TabIndex = 7;
            this.firewallLogBox.Visible = false;
            // 
            // firewallProgressLbl
            // 
            this.firewallProgressLbl.AutoSize = true;
            this.firewallProgressLbl.Location = new System.Drawing.Point(320, 85);
            this.firewallProgressLbl.Name = "firewallProgressLbl";
            this.firewallProgressLbl.Size = new System.Drawing.Size(21, 13);
            this.firewallProgressLbl.TabIndex = 6;
            this.firewallProgressLbl.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(651, 44);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last thing, we now add firewall rules in windows so that BeamNG.Drive\r\nand BeamMP" +
    " can communicate, as well as to the internet.";
            // 
            // firewallProgress
            // 
            this.firewallProgress.Location = new System.Drawing.Point(6, 101);
            this.firewallProgress.Name = "firewallProgress";
            this.firewallProgress.Size = new System.Drawing.Size(675, 23);
            this.firewallProgress.TabIndex = 4;
            // 
            // finishedPage
            // 
            this.finishedPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.finishedPage.Controls.Add(this.runLauncherOnExitBox);
            this.finishedPage.Controls.Add(this.label6);
            this.finishedPage.Location = new System.Drawing.Point(4, 20);
            this.finishedPage.Name = "finishedPage";
            this.finishedPage.Size = new System.Drawing.Size(687, 228);
            this.finishedPage.TabIndex = 4;
            this.finishedPage.Text = "We are done!";
            // 
            // runLauncherOnExitBox
            // 
            this.runLauncherOnExitBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.runLauncherOnExitBox.BoxBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.runLauncherOnExitBox.BoxFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.runLauncherOnExitBox.CheckColor = System.Drawing.Color.CornflowerBlue;
            this.runLauncherOnExitBox.FlatAppearance.BorderSize = 0;
            this.runLauncherOnExitBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runLauncherOnExitBox.Location = new System.Drawing.Point(17, 166);
            this.runLauncherOnExitBox.Name = "runLauncherOnExitBox";
            this.runLauncherOnExitBox.Size = new System.Drawing.Size(142, 24);
            this.runLauncherOnExitBox.TabIndex = 1;
            this.runLauncherOnExitBox.Text = "Run Launcher on exit";
            this.runLauncherOnExitBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.runLauncherOnExitBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(644, 120);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thats it!\r\nBeamMP is installed and properly allowed through the firewall.\r\nSimply" +
    " run the launcher and enjoy!\r\n\r\n(: Thank you for using my installer, hope it mad" +
    "e things easier :)";
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.AutoSize = true;
            this.transparentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.Location = new System.Drawing.Point(43, 15);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(134, 20);
            this.transparentLabel1.TabIndex = 8;
            this.transparentLabel1.Text = "BeamMP Installer";
            // 
            // closeBtn
            // 
            this.closeBtn.ButtonType = DarkControls.Controls.WindowsDefaultTitleBarButton.Type.Close;
            this.closeBtn.ClickColor = System.Drawing.Color.Red;
            this.closeBtn.ClickIconColor = System.Drawing.Color.Black;
            this.closeBtn.HoverColor = System.Drawing.Color.OrangeRed;
            this.closeBtn.HoverIconColor = System.Drawing.Color.Black;
            this.closeBtn.IconColor = System.Drawing.Color.Black;
            this.closeBtn.IconLineThickness = 2;
            this.closeBtn.Location = new System.Drawing.Point(679, -2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "windowsDefaultTitleBarButton1";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // appIcon1
            // 
            this.appIcon1.AppIconImage = global::BeamMP_Installer.Properties.Resources.BeamIcon100;
            this.appIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.appIcon1.DragForm = null;
            this.appIcon1.Image = ((System.Drawing.Image)(resources.GetObject("appIcon1.Image")));
            this.appIcon1.InitialImage = global::BeamMP_Installer.Properties.Resources.BeamIconFull;
            this.appIcon1.Location = new System.Drawing.Point(9, 9);
            this.appIcon1.Name = "appIcon1";
            this.appIcon1.Scale = 1.5F;
            this.appIcon1.Size = new System.Drawing.Size(28, 30);
            this.appIcon1.TabIndex = 23;
            this.appIcon1.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(719, 313);
            this.Controls.Add(this.appIcon1);
            this.Controls.Add(this.installerTabs);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.closeBtn);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "BeamMP Installer";
            this.installerTabs.ResumeLayout(false);
            this.dirPage.ResumeLayout(false);
            this.dirPage.PerformLayout();
            this.dl_LauncherPage.ResumeLayout(false);
            this.dl_LauncherPage.PerformLayout();
            this.dl_ModPage.ResumeLayout(false);
            this.dl_ModPage.PerformLayout();
            this.firewallRulesPage.ResumeLayout(false);
            this.firewallRulesPage.PerformLayout();
            this.finishedPage.ResumeLayout(false);
            this.finishedPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkControls.Controls.WindowsDefaultTitleBarButton closeBtn;
        private DarkControls.Controls.TransparentLabel transparentLabel1;
        private System.Windows.Forms.Label label1;
        private DarkControls.Controls.DarkButton selectInstallFolderBtn;
        private DarkControls.Controls.DarkTextBox installFolderPathBox;
        private System.Windows.Forms.Label label17;
        private VisualStudioTabControl.VisualStudioTabControl installerTabs;
        private System.Windows.Forms.TabPage dirPage;
        private System.Windows.Forms.Label label2;
        private DarkControls.Controls.DarkButton nextInstallFinishBtn;
        private System.Windows.Forms.TabPage dl_LauncherPage;
        private System.Windows.Forms.TabPage dl_ModPage;
        private System.Windows.Forms.Label label3;
        private DarkControls.Controls.ProgressBarEx launcherDL_Progress;
        private System.Windows.Forms.Label label4;
        private DarkControls.Controls.ProgressBarEx clientDL_Progress;
        private System.Windows.Forms.TabPage firewallRulesPage;
        private System.Windows.Forms.Label label5;
        private DarkControls.Controls.ProgressBarEx firewallProgress;
        private System.Windows.Forms.TabPage finishedPage;
        private System.Windows.Forms.Label label6;
        private DarkControls.Controls.DarkCheckBox runLauncherOnExitBox;
        private System.Windows.Forms.Label clientDL_ProgressLbl;
        private System.Windows.Forms.Label launcherDL_ProgressLbl;
        private System.Windows.Forms.Label firewallProgressLbl;
        private DarkControls.Controls.DarkTextBox firewallLogBox;
        private DarkControls.Controls.AppIcon appIcon1;
    }
}

