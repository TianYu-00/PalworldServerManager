
namespace PalworldServerManager
{
    partial class Form_RCON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RCON));
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_commandText = new System.Windows.Forms.TextBox();
            this.button_sendCommand = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_connectRCON = new System.Windows.Forms.Button();
            this.button_disconnectRCON = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.textBox_commandText, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_sendCommand, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // textBox_commandText
            // 
            resources.ApplyResources(this.textBox_commandText, "textBox_commandText");
            this.textBox_commandText.Name = "textBox_commandText";
            // 
            // button_sendCommand
            // 
            resources.ApplyResources(this.button_sendCommand, "button_sendCommand");
            this.button_sendCommand.Name = "button_sendCommand";
            this.button_sendCommand.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_connectRCON, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_disconnectRCON, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // button_connectRCON
            // 
            resources.ApplyResources(this.button_connectRCON, "button_connectRCON");
            this.button_connectRCON.Name = "button_connectRCON";
            this.button_connectRCON.UseVisualStyleBackColor = true;
            // 
            // button_disconnectRCON
            // 
            resources.ApplyResources(this.button_disconnectRCON, "button_disconnectRCON");
            this.button_disconnectRCON.Name = "button_disconnectRCON";
            this.button_disconnectRCON.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // Form_RCON
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Form_RCON";
            this.Load += new System.EventHandler(this.Form_RCON_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_commandText;
        private System.Windows.Forms.Button button_sendCommand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_connectRCON;
        private System.Windows.Forms.Button button_disconnectRCON;
        private System.Windows.Forms.TextBox textBox3;
    }
}