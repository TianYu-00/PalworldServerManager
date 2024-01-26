
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
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel_ServerSettings = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.comboBox_language);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // comboBox_language
            // 
            resources.ApplyResources(this.comboBox_language, "comboBox_language");
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            resources.GetString("comboBox_language.Items"),
            resources.GetString("comboBox_language.Items1")});
            this.comboBox_language.Name = "comboBox_language";
            this.toolTip1.SetToolTip(this.comboBox_language, resources.GetString("comboBox_language.ToolTip"));
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip"));
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, resources.GetString("pictureBox3.ToolTip"));
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox_noSteam
            // 
            resources.ApplyResources(this.checkBox_noSteam, "checkBox_noSteam");
            this.checkBox_noSteam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_noSteam.Name = "checkBox_noSteam";
            this.toolTip1.SetToolTip(this.checkBox_noSteam, resources.GetString("checkBox_noSteam.ToolTip"));
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
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
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
            // panel_ServerSettings
            // 
            resources.ApplyResources(this.panel_ServerSettings, "panel_ServerSettings");
            this.panel_ServerSettings.Name = "panel_ServerSettings";
            this.toolTip1.SetToolTip(this.panel_ServerSettings, resources.GetString("panel_ServerSettings.ToolTip"));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_ServerSettings);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel_ServerSettings;
        private System.Windows.Forms.CheckBox checkBox_communityServer;
        private System.Windows.Forms.CheckBox checkBox_useperfthreads;
        private System.Windows.Forms.CheckBox checkBox_useMultithreadForDS;
        private System.Windows.Forms.CheckBox checkBox_noAsyncLoadingThread;
        private System.Windows.Forms.CheckBox checkBox_log;
        private System.Windows.Forms.CheckBox checkBox_noSteam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox comboBox_language;
    }
}

