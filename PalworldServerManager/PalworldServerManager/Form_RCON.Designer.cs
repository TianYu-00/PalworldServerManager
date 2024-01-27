
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
            panel1 = new System.Windows.Forms.Panel();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            textBox_commandText = new System.Windows.Forms.TextBox();
            button_sendCommand = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button_connectRCON = new System.Windows.Forms.Button();
            button_disconnectRCON = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel3);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(textBox_commandText, 0, 0);
            tableLayoutPanel2.Controls.Add(button_sendCommand, 1, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // textBox_commandText
            // 
            resources.ApplyResources(textBox_commandText, "textBox_commandText");
            textBox_commandText.Name = "textBox_commandText";
            // 
            // button_sendCommand
            // 
            resources.ApplyResources(button_sendCommand, "button_sendCommand");
            button_sendCommand.Name = "button_sendCommand";
            button_sendCommand.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel3.Controls.Add(button_connectRCON, 0, 0);
            tableLayoutPanel3.Controls.Add(button_disconnectRCON, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // button_connectRCON
            // 
            resources.ApplyResources(button_connectRCON, "button_connectRCON");
            button_connectRCON.Name = "button_connectRCON";
            button_connectRCON.UseVisualStyleBackColor = true;
            // 
            // button_disconnectRCON
            // 
            resources.ApplyResources(button_disconnectRCON, "button_disconnectRCON");
            button_disconnectRCON.Name = "button_disconnectRCON";
            button_disconnectRCON.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // Form_RCON
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Form_RCON";
            Load += Form_RCON_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
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