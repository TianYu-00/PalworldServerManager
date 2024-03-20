using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalWorld.Networking;
using static System.Net.Mime.MediaTypeNames;

namespace PalworldServerManager
{
    public partial class Form_RCON : Form
    {
        private IPersistentRconClient _rconClient;
        private IPersistentRconClient _rconClientSilent;
        string ipRCON;
        int portRCON;
        string passwordRCON;
        string selectedIGN;
        string selectedUID;
        string selectedSteamID;
        public bool isAutoUpdatePlayers = false;
        bool isSilentConnectedToRcon;
        public string playerAmount = "Null";

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
            checkBox_autoUpdatePlayerList.Checked = Properties.Settings.Default.Saved_rconAutpUpdatePlayerList;
        }

        private void button_connectRCON_Click(object sender, EventArgs e)
        {
            //Save the settings
            Properties.Settings.Default.Saved_rconIP = textBox_ipRCON.Text;
            Properties.Settings.Default.Saved_rconPort = textBox_portRCON.Text;
            Properties.Settings.Default.Saved_rconPassword = textBox_passwordRCON.Text;
            Properties.Settings.Default.Saved_rconAutpUpdatePlayerList = checkBox_autoUpdatePlayerList.Checked;
            Properties.Settings.Default.Save();

            ConnectRCON();

        }

        private async void ConnectRCON()
        {

            try
            {
                //Check for empty
                if (textBox_ipRCON.Text == "" || textBox_portRCON.Text == "" || textBox_passwordRCON.Text == "")
                {
                    richTextBox_output.AppendText("Ops, please fill in all rcon info before connecting to rcon" + Environment.NewLine);
                    return;
                }


                int newIntPort;

                if (int.TryParse(textBox_portRCON.Text, out newIntPort))
                {
                    Console.WriteLine("Parsing successful. Parsed integer value: " + newIntPort);
                }
                else
                {
                    Console.WriteLine("Parsing failed. The input string is not in a correct format.");
                }

                //Store the values
                ipRCON = textBox_ipRCON.Text;
                portRCON = newIntPort;
                passwordRCON = textBox_passwordRCON.Text;

                _rconClient = new PersistentRconClient(ipRCON, portRCON, passwordRCON);
                //_rconClient.OnDisconnected += () => richTextBox_output.AppendText($"Connection dropped" + Environment.NewLine);
                //await _rconClient.ConnectAndAuthenticate();
                if (await _rconClient.Preconnect())
                {
                    try
                    {
                        var info = await _rconClient.Packets().GetInfo();
                        richTextBox_output.AppendText($"Connected to {info?.Name} | version {info?.Version}" + Environment.NewLine);

                    }
                    catch (TimeoutException tex)
                    {
                        richTextBox_output.AppendText($"On Connect Timed out: {tex.Message}" + Environment.NewLine);
                        richTextBox_output.AppendText($"Notice: Make sure your server name only has ASCII printable characters" + Environment.NewLine);
                        return;
                    }
                    button_connectRCON.Enabled = false;
                    button_disconnectRCON.Enabled = true;
                    if (checkBox_autoUpdatePlayerList.Checked)
                    {
                        GetPlayerList();
                        timer1.Start();
                        isAutoUpdatePlayers = true;
                    }
                    else
                    {
                        isAutoUpdatePlayers = false;
                        richTextBox_output.AppendText($"Auto update player list disabled" + Environment.NewLine);
                    }

                }
                else
                {
                    richTextBox_output.AppendText("Failed to connect" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                richTextBox_output.AppendText($"Error: {ex.Message}" + Environment.NewLine);
            }
        }

        private void DisconnectRCON()
        {
            try
            {

                if (_rconClient != null)
                {
                    _rconClient.Dispose();
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

        private void SilentDisconnectRCON()
        {
            try
            {

                if (_rconClientSilent != null)
                {
                    _rconClientSilent.Dispose();
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



        private async void GetPlayerList()
        {
            if (!checkBox_autoUpdatePlayerList.Checked)
            {
                isAutoUpdatePlayers = false;
                return;
            }
            else
            {
                isAutoUpdatePlayers = true;
            }


            try
            {
                var listOfPlayers = await Task.Run(async () => await _rconClient.Send("showplayers"));
                //var listOfPlayers = await _rconClient.Send("showplayers");
                if (listOfPlayers != null)
                {
                    string processedMessage = ProcessResult(listOfPlayers);
                    //string listOfPlayers = "Player1\nPlayer2\nPlayer3\nPlayer4\nPlayer5\nPlayer6\nPlayer7\nPlayer8\nPlayer9\nPlayer10\nPlayer11\nPlayer12\nPlayer13\nPlayer14\nPlayer15\nPlayer16\nPlayer17\nPlayer18\nPlayer19\nPlayer20\nPlayer21\nPlayer22\nPlayer23\nPlayer24\nPlayer25\nPlayer26\nPlayer27\nPlayer28\nPlayer29\nPlayer30\nPlayer31\nPlayer32\n";
                    // Clear existing buttons if any
                    panel_playerListSection.Controls.Clear();
                    // Split the player list string into individual player names
                    string[] players = processedMessage.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    int tempPlayerCounter = 0;
                    // Create and add buttons for each player except the line on the list
                    for (int i = 1; i < players.Length; i++)
                    {
                        Button button = new Button();
                        button.Text = players[i];
                        button.Dock = DockStyle.Top;
                        button.Click += SelectedPlayer_Click; // Subscribe to Click event
                        panel_playerListSection.Controls.Add(button);
                        tempPlayerCounter++;

                    }
                    playerAmount = tempPlayerCounter.ToString();
                    Debug.WriteLine(playerAmount);
                }

            }
            catch (TimeoutException tex)
            {
                richTextBox_output.AppendText($"Get player list timed out: {tex.Message} \nIt's likely that the names of your server players include non-ASCII characters.'Auto Update Player List' feature has been disabled to resolve this issue." + Environment.NewLine);
                checkBox_autoUpdatePlayerList.Checked = false;
                return;

            }
            catch (Exception ex) { }



        }
        private void SelectedPlayer_Click(object sender, EventArgs e)
        {
            // Handle button click event here
            Button clickedButton = (Button)sender;
            // Split the text by commas and take the last part
            string[] parts = clickedButton.Text.Split(',');
            selectedIGN = parts[0].Trim();
            selectedUID = parts[1].Trim();
            selectedSteamID = parts[parts.Length - 1].Trim(); // Trim removes any leading or trailing spaces
            Clipboard.SetText(selectedUID);
            // Show a quick pop-up notification
            toolTip1.Show($"Copied {selectedIGN}'s UID to clipboard", clickedButton, 0, 0, 1000); // Display for 1 second
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
                    var sendCommand = await _rconClient.Send(textBox_commandText.Text);
                    string processedMessage = ProcessResult(sendCommand);
                    richTextBox_output.AppendText(processedMessage);
                    textBox_commandText.Clear();
                }
                else
                {
                    richTextBox_output.AppendText($"Not Connecetd To RCON" + Environment.NewLine);
                }
            }
            catch (TimeoutException tex)
            {
                richTextBox_output.AppendText($"Send command timed out: {tex.Message}" + Environment.NewLine);
                return;

            }
            catch (PalWorld.Networking.RconNetworkException palex)
            {
                richTextBox_output.AppendText($"RconNetworkException: {palex.Message}" + Environment.NewLine);
            }
            catch (Exception ex) { }


        }

        private async void button_kick_Click(object sender, EventArgs e)
        {

            if (selectedSteamID != null && _rconClient != null)
            {
                try
                {
                    DialogResult confirmation = MessageBox.Show($"KICK\n Player: {selectedIGN} UID:{selectedUID} SteamID: {selectedSteamID}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        var kickPlayer = await _rconClient.SendKickPlayer(selectedUID);
                        richTextBox_output.AppendText($"KICKED Player: {selectedIGN} UID:{selectedUID} SteamID: {selectedSteamID} " + Environment.NewLine);

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
            if (selectedSteamID != null && _rconClient != null)
            {
                try
                {
                    DialogResult confirmation = MessageBox.Show($"BAN\n Player: {selectedIGN} UID:{selectedUID} SteamID: {selectedSteamID}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        var banPlayer = await _rconClient.SendBanPlayer(selectedUID);
                        richTextBox_output.AppendText($"BANNED Player: {selectedIGN} UID:{selectedUID} SteamID: {selectedSteamID} " + Environment.NewLine);
                    }

                }
                catch (Exception ex)
                {
                    richTextBox_output.AppendText($"Error: {ex.Message}" + Environment.NewLine);
                }
            }
        }

        private void button_disconnectRCON_Click(object sender, EventArgs e)
        {

            DisconnectRCON();
            timer1.Stop(); // Stop the loop timer


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //GetPlayerList has 1 packet PERFECT in this case, itll also update my player list! AWSOME!
                GetPlayerList();
            }
            catch (SocketException sex)
            {
                //ReConnectRCON(ipRCON, portRCON, passwordRCON);
                //richTextBox_output.AppendText("Reconnected" + Environment.NewLine);
                richTextBox_output.AppendText("Connection dropped, please disconnect and reconnect RCON" + Environment.NewLine);
            }
            catch (Exception ex) { }

        }

        private string ProcessResult(object result)
        {
            // Convert result to string if necessary
            string resultString = result.ToString();

            // Define the prefix to remove
            string prefixToRemove = "RconPacket: 0 - ServerResponseValue(0) - ";

            // Find the index of the prefix in the string
            int prefixIndex = resultString.IndexOf(prefixToRemove);

            // Check if the prefix is found
            if (prefixIndex >= 0)
            {
                // Extract the actual message
                string actualMessage = resultString.Substring(prefixIndex + prefixToRemove.Length);

                // Trim leading and trailing whitespace
                actualMessage = actualMessage.Trim();

                // Remove surrounding double quotes
                if (actualMessage.StartsWith("\"") && actualMessage.EndsWith("\""))
                {
                    actualMessage = actualMessage.Substring(1, actualMessage.Length - 2);
                }

                return actualMessage;
            }
            else
            {
                // If prefix is not found, just return the entire result
                return resultString;
            }
        }

        public async void RCONAlert(string text)
        {

            if (isSilentConnectedToRcon)
            {
                try
                {
                    var sendAlert = await _rconClientSilent.SendBroadcast(text);
                }
                catch (Exception ex)
                {
                    richTextBox_output.AppendText($"RCON ALERT Error: {ex.Message}" + Environment.NewLine);
                }


            }
            else
            {
                try
                {
                    //Check for empty
                    if (textBox_ipRCON.Text == "" || textBox_portRCON.Text == "" || textBox_passwordRCON.Text == "")
                    {
                        richTextBox_output.AppendText("RCON ALERT: Ops, please fill in all rcon info before connecting to rcon" + Environment.NewLine);
                        return;
                    }


                    int newIntPort;

                    if (int.TryParse(textBox_portRCON.Text, out newIntPort))
                    {
                        //Console.WriteLine("Parsing successful. Parsed integer value: " + newIntPort);
                    }
                    else
                    {
                        //Console.WriteLine("Parsing failed. The input string is not in a correct format.");
                    }

                    //Store the values
                    ipRCON = textBox_ipRCON.Text;
                    portRCON = newIntPort;
                    passwordRCON = textBox_passwordRCON.Text;

                    _rconClientSilent = new PersistentRconClient(ipRCON, portRCON, passwordRCON);
                    //_rconClient.OnDisconnected += () => richTextBox_output.AppendText($"Connection dropped" + Environment.NewLine);
                    //await _rconClient.ConnectAndAuthenticate();
                    if (await _rconClientSilent.Preconnect())
                    {
                        try
                        {
                            var sendAlert = await _rconClientSilent.SendBroadcast(text);
                            isSilentConnectedToRcon = true;

                        }
                        catch (TimeoutException tex)
                        {
                            richTextBox_output.AppendText($"RCON ALERT On Connect Timed out: {tex.Message}" + Environment.NewLine);
                            richTextBox_output.AppendText($"RCON ALERT Notice: Make sure your server name only has ASCII printable characters" + Environment.NewLine);
                            return;
                        }

                    }
                    else
                    {
                        richTextBox_output.AppendText("RCON ALERT: Failed to connect" + Environment.NewLine);
                    }

                }
                catch (Exception ex)
                {
                    richTextBox_output.AppendText($"RCON ALERT Error: {ex.Message}" + Environment.NewLine);
                }
            }
        }


        private void button_test_Click(object sender, EventArgs e)
        {
            //Save the settings
            Properties.Settings.Default.Saved_rconIP = textBox_ipRCON.Text;
            Properties.Settings.Default.Saved_rconPort = textBox_portRCON.Text;
            Properties.Settings.Default.Saved_rconPassword = textBox_passwordRCON.Text;
            Properties.Settings.Default.Saved_rconAutpUpdatePlayerList = checkBox_autoUpdatePlayerList.Checked;
            Properties.Settings.Default.Save();
            richTextBox_output.AppendText($"RCON Settings Saved" + Environment.NewLine);
        }

        private void button_banListTxt_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string FilePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "SaveGames", "banlist.txt");
            try
            {
                Process.Start(new ProcessStartInfo { FileName = FilePath, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                richTextBox_output.AppendText($"Open file directory given catched Error: {ex.Message}");
            }

        }
    }
}