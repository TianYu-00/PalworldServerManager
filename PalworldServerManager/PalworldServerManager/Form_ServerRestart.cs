using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalworldServerManager
{
    public partial class Form_ServerRestart : Form
    {

        private List<Tuple<CheckBox, DateTimePicker, DateTimePicker, Button>> settingsList;
        private Timer timer;

        public Form_ServerRestart()
        {
            InitializeComponent();
        }

        private void Form_ServerRestart_Load(object sender, EventArgs e)
        {
            settingsList = new List<Tuple<CheckBox, DateTimePicker, DateTimePicker, Button>>();

            // Create and configure the timer
            timer = new Timer();
            timer.Interval = 1000; // Check every second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckSettings();
        }

        private void button_addSchedule_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            DateTimePicker datePicker = new DateTimePicker();
            DateTimePicker timePicker = new DateTimePicker();
            Button deleteButton = new Button();

            // Set properties for the controls
            checkBox.Text = "Enable";
            checkBox.Dock = DockStyle.Fill;
            datePicker.Format = DateTimePickerFormat.Long;
            datePicker.ShowCheckBox = true;
            datePicker.Checked = false;
            datePicker.Dock = DockStyle.Fill;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Dock = DockStyle.Fill;
            timePicker.ShowUpDown = true;
            deleteButton.Dock= DockStyle.Fill;
            deleteButton.Text = "Delete";
            deleteButton.Click += (deleteSender, deleteArgs) => DeleteRow(deleteButton);

            // Create a new row in tableLayoutPanel1
            int rowCount = tableLayoutPanel1.RowCount;
            tableLayoutPanel1.RowCount = rowCount + 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Add controls to the tableLayoutPanel
            tableLayoutPanel1.Controls.Add(checkBox, 0, rowCount);
            tableLayoutPanel1.Controls.Add(datePicker, 1, rowCount);
            tableLayoutPanel1.Controls.Add(timePicker, 2, rowCount);
            tableLayoutPanel1.Controls.Add(deleteButton, 3, rowCount);


            // Add controls to the settings list
            settingsList.Add(new Tuple<CheckBox, DateTimePicker, DateTimePicker, Button>(checkBox, datePicker, timePicker, deleteButton));

        }

        private void DeleteRow(Button deleteButton)
        {
            // Find the corresponding tuple in settingsList based on the deleteButton
            var tupleToDelete = settingsList.Find(tuple => tuple.Item4 == deleteButton);

            if (tupleToDelete != null)
            {
                // Get the index of the tuple in settingsList
                int tupleIndex = settingsList.IndexOf(tupleToDelete);

                // Remove controls from the tableLayoutPanel
                tableLayoutPanel1.Controls.Remove(tupleToDelete.Item1);
                tableLayoutPanel1.Controls.Remove(tupleToDelete.Item2);
                tableLayoutPanel1.Controls.Remove(tupleToDelete.Item3);
                tableLayoutPanel1.Controls.Remove(tupleToDelete.Item4);

                // Remove the row from tableLayoutPanel1
                tableLayoutPanel1.RowStyles.RemoveAt(tupleIndex);
                tableLayoutPanel1.RowCount--;

                // Remove the tuple from the settingsList
                settingsList.Remove(tupleToDelete);
            }
        }


        private void CheckSettings()
        {
            //Current time
            DateTime currentDateTime = DateTime.Now;
            Debug.WriteLine($"Current Time: {currentDateTime}");
            string currentDateString = currentDateTime.ToString("yyyy/MM/dd");
            string currentTimeString = currentDateTime.ToString("HH:mm:ss");

            foreach (var setting in settingsList)
            {
                if (setting.Item1.Checked)
                {
                    // Get the index of the current tuple in settingsList
                    int rowIndex = settingsList.IndexOf(setting);

                    //Item Time
                    DateTime itemsDateTime = setting.Item2.Value.Date + setting.Item3.Value.TimeOfDay;
                    Debug.WriteLine($"ROWINDEX & Date: {rowIndex}, {itemsDateTime}");
                    string itemDateString = itemsDateTime.ToString("yyyy/MM/dd");
                    string itemTimeString = itemsDateTime.ToString("HH:mm:ss");
                    //Using time
                    string usingDate;
                    string usingTime = itemTimeString;
                    

                    //If date checkbox is checked, it will set using date as today
                    if (setting.Item2.Checked)
                    {
                        usingDate = itemDateString;
                    }
                    else
                    {
                        usingDate = currentDateString;
                    }

                    //When matched
                    if (usingDate == currentDateString && usingTime == currentTimeString)
                    {
                        MessageBox.Show("Matched");
                    }
                }
            }
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            CheckSettings();
        }

    }
}
