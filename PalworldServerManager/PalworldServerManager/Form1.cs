using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalworldServerManager
{
    public partial class Form1 : Form
    {
        public string publicIP;
        public string localIP;

        // To download Palworld Server using steamcmd
        // steamcmd +login anonymous +app_update 2394010 validate +quit
        //

        private string isCommunityserver;
        private string isUseperfthreads;
        private string isNoAsyncLoadingThread;
        private string isUseMultithreadForDS;
        private string isLog;
        private string isNoSteam;

        public Form1()
        {
            LoadLanguage();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnLoad();
        }

        private void LoadLanguage()
        {
            string selectedLanguage = Properties.Settings.Default.Seleceted_Language;

            if (!string.IsNullOrEmpty(selectedLanguage))
            {
                try
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);
                }
                catch (CultureNotFoundException ex)
                {
                    //Default Language if somehow the code fails to get the language in a readable state
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                }
            }
            else
            {
                //Default Language
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
            }
        }

        private void OnLoad()
        {
            //Load Mainform values
            //publicIP = GetPublicIpAddress();
            //textBox1.Text = publicIP;
            //localIP = GetLocalAddress();
            //textBox2.Text = localIP;
            ReadStartServerArg();
            //Load Form
            Form_ServerSettings serverSettingsForm = new Form_ServerSettings();
            LoadForm(serverSettingsForm);
        }

        private void LoadForm(Form formToLoad)
        {
            //FORMNAME NEWVARIABLENAME = new FORMNAME();
            foreach (Control control in panel_chilForm.Controls)
            {
                if (control is Form form)
                {
                    //close the form
                    form.Close();
                }
            }

            if (formToLoad != null)
            {
                formToLoad.TopLevel = false;
                panel_chilForm.Controls.Add(formToLoad);
                formToLoad.FormBorderStyle = FormBorderStyle.None;
                formToLoad.Dock = DockStyle.Fill;
                formToLoad.Show();
            }
        }

        //MAIN FORM SECTION
        private string GetPublicIpAddress()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Make a request to api.ipify.org to get the public IP address
                    string response = webClient.DownloadString("https://api.ipify.org?format=json");

                    // Parse the JSON response to extract the public IP address
                    int startIndex = response.IndexOf("\"ip\":\"") + 6;
                    int endIndex = response.IndexOf("\"", startIndex);
                    string publicIpAddress = response.Substring(startIndex, endIndex - startIndex);
                    Debug.WriteLine(publicIpAddress);
                    return publicIpAddress;
                }
            }
            catch (Exception ex)
            {
                return "Error getting public IP address: " + ex.Message;
            }
        }

        private string GetLocalAddress()
        {
            try
            {
                string localIpAddress = "";
                IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress address in ip)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIpAddress = address.ToString();
                        Debug.WriteLine(localIpAddress);
                        return localIpAddress;
                    }
                }
                return localIpAddress;
            }
            catch (Exception ex)
            {
                return "Error getting local IP address: " + ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            publicIP = GetPublicIpAddress();
            textBox1.Text = publicIP;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            localIP = GetLocalAddress();
            textBox2.Text = localIP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zipUrl = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
            string fileName = "steamcmd.zip";
            string savePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            string extractPath = AppDomain.CurrentDomain.BaseDirectory;

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(zipUrl, savePath);

                    // Unzip the downloaded file
                    ZipFile.ExtractToDirectory(savePath, extractPath);

                    MessageBox.Show("Download and extraction completed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error downloading or extracting file: {ex.Message}");
                }
                finally
                {
                    // delete the downloaded .zip file after extraction
                    File.Delete(savePath);
                }
            }
        }

        private void RunDownloadServerBatchFile()
        {
            // Get the executable directory
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Specify the path for the bat file
            string batFilePath = Path.Combine(exeDirectory, "DownloadUpdateVerifyServer.bat");
            try
            {
                //Run bat file
                try
                {
                    // Create a new process to run the batch file
                    Process process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = batFilePath,
                            UseShellExecute = true,
                            CreateNoWindow = false
                        }
                    };

                    // Start the process
                    process.Start();
                    process.WaitForExit();
                    MessageBox.Show("Completed Download/Verify/Update");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error running batch file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //MessageBox.Show("Batch file generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckCMD())
            {
                return;
            }

            // Get the content from the TextBox
            string batContent = "steamcmd +login anonymous +app_update 2394010 validate +quit";

            // Get the executable directory
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Specify the path for the bat file
            string batFilePath = Path.Combine(exeDirectory, "DownloadUpdateVerifyServer.bat");

            try
            {
                // Write the content to the bat file
                File.WriteAllText(batFilePath, batContent);

                // Start a new thread to run the batch file asynchronously
                Thread thread = new Thread(new ThreadStart(RunDownloadServerBatchFile));
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunStartServerBatchFile()
        {
            // Get the executable directory
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Specify the path for the bat file
            string batFilePath = Path.Combine(exeDirectory, "RunServer.bat");
            try
            {
                // Create a new process to run the batch file
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = batFilePath,
                        UseShellExecute = true,
                        CreateNoWindow = false
                    }
                };

                // Start the process
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running batch file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckCMD()
        {
            if (File.Exists("steamcmd.exe"))
            {
                //MessageBox.Show("Steamcmd is there");
                return true;
            }
            else
            {
                MessageBox.Show("Missing steamcmd.exe \nPress download steamcmd");
                return false;
            }
        }

        private bool CheckPalServer()
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Combine the executable directory with the relative path to the INI file
            string palServerEXEPath = Path.Combine(exeDirectory, "steamapps", "common", "PalServer", "PalServer.exe");
            if (File.Exists(palServerEXEPath))
            {
                //MessageBox.Show("palServerEXEPath is there");
                return true;
            }
            else
            {
                MessageBox.Show($"Missing {palServerEXEPath} \nPress the download/update/verify server button to validate your files.");
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!CheckCMD())
            {
                return;
            }

            if (!CheckPalServer())
            {
                return;
            }

            isCommunityserver = checkBox_communityServer.Checked ? " EpicApp=PalServer" : "";
            isUseperfthreads = checkBox_useperfthreads.Checked ? " -useperfthreads" : "";
            isNoAsyncLoadingThread = checkBox_noAsyncLoadingThread.Checked ? " -NoAsyncLoadingThread" : "";
            isUseMultithreadForDS = checkBox_useMultithreadForDS.Checked ? " -UseMultithreadForDS" : "";
            isLog = checkBox_log.Checked ? " -log" : "";
            isNoSteam = checkBox_noSteam.Checked ? " -nosteam" : "";

            WriteStartServerArg();

            // Get the content from the TextBox
            string batContent = $"cd .\\steamapps\\common\\PalServer\nPalServer.exe{isCommunityserver}{isUseperfthreads}{isNoAsyncLoadingThread}{isUseMultithreadForDS}{isLog}{isNoSteam}";

            // Get the executable directory
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Specify the path for the bat file
            string batFilePath = Path.Combine(exeDirectory, "RunServer.bat");

            try
            {
                // Write the content to the bat file
                File.WriteAllText(batFilePath, batContent);

                // Start a new thread to run the batch file asynchronously
                Thread thread = new Thread(new ThreadStart(RunStartServerBatchFile));
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteStartServerArg()
        {
            using (StreamWriter sw = new StreamWriter("serverstartuppreset.txt"))
            {
                sw.WriteLine((int)checkBox_communityServer.CheckState);
                sw.WriteLine((int)checkBox_useperfthreads.CheckState);
                sw.WriteLine((int)checkBox_noAsyncLoadingThread.CheckState);
                sw.WriteLine((int)checkBox_useMultithreadForDS.CheckState);
                sw.WriteLine((int)checkBox_log.CheckState);
                sw.WriteLine((int)checkBox_noSteam.CheckState);
            }
        }

        private void ReadStartServerArg()
        {
            // Read values from the text file and set them to TextBoxes on form load
            if (File.Exists("serverstartuppreset.txt"))
            {
                using (StreamReader sr = new StreamReader("serverstartuppreset.txt"))
                {
                    checkBox_communityServer.CheckState = ParseCheckState(sr.ReadLine());
                    checkBox_useperfthreads.CheckState = ParseCheckState(sr.ReadLine());
                    checkBox_noAsyncLoadingThread.CheckState = ParseCheckState(sr.ReadLine());
                    checkBox_useMultithreadForDS.CheckState = ParseCheckState(sr.ReadLine());
                    checkBox_log.CheckState = ParseCheckState(sr.ReadLine());
                    checkBox_noSteam.CheckState = ParseCheckState(sr.ReadLine());
                }
            }
        }

        private CheckState ParseCheckState(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                // Handle null or empty string, assuming Unchecked in this case
                return CheckState.Unchecked;
            }

            return (CheckState)Enum.Parse(typeof(CheckState), value);
        }

        //TOOLSTRIPMENU SECTION
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-GB", "English"); //culture code, languagename(to let myself know what language it is)
            Application.Restart();
        }

        private void chineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("zh-Hans", "Chinese");
            Application.Restart();
        }

        private void ChangeLanguage(string cultureCode, string languageName)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
            Properties.Settings.Default.Seleceted_Language = cultureCode;
            Properties.Settings.Default.Save();
        }

        private void rCONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RCON rconForm = new Form_RCON();
            LoadForm(rconForm);
        }

        private void serverSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ServerSettings serverSettingsForm = new Form_ServerSettings();
            LoadForm(serverSettingsForm);
        }

        private void baseDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the base directory of the application
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Open the base directory using the default file explorer
                Process.Start(baseDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening base directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "Instruction";
            string message = "1)Click Download Steam CMD\n" +
                "2)Click Download/Update/Verify Server\n" +
                "3)Start the server\n" +
                "4)Let the server loadup to generate more server files\n" +
                "5)Edit any server world settings/startup settings you want\n" +
                "6)Save it\n" +
                "7)Done. LocalHostIP is 127.0.0.1\n\n" +
                "8)If you want others to join, make sure you have portforwarded your ports and added your ports to inbounrd and outbound firewall.\nCommon ports used in palworld: \n8211 ((UDP)Game Server port), \n27015 ((TCP)Steam Port), \n25575 (RCON Port).\n\nBest if you could portforward these with both UDP/TCP.";

            MessageBox.Show(message, title);
        }

        private void githubToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/Tianyu-00";

            try
            {
                Process.Start(githubUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening GitHub: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repoPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string githubRepoUrl = "https://github.com/TianYu-00/PalworldServerManager";

            try
            {
                Process.Start(githubRepoUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening GitHub: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}