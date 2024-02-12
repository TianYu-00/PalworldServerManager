namespace PalworldServerManager
{
    partial class Form_ServerRestart
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
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            checkBox1 = new System.Windows.Forms.CheckBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            button2 = new System.Windows.Forms.Button();
            button_test = new System.Windows.Forms.Button();
            button_addSchedule = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(827, 70);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 212);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(827, 521);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 3, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new System.Drawing.Size(827, 30);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBox1.Location = new System.Drawing.Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(242, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            dateTimePicker1.Location = new System.Drawing.Point(251, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(242, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePicker2.Location = new System.Drawing.Point(499, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new System.Drawing.Size(242, 23);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.Visible = false;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.Location = new System.Drawing.Point(747, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(77, 24);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // button_test
            // 
            button_test.Dock = System.Windows.Forms.DockStyle.Top;
            button_test.Location = new System.Drawing.Point(0, 130);
            button_test.Name = "button_test";
            button_test.Size = new System.Drawing.Size(827, 82);
            button_test.TabIndex = 3;
            button_test.Text = "button2";
            button_test.UseVisualStyleBackColor = true;
            button_test.Click += button_test_Click;
            // 
            // button_addSchedule
            // 
            button_addSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            button_addSchedule.Location = new System.Drawing.Point(0, 70);
            button_addSchedule.Name = "button_addSchedule";
            button_addSchedule.Size = new System.Drawing.Size(827, 60);
            button_addSchedule.TabIndex = 2;
            button_addSchedule.Text = "Add Schedule";
            button_addSchedule.UseVisualStyleBackColor = true;
            button_addSchedule.Click += button_addSchedule_Click;
            // 
            // Form_ServerRestart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(827, 733);
            Controls.Add(panel1);
            Controls.Add(button_test);
            Controls.Add(button_addSchedule);
            Controls.Add(button1);
            MinimumSize = new System.Drawing.Size(843, 39);
            Name = "Form_ServerRestart";
            Text = "Form_ServerRestart";
            Load += Form_ServerRestart_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_addSchedule;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
    }
}