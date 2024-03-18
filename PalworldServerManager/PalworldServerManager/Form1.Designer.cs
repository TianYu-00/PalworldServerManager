
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new System.Windows.Forms.Panel();
            button_stopServer = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            button4 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button_startServer = new System.Windows.Forms.Button();
            button_downloadServer = new System.Windows.Forms.Button();
            button_downloadSteamCMD = new System.Windows.Forms.Button();
            panel_chilForm = new System.Windows.Forms.Panel();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            serverSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serverSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            serverRestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rCONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nexusModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            githubToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            baseDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            githubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            repoPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            discordWebhookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button_stopServer);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_startServer);
            panel1.Controls.Add(button_downloadServer);
            panel1.Controls.Add(button_downloadSteamCMD);
            panel1.Name = "panel1";
            // 
            // button_stopServer
            // 
            resources.ApplyResources(button_stopServer, "button_stopServer");
            button_stopServer.Name = "button_stopServer";
            button_stopServer.UseVisualStyleBackColor = true;
            button_stopServer.Click += button_stopServer_Click;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            toolTip1.SetToolTip(button5, resources.GetString("button5.ToolTip"));
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            toolTip1.SetToolTip(textBox2, resources.GetString("textBox2.ToolTip"));
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            toolTip1.SetToolTip(button4, resources.GetString("button4.ToolTip"));
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            toolTip1.SetToolTip(textBox1, resources.GetString("textBox1.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Name = "label1";
            // 
            // button_startServer
            // 
            resources.ApplyResources(button_startServer, "button_startServer");
            button_startServer.Name = "button_startServer";
            toolTip1.SetToolTip(button_startServer, resources.GetString("button_startServer.ToolTip"));
            button_startServer.UseVisualStyleBackColor = true;
            button_startServer.Click += button3_Click;
            // 
            // button_downloadServer
            // 
            resources.ApplyResources(button_downloadServer, "button_downloadServer");
            button_downloadServer.Name = "button_downloadServer";
            toolTip1.SetToolTip(button_downloadServer, resources.GetString("button_downloadServer.ToolTip"));
            button_downloadServer.UseVisualStyleBackColor = true;
            button_downloadServer.Click += button2_Click;
            // 
            // button_downloadSteamCMD
            // 
            resources.ApplyResources(button_downloadSteamCMD, "button_downloadSteamCMD");
            button_downloadSteamCMD.Name = "button_downloadSteamCMD";
            toolTip1.SetToolTip(button_downloadSteamCMD, resources.GetString("button_downloadSteamCMD.ToolTip"));
            button_downloadSteamCMD.UseVisualStyleBackColor = true;
            button_downloadSteamCMD.Click += button1_Click;
            // 
            // panel_chilForm
            // 
            resources.ApplyResources(panel_chilForm, "panel_chilForm");
            panel_chilForm.Name = "panel_chilForm";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { serverSettingsToolStripMenuItem, rCONToolStripMenuItem, infoToolStripMenuItem, updateToolStripMenuItem, languageToolStripMenuItem, directoryToolStripMenuItem, githubToolStripMenuItem, discordWebhookToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // serverSettingsToolStripMenuItem
            // 
            serverSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { serverSettingsToolStripMenuItem1, serverRestartToolStripMenuItem });
            serverSettingsToolStripMenuItem.Name = "serverSettingsToolStripMenuItem";
            resources.ApplyResources(serverSettingsToolStripMenuItem, "serverSettingsToolStripMenuItem");
            serverSettingsToolStripMenuItem.Click += serverSettingsToolStripMenuItem_Click;
            // 
            // serverSettingsToolStripMenuItem1
            // 
            serverSettingsToolStripMenuItem1.Name = "serverSettingsToolStripMenuItem1";
            resources.ApplyResources(serverSettingsToolStripMenuItem1, "serverSettingsToolStripMenuItem1");
            serverSettingsToolStripMenuItem1.Click += serverSettingsToolStripMenuItem1_Click;
            // 
            // serverRestartToolStripMenuItem
            // 
            serverRestartToolStripMenuItem.Name = "serverRestartToolStripMenuItem";
            resources.ApplyResources(serverRestartToolStripMenuItem, "serverRestartToolStripMenuItem");
            serverRestartToolStripMenuItem.Click += serverRestartScheduleToolStripMenuItem_Click;
            // 
            // rCONToolStripMenuItem
            // 
            rCONToolStripMenuItem.Name = "rCONToolStripMenuItem";
            resources.ApplyResources(rCONToolStripMenuItem, "rCONToolStripMenuItem");
            rCONToolStripMenuItem.Click += rCONToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { instructionToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(infoToolStripMenuItem, "infoToolStripMenuItem");
            // 
            // instructionToolStripMenuItem
            // 
            instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            resources.ApplyResources(instructionToolStripMenuItem, "instructionToolStripMenuItem");
            instructionToolStripMenuItem.Click += instructionToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { nexusModsToolStripMenuItem, githubToolStripMenuItem2 });
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            resources.ApplyResources(updateToolStripMenuItem, "updateToolStripMenuItem");
            // 
            // nexusModsToolStripMenuItem
            // 
            nexusModsToolStripMenuItem.Name = "nexusModsToolStripMenuItem";
            resources.ApplyResources(nexusModsToolStripMenuItem, "nexusModsToolStripMenuItem");
            nexusModsToolStripMenuItem.Click += nexusModsToolStripMenuItem_Click;
            // 
            // githubToolStripMenuItem2
            // 
            githubToolStripMenuItem2.Name = "githubToolStripMenuItem2";
            resources.ApplyResources(githubToolStripMenuItem2, "githubToolStripMenuItem2");
            githubToolStripMenuItem2.Click += githubToolStripMenuItem2_Click;
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { englishToolStripMenuItem, chineseToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(englishToolStripMenuItem, "englishToolStripMenuItem");
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // chineseToolStripMenuItem
            // 
            chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            resources.ApplyResources(chineseToolStripMenuItem, "chineseToolStripMenuItem");
            chineseToolStripMenuItem.Click += chineseToolStripMenuItem_Click;
            // 
            // directoryToolStripMenuItem
            // 
            directoryToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { baseDirectoryToolStripMenuItem });
            directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            resources.ApplyResources(directoryToolStripMenuItem, "directoryToolStripMenuItem");
            // 
            // baseDirectoryToolStripMenuItem
            // 
            baseDirectoryToolStripMenuItem.Name = "baseDirectoryToolStripMenuItem";
            resources.ApplyResources(baseDirectoryToolStripMenuItem, "baseDirectoryToolStripMenuItem");
            baseDirectoryToolStripMenuItem.Click += baseDirectoryToolStripMenuItem_Click;
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            githubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { githubToolStripMenuItem1, repoPageToolStripMenuItem });
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            resources.ApplyResources(githubToolStripMenuItem, "githubToolStripMenuItem");
            // 
            // githubToolStripMenuItem1
            // 
            githubToolStripMenuItem1.Name = "githubToolStripMenuItem1";
            resources.ApplyResources(githubToolStripMenuItem1, "githubToolStripMenuItem1");
            githubToolStripMenuItem1.Click += githubToolStripMenuItem1_Click;
            // 
            // repoPageToolStripMenuItem
            // 
            repoPageToolStripMenuItem.Name = "repoPageToolStripMenuItem";
            resources.ApplyResources(repoPageToolStripMenuItem, "repoPageToolStripMenuItem");
            repoPageToolStripMenuItem.Click += repoPageToolStripMenuItem_Click;
            // 
            // discordWebhookToolStripMenuItem
            // 
            discordWebhookToolStripMenuItem.Name = "discordWebhookToolStripMenuItem";
            resources.ApplyResources(discordWebhookToolStripMenuItem, "discordWebhookToolStripMenuItem");
            discordWebhookToolStripMenuItem.Click += discordWebhookToolStripMenuItem_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_chilForm);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button button_stopServer;
        private System.Windows.Forms.ToolStripMenuItem serverSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serverRestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nexusModsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem discordWebhookToolStripMenuItem;
    }
}

