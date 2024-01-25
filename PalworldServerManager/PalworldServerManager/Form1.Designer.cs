
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 138);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(601, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Show Instruction ");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(664, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Opens up base directory.");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(695, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "https://github.com/Tianyu-00");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox_noSteam
            // 
            this.checkBox_noSteam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_noSteam.AutoSize = true;
            this.checkBox_noSteam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_noSteam.Location = new System.Drawing.Point(620, 118);
            this.checkBox_noSteam.Name = "checkBox_noSteam";
            this.checkBox_noSteam.Size = new System.Drawing.Size(70, 17);
            this.checkBox_noSteam.TabIndex = 10;
            this.checkBox_noSteam.Text = "NoSteam";
            this.checkBox_noSteam.UseVisualStyleBackColor = true;
            // 
            // checkBox_log
            // 
            this.checkBox_log.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_log.AutoSize = true;
            this.checkBox_log.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_log.Location = new System.Drawing.Point(570, 118);
            this.checkBox_log.Name = "checkBox_log";
            this.checkBox_log.Size = new System.Drawing.Size(44, 17);
            this.checkBox_log.TabIndex = 9;
            this.checkBox_log.Text = "Log";
            this.toolTip1.SetToolTip(this.checkBox_log, "Create a log file to capture information about the session, including any errors " +
        "or important messages.");
            this.checkBox_log.UseVisualStyleBackColor = true;
            // 
            // checkBox_useMultithreadForDS
            // 
            this.checkBox_useMultithreadForDS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_useMultithreadForDS.AutoSize = true;
            this.checkBox_useMultithreadForDS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_useMultithreadForDS.Location = new System.Drawing.Point(437, 118);
            this.checkBox_useMultithreadForDS.Name = "checkBox_useMultithreadForDS";
            this.checkBox_useMultithreadForDS.Size = new System.Drawing.Size(127, 17);
            this.checkBox_useMultithreadForDS.TabIndex = 8;
            this.checkBox_useMultithreadForDS.Text = "UseMultithreadForDS";
            this.toolTip1.SetToolTip(this.checkBox_useMultithreadForDS, "Improves performance in multi-threaded CPU environments.\r\nIt is effective up to a" +
        " maximum of about 4 threads, and allocating more than this number of threads doe" +
        "s not make much sense.\r\n");
            this.checkBox_useMultithreadForDS.UseVisualStyleBackColor = true;
            // 
            // checkBox_noAsyncLoadingThread
            // 
            this.checkBox_noAsyncLoadingThread.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_noAsyncLoadingThread.AutoSize = true;
            this.checkBox_noAsyncLoadingThread.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_noAsyncLoadingThread.Location = new System.Drawing.Point(290, 118);
            this.checkBox_noAsyncLoadingThread.Name = "checkBox_noAsyncLoadingThread";
            this.checkBox_noAsyncLoadingThread.Size = new System.Drawing.Size(141, 17);
            this.checkBox_noAsyncLoadingThread.TabIndex = 7;
            this.checkBox_noAsyncLoadingThread.Text = "NoAsyncLoadingThread";
            this.toolTip1.SetToolTip(this.checkBox_noAsyncLoadingThread, "Improves performance in multi-threaded CPU environments.\r\nIt is effective up to a" +
        " maximum of about 4 threads, and allocating more than this number of threads doe" +
        "s not make much sense.\r\n");
            this.checkBox_noAsyncLoadingThread.UseVisualStyleBackColor = true;
            // 
            // checkBox_useperfthreads
            // 
            this.checkBox_useperfthreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_useperfthreads.AutoSize = true;
            this.checkBox_useperfthreads.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_useperfthreads.Location = new System.Drawing.Point(188, 118);
            this.checkBox_useperfthreads.Name = "checkBox_useperfthreads";
            this.checkBox_useperfthreads.Size = new System.Drawing.Size(96, 17);
            this.checkBox_useperfthreads.TabIndex = 6;
            this.checkBox_useperfthreads.Text = "useperfthreads";
            this.toolTip1.SetToolTip(this.checkBox_useperfthreads, "Improves performance in multi-threaded CPU environments.\r\nIt is effective up to a" +
        " maximum of about 4 threads, and allocating more than this number of threads doe" +
        "s not make much sense.");
            this.checkBox_useperfthreads.UseVisualStyleBackColor = true;
            // 
            // checkBox_communityServer
            // 
            this.checkBox_communityServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_communityServer.AutoSize = true;
            this.checkBox_communityServer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_communityServer.Location = new System.Drawing.Point(26, 118);
            this.checkBox_communityServer.Name = "checkBox_communityServer";
            this.checkBox_communityServer.Size = new System.Drawing.Size(156, 17);
            this.checkBox_communityServer.TabIndex = 5;
            this.checkBox_communityServer.Text = "Make As Community Server";
            this.toolTip1.SetToolTip(this.checkBox_communityServer, "Enabling this will allow your server to be in community server list.");
            this.checkBox_communityServer.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Location = new System.Drawing.Point(623, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Refresh Local IP";
            this.toolTip1.SetToolTip(this.button5, "Update your local IP");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(500, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(115, 22);
            this.textBox2.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox2, "Your Local IP");
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Location = new System.Drawing.Point(623, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refresh Public IP";
            this.toolTip1.SetToolTip(this.button4, "Update your public IP");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(500, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox1, "Your Public IP");
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palworld Server Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_startServer
            // 
            this.button_startServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_startServer.Location = new System.Drawing.Point(244, 63);
            this.button_startServer.Name = "button_startServer";
            this.button_startServer.Size = new System.Drawing.Size(250, 50);
            this.button_startServer.TabIndex = 2;
            this.button_startServer.Text = "Start Server";
            this.toolTip1.SetToolTip(this.button_startServer, "Startup the server.");
            this.button_startServer.UseVisualStyleBackColor = true;
            this.button_startServer.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_downloadServer
            // 
            this.button_downloadServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_downloadServer.Location = new System.Drawing.Point(12, 90);
            this.button_downloadServer.Name = "button_downloadServer";
            this.button_downloadServer.Size = new System.Drawing.Size(226, 23);
            this.button_downloadServer.TabIndex = 1;
            this.button_downloadServer.Text = "Download/Update/Verify Server";
            this.toolTip1.SetToolTip(this.button_downloadServer, "Download/Update/Verify your palworld server. Could be used to validate your files" +
        " if there is an issue with your server.");
            this.button_downloadServer.UseVisualStyleBackColor = true;
            this.button_downloadServer.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_downloadSteamCMD
            // 
            this.button_downloadSteamCMD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_downloadSteamCMD.Location = new System.Drawing.Point(12, 63);
            this.button_downloadSteamCMD.Name = "button_downloadSteamCMD";
            this.button_downloadSteamCMD.Size = new System.Drawing.Size(226, 23);
            this.button_downloadSteamCMD.TabIndex = 0;
            this.button_downloadSteamCMD.Text = "Download and Extract Steam CMD";
            this.toolTip1.SetToolTip(this.button_downloadSteamCMD, "Download & Extract SteamCMD from official site.");
            this.button_downloadSteamCMD.UseVisualStyleBackColor = true;
            this.button_downloadSteamCMD.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_ServerSettings
            // 
            this.panel_ServerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ServerSettings.Location = new System.Drawing.Point(0, 138);
            this.panel_ServerSettings.Name = "panel_ServerSettings";
            this.panel_ServerSettings.Size = new System.Drawing.Size(734, 573);
            this.panel_ServerSettings.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(633, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Direct to github repo.");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.panel_ServerSettings);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "Form1";
            this.Text = "Palworld Server Manager v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
    }
}

