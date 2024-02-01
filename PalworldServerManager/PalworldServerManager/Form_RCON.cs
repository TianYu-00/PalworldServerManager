using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RconSharp;
using static System.Net.Mime.MediaTypeNames;

namespace PalworldServerManager
{
    public partial class Form_RCON : Form
    {
        private RconClient _rconClient;
        string ipRCON;
        int portRCON;
        string passwordRCON;
        string selectedIGN;
        string selectedSteamID;

        public Form_RCON()

        {
            InitializeComponent();
            // Set the selection alignment to vertical
        }

        private void Form_RCON_Load(object sender, EventArgs e)
        {
            OnLoad();
            button_connectRCON.Enabled = true;
            button_disconnectRCON.Enabled = false;
            richTextBox_output.TextChanged += richTextBoxOutput_TextChanged;
        }

        private void richTextBoxOutput_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox_output.SelectionStart = richTextBox_output.Text.Length;
            // scroll it automatically
            richTextBox_output.ScrollToCaret();
        }

        private void OnLoad()
        { 
            textBox_ipRCON.Text = Properties.Settings.Default.Saved_rconIP;
            textBox_portRCON.Text = Properties.Settings.Default.Saved_rconPort;
            textBox_passwordRCON.Text = Properties.Settings.Default.Saved_rconPassword;
        }

        private async void ConnectRCON(string ipRcon, int portRcon, string passwordRcon)
        {

            try
            {
                // Open the connection
                _rconClient.ConnectAsync();
                // Send a RCON packet with type AUTH and the RCON password for the target server
                var authenticated = await _rconClient.AuthenticateAsync(passwordRCON);
                richTextBox_output.AppendText("Validating Password..." + Environment.NewLine);
                if (authenticated)
                {
                    string info = await _rconClient.ExecuteCommandAsync("info");
                    richTextBox_output.AppendText(info + Environment.NewLine);
                    GetPlayerList();
                    button_connectRCON.Enabled = false;
                    button_disconnectRCON.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    richTextBox_output.AppendText("Incorrect Password" + Environment.NewLine);
                }
            }
            catch (Exception ex) { richTextBox_output.AppendText($"Error: {ex.Message}" + Environment.NewLine); }


        }
        
        private async void ReConnectRCON(string ipRcon, int portRcon, string passwordRcon)
        {

            try
            {
                // Open the connection
                _rconClient.ConnectAsync();
                // Send a RCON packet with type AUTH and the RCON password for the target server
                var authenticated = await _rconClient.AuthenticateAsync(passwordRCON);
                if (authenticated)
                {
                    GetPlayerList();
                    button_connectRCON.Enabled = false;
                    button_disconnectRCON.Enabled = true;
                    //richTextBox_output.AppendText("Reconnected" + Environment.NewLine);
                }
                else
                {
                    richTextBox_output.AppendText("Reconnect Incorrect Password" + Environment.NewLine);
                }
            }
            catch (Exception ex) { richTextBox_output.AppendText($"Error: {ex.Message}" + Environment.NewLine); }


        }

        private async void DisconnectRCON()
        {
            try
            {

                if (_rconClient != null)
                {
                    _rconClient.Disconnect();
                    richTextBox_output.AppendText($"Disconnected" + Environment.NewLine);
                    button_connectRCON.Enabled = true;
                    button_disconnectRCON.Enabled = false;
                }
                else
                {
                    richTextBox_output.AppendText($"Not Connecetd To RCON" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox_output.AppendText($"Error: {ex.Message}" + Environment.NewLine);
            }
        }

        private async void button_connectRCON_Click(object sender, EventArgs e)
        {
            //Save the settings
            Properties.Settings.Default.Saved_rconIP = textBox_ipRCON.Text;
            Properties.Settings.Default.Saved_rconPort = textBox_portRCON.Text;
            Properties.Settings.Default.Saved_rconPassword = textBox_passwordRCON.Text;
            Properties.Settings.Default.Save();
            //Check for empty
            if (textBox_ipRCON.Text == "" || textBox_portRCON.Text == "" || textBox_passwordRCON.Text == "")
            {
                richTextBox_output.AppendText("Ops, please fill in all rcon info before connecting to rcon" + Environment.NewLine);
                return;
            }


            int newIntPort;

            if (int.TryParse(textBox_portRCON.Text, out newIntPort))
            {
                // Parsing successful, newMaxBackupInt now holds the parsed integer value
                Console.WriteLine("Parsing successful. Parsed integer value: " + newIntPort);
            }
            else
            {
                // Parsing failed, serv_maxBackup does not contain a valid integer format
                Console.WriteLine("Parsing failed. The input string is not in a correct format.");
            }

            //Store the values
            ipRCON = textBox_ipRCON.Text;
            portRCON = newIntPort;
            passwordRCON = textBox_passwordRCON.Text;
            _rconClient = RconClient.Create(ipRCON, portRCON);
            ConnectRCON(ipRCON, portRCON, passwordRCON);
            




        }

        private async void GetPlayerList()
        {
            try
            {
                string listOfPlayers = await _rconClient.ExecuteCommandAsync("showplayers");
                //string listOfPlayers = "Player1\nPlayer2\nPlayer3\nPlayer4\nPlayer5\nPlayer6\nPlayer7\nPlayer8\nPlayer9\nPlayer10\nPlayer11\nPlayer12\nPlayer13\nPlayer14\nPlayer15\nPlayer16\nPlayer17\nPlayer18\nPlayer19\nPlayer20\nPlayer21\nPlayer22\nPlayer23\nPlayer24\nPlayer25\nPlayer26\nPlayer27\nPlayer28\nPlayer29\nPlayer30\nPlayer31\nPlayer32\n";
                // Clear existing buttons if any
                panel_playerListSection.Controls.Clear();
                // Split the player list string into individual player names
                string[] players = listOfPlayers.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Create and add buttons for each player except the line on the list
                for (int i = 1; i < players.Length; i++)
                {
                    Button button = new Button();
                    button.Text = players[i];
                    button.Dock = DockStyle.Top;
                    button.Click += SelectedPlayer_Click; // Subscribe to Click event
                    panel_playerListSection.Controls.Add(button);
                }
            }
            catch (Exception ex)
            { 
                //Handle error
            }
            

        }
        private void SelectedPlayer_Click(object sender, EventArgs e)
        {
            // Handle button click event here
            Button clickedButton = (Button)sender;
            // Split the text by commas and take the last part
            string[] parts = clickedButton.Text.Split(',');
            selectedIGN = parts[0].Trim();
            selectedSteamID = parts[parts.Length - 1].Trim(); // Trim removes any leading or trailing spaces
            Clipboard.SetText(selectedSteamID);
            // Show a quick pop-up notification
            toolTip1.Show($"Copied {selectedIGN}'s SteamID to clipboard", clickedButton, 0, 0, 1000); // Display for 1 second
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Test Button
            GetPlayerList();
        }


        private async void button_sendCommand_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rconClient != null)
                {
                    var sendCommand = await _rconClient.ExecuteCommandAsync(textBox_commandText.Text);
                    richTextBox_output.AppendText(sendCommand.ToString() + Environment.NewLine);
                    textBox_commandText.Clear();
                }
                else
                {
                    richTextBox_output.AppendText($"Not Connecetd To RCON" + Environment.NewLine);
                }
            }
            catch (Exception ex) { }


        }

        private async void button_kick_Click(object sender, EventArgs e)
        {

            if (selectedSteamID != null)
            {
                try
                {
                    DialogResult confirmation = MessageBox.Show($"KICK\n Player: {selectedIGN} SteamID: {selectedSteamID}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        string kickPlayer = await _rconClient.ExecuteCommandAsync($"KickPlayer {selectedSteamID}");
                        richTextBox_output.AppendText($"KICKED Player: {selectedIGN} SteamID: {selectedSteamID} " + Environment.NewLine);

                    }

                }
                catch (Exception ex)
                {
                    //Error handling //Do it later
                    richTextBox_output.AppendText($"Error: {ex.Message}" + Environment.NewLine);
                }
            }
        }

        private async void button_ban_Click(object sender, EventArgs e)
        {
            if (selectedSteamID != null)
            {
                try
                {
                    DialogResult confirmation = MessageBox.Show($"BAN\n Player: {selectedIGN} SteamID: {selectedSteamID}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        string banPlayer = await _rconClient.ExecuteCommandAsync($"KickPlayer {selectedSteamID}");
                        richTextBox_output.AppendText($"BANNED Player: {selectedIGN} SteamID: {selectedSteamID} " + Environment.NewLine);
                    }

                }
                catch (Exception ex)
                {
                    //Error handling //Do it later
                    richTextBox_output.AppendText($"Error: {ex.Message}" + Environment.NewLine);
                }
            }
        }

        private void button_disconnectRCON_Click(object sender, EventArgs e)
        {

            DisconnectRCON();
            timer1.Stop(); // Stop the loop reconnect timer


        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ////Send 1 packet to keep it active
                //string info = await _rconClient.ExecuteCommandAsync("info");
                //richTextBox_output.AppendText(info + Environment.NewLine);

                //GetPlayerList has 1 packet PERFECT in this case, itll also update my player list! AWSOME!
                GetPlayerList();
            }
            catch (SocketException sex) { 
                ReConnectRCON(ipRCON, portRCON, passwordRCON);
                richTextBox_output.AppendText("Reconnected" + Environment.NewLine);
            }
            catch (Exception ex) { }
            
        }
    }
}