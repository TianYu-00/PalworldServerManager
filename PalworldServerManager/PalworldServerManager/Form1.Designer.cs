
namespace PalworldServerManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_noSteam = new System.Windows.Forms.CheckBox();
            this.checkBox_log = new System.Windows.Forms.CheckBox();
            this.checkBox_useMultithreadForDS = new System.Windows.Forms.CheckBox();
            this.checkBox_noAsyncLoadingThread = new System.Windows.Forms.CheckBox();
            this.checkBox_useperfthreads = new System.Windows.Forms.CheckBox();
            this.checkBox_communityServer = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_startServer = new System.Windows.Forms.Button();
            this.button_downloadServer = new System.Windows.Forms.Button();
            this.button_downloadSteamCMD = new System.Windows.Forms.Button();
            this.panel_chilForm = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rCONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.repoPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.checkBox_noSteam);
            this.panel1.Controls.Add(this.checkBox_log);
            this.panel1.Controls.Add(this.checkBox_useMultithreadForDS);
            this.panel1.Controls.Add(this.checkBox_noAsyncLoadingThread);
            this.panel1.Controls.Add(this.checkBox_useperfthreads);
            this.panel1.Controls.Add(this.checkBox_communityServer);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_startServer);
            this.panel1.Controls.Add(this.button_downloadServer);
            this.panel1.Controls.Add(this.button_downloadSteamCMD);
            this.panel1.Name = "panel1";
            // 
            // checkBox_noSteam
            // 
            resources.ApplyResources(this.checkBox_noSteam, "checkBox_noSteam");
            this.checkBox_noSteam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_noSteam.Name = "checkBox_noSteam";
            this.checkBox_noSteam.UseVisualStyleBackColor = true;
            // 
            // checkBox_log
            // 
            resources.ApplyResources(this.checkBox_log, "checkBox_log");
            this.checkBox_log.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_log.Name = "checkBox_log";
            this.toolTip1.SetToolTip(this.checkBox_log, resources.GetString("checkBox_log.ToolTip"));
            this.checkBox_log.UseVisualStyleBackColor = true;
            // 
            // checkBox_useMultithreadForDS
            // 
            resources.ApplyResources(this.checkBox_useMultithreadForDS, "checkBox_useMultithreadForDS");
            this.checkBox_useMultithreadForDS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_useMultithreadForDS.Name = "checkBox_useMultithreadForDS";
            this.toolTip1.SetToolTip(this.checkBox_useMultithreadForDS, resources.GetString("checkBox_useMultithreadForDS.ToolTip"));
            this.checkBox_useMultithreadForDS.UseVisualStyleBackColor = true;
            // 
            // checkBox_noAsyncLoadingThread
            // 
            resources.ApplyResources(this.checkBox_noAsyncLoadingThread, "checkBox_noAsyncLoadingThread");
            this.checkBox_noAsyncLoadingThread.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_noAsyncLoadingThread.Name = "checkBox_noAsyncLoadingThread";
            this.toolTip1.SetToolTip(this.checkBox_noAsyncLoadingThread, resources.GetString("checkBox_noAsyncLoadingThread.ToolTip"));
            this.checkBox_noAsyncLoadingThread.UseVisualStyleBackColor = true;
            // 
            // checkBox_useperfthreads
            // 
            resources.ApplyResources(this.checkBox_useperfthreads, "checkBox_useperfthreads");
            this.checkBox_useperfthreads.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_useperfthreads.Name = "checkBox_useperfthreads";
            this.toolTip1.SetToolTip(this.checkBox_useperfthreads, resources.GetString("checkBox_useperfthreads.ToolTip"));
            this.checkBox_useperfthreads.UseVisualStyleBackColor = true;
            // 
            // checkBox_communityServer
            // 
            resources.ApplyResources(this.checkBox_communityServer, "checkBox_communityServer");
            this.checkBox_communityServer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_communityServer.Name = "checkBox_communityServer";
            this.toolTip1.SetToolTip(this.checkBox_communityServer, resources.GetString("checkBox_communityServer.ToolTip"));
            this.checkBox_communityServer.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.toolTip1.SetToolTip(this.button5, resources.GetString("button5.ToolTip"));
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.toolTip1.SetToolTip(this.textBox2, resources.GetString("textBox2.ToolTip"));
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.toolTip1.SetToolTip(this.button4, resources.GetString("button4.ToolTip"));
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.toolTip1.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // button_startServer
            // 
            resources.ApplyResources(this.button_startServer, "button_startServer");
            this.button_startServer.Name = "button_startServer";
            this.toolTip1.SetToolTip(this.button_startServer, resources.GetString("button_startServer.ToolTip"));
            this.button_startServer.UseVisualStyleBackColor = true;
            this.button_startServer.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_downloadServer
            // 
            resources.ApplyResources(this.button_downloadServer, "button_downloadServer");
            this.button_downloadServer.Name = "button_downloadServer";
            this.toolTip1.SetToolTip(this.button_downloadServer, resources.GetString("button_downloadServer.ToolTip"));
            this.button_downloadServer.UseVisualStyleBackColor = true;
            this.button_downloadServer.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_downloadSteamCMD
            // 
            resources.ApplyResources(this.button_downloadSteamCMD, "button_downloadSteamCMD");
            this.button_downloadSteamCMD.Name = "button_downloadSteamCMD";
            this.toolTip1.SetToolTip(this.button_downloadSteamCMD, resources.GetString("button_downloadSteamCMD.ToolTip"));
            this.button_downloadSteamCMD.UseVisualStyleBackColor = true;
            this.button_downloadSteamCMD.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_chilForm
            // 
            resources.ApplyResources(this.panel_chilForm, "panel_chilForm");
            this.panel_chilForm.Name = "panel_chilForm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverSettingsToolStripMenuItem,
            this.rCONToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.githubToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // serverSettingsToolStripMenuItem
            // 
            this.serverSettingsToolStripMenuItem.Name = "serverSettingsToolStripMenuItem";
            resources.ApplyResources(this.serverSettingsToolStripMenuItem, "serverSettingsToolStripMenuItem");
            this.serverSettingsToolStripMenuItem.Click += new System.EventHandler(this.serverSettingsToolStripMenuItem_Click);
            // 
            // rCONToolStripMenuItem
            // 
            this.rCONToolStripMenuItem.Name = "rCONToolStripMenuItem";
            resources.ApplyResources(this.rCONToolStripMenuItem, "rCONToolStripMenuItem");
            this.rCONToolStripMenuItem.Click += new System.EventHandler(this.rCONToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.githubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem1,
            this.repoPageToolStripMenuItem});
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            resources.ApplyResources(this.githubToolStripMenuItem, "githubToolStripMenuItem");
            // 
            // githubToolStripMenuItem1
            // 
            this.githubToolStripMenuItem1.Name = "githubToolStripMenuItem1";
            resources.ApplyResources(this.githubToolStripMenuItem1, "githubToolStripMenuItem1");
            this.githubToolStripMenuItem1.Click += new System.EventHandler(this.githubToolStripMenuItem1_Click);
            // 
            // repoPageToolStripMenuItem
            // 
            this.repoPageToolStripMenuItem.Name = "repoPageToolStripMenuItem";
            resources.ApplyResources(this.repoPageToolStripMenuItem, "repoPageToolStripMenuItem");
            this.repoPageToolStripMenuItem.Click += new System.EventHandler(this.repoPageToolStripMenuItem_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDirectoryToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            resources.ApplyResources(this.directoryToolStripMenuItem, "directoryToolStripMenuItem");
            // 
            // baseDirectoryToolStripMenuItem
            // 
            this.baseDirectoryToolStripMenuItem.Name = "baseDirectoryToolStripMenuItem";
            resources.ApplyResources(this.baseDirectoryToolStripMenuItem, "baseDirectoryToolStripMenuItem");
            this.baseDirectoryToolStripMenuItem.Click += new System.EventHandler(this.baseDirectoryToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.chineseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // chineseToolStripMenuItem
            // 
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            resources.ApplyResources(this.chineseToolStripMenuItem, "chineseToolStripMenuItem");
            this.chineseToolStripMenuItem.Click += new System.EventHandler(this.chineseToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            resources.ApplyResources(this.instructionToolStripMenuItem, "instructionToolStripMenuItem");
            this.instructionToolStripMenuItem.Click += new System.EventHandler(this.instructionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_chilForm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_downloadSteamCMD;
        private System.Windows.Forms.Button button_downloadServer;
        private System.Windows.Forms.Button button_startServer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel_chilForm;
        private System.Windows.Forms.CheckBox checkBox_communityServer;
        private System.Windows.Forms.CheckBox checkBox_useperfthreads;
        private System.Windows.Forms.CheckBox checkBox_useMultithreadForDS;
        private System.Windows.Forms.CheckBox checkBox_noAsyncLoadingThread;
        private System.Windows.Forms.CheckBox checkBox_log;
        private System.Windows.Forms.CheckBox checkBox_noSteam;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rCONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem repoPageToolStripMenuItem;
    }
}

