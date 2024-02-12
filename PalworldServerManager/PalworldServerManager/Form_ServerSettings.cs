using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalworldServerManager
{
    public partial class Form_ServerSettings : Form
    {
        //
        //Palworld World Server Settings Parameter Description
        //

        private Form1 mainForm;

        private const string serverSettingsFileName = "ServerSettingsPreset.json";
        private string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;


        // BACKUP INTERVAL
        private bool forceBackup = false;
        private string serv_backupInterval;
        private string serv_maxBackup;
        private string serv_backupToDirectory;

        private string serv_autoRestartEvery;


        //Difficulty Adjusts the overall difficulty of the game.
        private string serv_difficulty;

        //DayTimeSpeedRate    Modifies the speed of in-game time during the day.
        private string serv_dayTimeSpeedRate;

        //NightTimeSpeedRate Modifies the speed of in-game time during the night.
        private string serv_nightTimeSpeedRate;

        //ExpRate Changes the experience gain rate for both players and creatures.
        private string serv_expRate;

        //PalCaptureRate Adjusts the rate at which Pal creatures can be captured.
        private string serv_palCaptureRate;

        //PalSpawnNumRate Adjusts the rate at which Pal creatures spawn.
        private string serv_palSpawnNumRate;

        //PalDamageRateAttack Fine-tunes Pal creature damage dealt.
        private string serv_palDamageRateAttack;

        //PalDamageRateDefense Fine-tunes Pal creature damage received.
        private string serv_palDamageRateDefense;

        //PlayerDamageRateAttack Fine-tunes player damage dealt.
        private string serv_playerDamageRateAttack;

        //PlayerDamageRateDefense Fine-tunes player damage received.
        private string serv_playerDamageRateDefense;

        //PlayerStomachDecreaseRate Adjusts the rate at which the player's stomach decreases.
        private string serv_playerStomachDecreaseRate;

        //PlayerStaminaDecreaseRate Adjusts the rate at which the player's stamina decreases.
        private string serv_playerStaminaDecreaseRate;

        //PlayerAutoHPRegeneRate Adjusts the rate of automatic player health regeneration.
        private string serv_playerAutoHpRegenRate;

        //PlayerAutoHpRegeneRateInSleep Adjusts the rate of automatic player health regeneration during sleep.
        private string serv_playerAutoHpRegenRateInSleep;

        //PalStomachDecreaseRate Adjusts the rate at which Pal creature stomach decreases.
        private string serv_palStomachDecreaseRate;

        //PalStaminaDecreaseRate Adjusts the rate at which Pal creature stamina decreases.
        private string serv_palStaminaDecreaseRate;

        //PalAutoHPRegeneRate Adjusts the rate of automatic Pal creature health regeneration.
        private string serv_palAutoHpRegeneRate;

        //PalAutoHpRegeneRateInSleep Adjusts the rate of automatic Pal creature health regeneration during sleep.
        private string serv_palAutoHpRegeneRateInSleep;

        //BuildObjectDamageRate Adjusts the rate at which built objects take damage.
        private string serv_buildObjectDamageRate;

        //BuildObjectDeteriorationDamageRate Adjusts the rate at which built objects deteriorate.
        private string serv_buildObjectDeteriorationDamageRate;

        //CollectionDropRate Adjusts the drop rate of collected items.
        private string serv_collectionDropRate;

        //CollectionObjectHpRate Adjusts the health of collected objects.
        private string serv_collectionObjectHpRate;

        //CollectionObjectRespawnSpeedRate Adjusts the respawn speed of collected objects.
        private string serv_collectionObjectRespawnSpeedRate;

        //EnemyDropItemRate Adjusts the drop rate of items from defeated enemies.
        private string serv_enemyDropItemRate;

        //DeathPenalty Defines the penalty upon player death (e.g., All, None).
        private string serv_deathPenalty;

        //bEnablePlayerToPlayerDamage Enables or disables player-to-player damage.
        private string serv_enablePlayerToPlayerDamage;

        //bEnableFriendlyFire Enables or disables friendly fire.
        private string serv_enableFriendlyFire;

        //bEnableInvaderEnemy Enables or disables invader enemies.
        private string serv_enableInvaderEnemy;

        //bActiveUNKO Activates or deactivates UNKO (Unidentified Nocturnal Knock-off).
        private string serv_activeUNKO;

        //bEnableAimAssistPad Enables or disables aim assist for controllers.
        private string serv_enableAimAssistPad;

        //bEnableAimAssistKeyboard Enables or disables aim assist for keyboards.
        private string serv_enableAimAssistKeyboard;

        //DropItemMaxNum Sets the maximum number of dropped items in the game.
        private string serv_dropItemMaxNum;

        //DropItemMaxNum_UNKO Sets the maximum number of dropped UNKO items in the game.
        private string serv_dropItemMaxNum_UNKO;

        //BaseCampMaxNum Sets the maximum number of base camps that can be built.
        private string serv_baseCampMaxNum;

        //BaseCampWorkerMaxNum Sets the maximum number of workers in a base camp.
        private string serv_baseCampWorkerMaxNum;

        //DropItemAliveMaxHours Sets the maximum time items remain alive after being dropped.
        private string serv_dropItemAliveMaxHours;

        //bAutoResetGuildNoOnlinePlayers Automatically resets guilds with no online players.
        private string serv_autoResetGuildNoOnlinePlayers;

        //AutoResetGuildTimeNoOnlinePlayers Sets the time after which guilds with no online players are automatically reset.
        private string serv_autoResetGuildTimeNoOnlinePlayers;

        //GuildPlayerMaxNum Sets the maximum number of players in a guild.
        private string serv_guildPlayerMaxNum;

        //PalEggDefaultHatchingTime Sets the default hatching time for Pal eggs.
        private string serv_palEggDefaultHatchingTime;

        //WorkSpeedRate Adjusts the overall work speed in the game.
        private string serv_workSpeedRate;

        //bIsMultiplay Enables or disables multiplayer mode.
        private string serv_isMultiplay;

        //bIsPvP Enables or disables player versus player (PvP) mode.
        private string serv_isPvP;

        //bCanPickupOtherGuildDeathPenaltyDrop Enables or disables the pickup of death penalty drops from other guilds.
        private string serv_canPickupOtherGuildDeathPenaltyDrop;

        //bEnableNonLoginPenalty Enables or disables non-login penalties.
        private string serv_enableNonLoginPenalty;

        //bEnableFastTravel Enables or disables fast travel.
        private string serv_enableFastTravel;

        //bIsStartLocationSelectByMap Enables or disables the selection of starting locations on the map.
        private string serv_isStartLocationSelectByMap;

        //bExistPlayerAfterLogout Enables or disables the existence of players after logout.
        private string serv_existPlayerAfterLogout;

        //bEnableDefenseOtherGuildPlayer Enables or disables the defense of other guild players.
        private string serv_enableDefenseOtherGuildPlayer;

        //CoopPlayerMaxNum Sets the maximum number of cooperative players in a session.
        private string serv_coopPlayerMaxNum;

        //ServerPlayerMaxNum Sets the maximum number of players allowed on the server.
        private string serv_serverPlayerMaxNum;

        //ServerName Sets the name of the Palworld server.
        private string serv_serverName;

        //ServerDescription Provides a description for the Palworld server.
        private string serv_serverDescription;

        //AdminPassword Sets the password for server administration.
        private string serv_adminPassword;

        //ServerPassword Sets the password for joining the Palworld server.
        private string serv_serverPassword;

        //PublicPort Sets the public port for the Palworld server.
        private string serv_publicPort;

        //PublicIP Sets the public IP address for the Palworld server.
        private string serv_publicIP;

        //RCONEnabled Enables or disables Remote Console(RCON) for server administration.
        private string serv_rconEnabled;

        //RCONPort Sets the port for Remote Console (RCON) communication.
        private string serv_rconPort;

        //Region Sets the region for the Palworld server.
        private string serv_region;

        //bUseAuth Enables or disables server authentication.
        private string serv_useAuth;

        //BanListURL Sets the URL for the server's ban list.
        private string serv_banListURL;

        /// <summary>
        /// DEFAULT SERVER WORLD SETTINGS
        /// </summary>
        /// 
        private string dserv_backupInterval = "0";
        private string dserv_maxBackup = "0";
        private string dserv_backupToDirectory;

        private string dserv_autoRestartEvery = "0";

        private string dserv_difficulty = "None";
        private string dserv_dayTimeSpeedRate = "1.000000";
        private string dserv_nightTimeSpeedRate = "1.000000";
        private string dserv_expRate = "1.000000";
        private string dserv_palCaptureRate = "1.000000";
        private string dserv_palSpawnNumRate = "1.000000";
        private string dserv_palDamageRateAttack = "1.000000";
        private string dserv_palDamageRateDefense = "1.000000";
        private string dserv_playerDamageRateAttack = "1.000000";
        private string dserv_playerDamageRateDefense = "1.000000";
        private string dserv_playerStomachDecreaseRate = "1.000000";
        private string dserv_playerStaminaDecreaseRate = "1.000000";
        private string dserv_playerAutoHpRegenRate = "1.000000";
        private string dserv_playerAutoHpRegenRateInSleep = "1.000000";
        private string dserv_palStomachDecreaseRate = "1.000000";
        private string dserv_palStaminaDecreaseRate = "1.000000";
        private string dserv_palAutoHpRegeneRate = "1.000000";
        private string dserv_palAutoHpRegeneRateInSleep = "1.000000";
        private string dserv_buildObjectDamageRate = "1.000000";
        private string dserv_buildObjectDeteriorationDamageRate = "1.000000";
        private string dserv_collectionDropRate = "1.000000";
        private string dserv_collectionObjectHpRate = "1.000000";
        private string dserv_collectionObjectRespawnSpeedRate = "1.000000";
        private string dserv_enemyDropItemRate = "1.000000";
        private string dserv_deathPenalty = "All";
        private string dserv_enablePlayerToPlayerDamage = "False";
        private string dserv_enableFriendlyFire = "False";
        private string dserv_enableInvaderEnemy = "True";
        private string dserv_activeUNKO = "False";
        private string dserv_enableAimAssistPad = "True";
        private string dserv_enableAimAssistKeyboard = "False";
        private string dserv_dropItemMaxNum = "3000";
        private string dserv_dropItemMaxNum_UNKO = "100";
        private string dserv_baseCampMaxNum = "128";
        private string dserv_baseCampWorkerMaxNum = "15";
        private string dserv_dropItemAliveMaxHours = "1.000000";
        private string dserv_autoResetGuildNoOnlinePlayers = "False";
        private string dserv_autoResetGuildTimeNoOnlinePlayers = "72.000000";
        private string dserv_guildPlayerMaxNum = "20";
        private string dserv_palEggDefaultHatchingTime = "72.000000";
        private string dserv_workSpeedRate = "1.000000";
        private string dserv_isMultiplay = "False";
        private string dserv_isPvP = "False";
        private string dserv_canPickupOtherGuildDeathPenaltyDrop = "False";
        private string dserv_enableNonLoginPenalty = "True";
        private string dserv_enableFastTravel = "True";
        private string dserv_isStartLocationSelectByMap = "True";
        private string dserv_existPlayerAfterLogout = "False";
        private string dserv_enableDefenseOtherGuildPlayer = "False";
        private string dserv_coopPlayerMaxNum = "4";
        private string dserv_serverPlayerMaxNum = "32";
        private string dserv_serverName = "PSM Default Palworld Server";
        private string dserv_serverDescription = "";
        private string dserv_adminPassword = "";
        private string dserv_serverPassword = "";
        private string dserv_publicPort = "8211";
        private string dserv_publicIP = "";
        private string dserv_rconEnabled = "False";
        private string dserv_rconPort = "25575";
        private string dserv_region = "";
        private string dserv_useAuth = "True";
        private string dserv_banListURL = "https://api.palworldgame.com/api/banlist.txt";

        public class ServerSettingsPreset
        {
            // BACKUP INTERVAL
            public string json_backupInterval { get; set; }
            public string json_maxBackup { get; set; }
            public string json_backupToDirectory { get; set; }

            public string json_autoRestartEvery { get; set; }

            public string json_difficulty { get; set; }
            public string json_dayTimeSpeedRate { get; set; }
            public string json_nightTimeSpeedRate { get; set; }
            public string json_expRate { get; set; }
            public string json_palCaptureRate { get; set; }
            public string json_palSpawnNumRate { get; set; }
            public string json_palDamageRateAttack { get; set; }
            public string json_palDamageRateDefense { get; set; }
            public string json_playerDamageRateAttack { get; set; }
            public string json_playerDamageRateDefense { get; set; }
            public string json_playerStomachDecreaseRate { get; set; }
            public string json_playerStaminaDecreaseRate { get; set; }
            public string json_playerAutoHpRegeneRate { get; set; }
            public string json_playerAutoHpRegeneRateInSleep { get; set; }
            public string json_palStomachDecreaseRate { get; set; }
            public string json_palStaminaDecreaseRate { get; set; }
            public string json_palAutoHpRegeneRate { get; set; }
            public string json_palAutoHpRegeneRateInSleep { get; set; }
            public string json_buildObjectDamageRate { get; set; }
            public string json_buildObjectDeteriorationDamageRate { get; set; }
            public string json_collectionDropRate { get; set; }
            public string json_collectionObjectHpRate { get; set; }
            public string json_collectionObjectRespawnSpeedRate { get; set; }
            public string json_enemyDropItemRate { get; set; }
            public string json_deathPenalty { get; set; }
            public string json_enablePlayerToPlayerDamage { get; set; }
            public string json_enableFriendlyFire { get; set; }
            public string json_enableInvaderEnemy { get; set; }
            public string json_activeUNKO { get; set; }
            public string json_enableAimAssistPad { get; set; }
            public string json_enableAimAssistKeyboard { get; set; }
            public string json_dropItemMaxNum { get; set; }
            public string json_dropItemMaxNum_UNKO { get; set; }
            public string json_baseCampMaxNum { get; set; }
            public string json_baseCampWorkerMaxNum { get; set; }
            public string json_dropItemAliveMaxHours { get; set; }
            public string json_autoResetGuildNoOnlinePlayers { get; set; }
            public string json_autoResetGuildTimeNoOnlinePlayers { get; set; }
            public string json_guildPlayerMaxNum { get; set; }
            public string json_palEggDefaultHatchingTime { get; set; }
            public string json_workSpeedRate { get; set; }
            public string json_isMultiplay { get; set; }
            public string json_isPvP { get; set; }
            public string json_canPickupOtherGuildDeathPenaltyDrop { get; set; }
            public string json_enableNonLoginPenalty { get; set; }
            public string json_enableFastTravel { get; set; }
            public string json_isStartLocationSelectByMap { get; set; }
            public string json_existPlayerAfterLogout { get; set; }
            public string json_enableDefenseOtherGuildPlayer { get; set; }
            public string json_coopPlayerMaxNum { get; set; }
            public string json_serverPlayerMaxNum { get; set; }
            public string json_serverName { get; set; }
            public string json_serverDescription { get; set; }
            public string json_adminPassword { get; set; }
            public string json_serverPassword { get; set; }
            public string json_publicPort { get; set; }
            public string json_publicIP { get; set; }
            public string json_rconEnabled { get; set; }
            public string json_rconPort { get; set; }
            public string json_region { get; set; }
            public string json_useAuth { get; set; }
            public string json_banListURL { get; set; }
        }


        public Form_ServerSettings(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        public void ServerSettingsOnLoad()
        {
            comboBox_rconEnabled.MouseWheel += ComboBox_MouseWheel;
            comboBox_difficulty.MouseWheel += ComboBox_MouseWheel;
            comboBox_deathPenalty.MouseWheel += ComboBox_MouseWheel;
            comboBox_enablePlayerToPlayerDamage.MouseWheel += ComboBox_MouseWheel;
            comboBox_enableFriendlyFire.MouseWheel += ComboBox_MouseWheel;
            comboBox_enableInvaderEnemy.MouseWheel += ComboBox_MouseWheel;
            comboBox_activeUNKO.MouseWheel += ComboBox_MouseWheel;
            comboBox_enableAimAssistPad.MouseWheel += ComboBox_MouseWheel;
            comboBox_enableAimAssistKeyboard.MouseWheel += ComboBox_MouseWheel;
            comboBox_autoResetGuildNoOnlinePlayers.MouseWheel += ComboBox_MouseWheel;
            comboBox_isMultiplay.MouseWheel += ComboBox_MouseWheel;
            comboBox_isPvP.MouseWheel += ComboBox_MouseWheel;
            comboBox_canPickupOtherGuildDeathPenaltyDrop.MouseWheel += ComboBox_MouseWheel;
            comboBox_enableNonLoginPenalty.MouseWheel += ComboBox_MouseWheel;
            comboBox_enableFastTravel.MouseWheel += ComboBox_MouseWheel;
            comboBox_isStartLocationSelectByMap.MouseWheel += ComboBox_MouseWheel;
            comboBox_existPlayerAfterLogout.MouseWheel += ComboBox_MouseWheel;
            comboBox_enableDefenseOtherGuildPlayer.MouseWheel += ComboBox_MouseWheel;
            comboBox_useAuth.MouseWheel += ComboBox_MouseWheel;
        }

        private void ComboBox_MouseWheel(object sender, MouseEventArgs e)
        {
            // Suppress the mouse wheel event
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void Form_ServerSettings_Load(object sender, EventArgs e)
        {
            //READ GAMEWORLDSETTINGS
            ServerSettingsOnLoad();
            CreateServerSettingsJSON();
            ReadWorldSettingsFile();
            LoadServerSettingsJSON();
            serv_backupInterval = textBox_backupInterval.Text;
            serv_backupToDirectory = textBox_backupTo.Text;
            serv_maxBackup = textBox_maxBackup.Text;
            serv_autoRestartEvery = textBox_autoRestartEvery.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult askBeforeSave = MessageBox.Show("Do you want to proceed with saving your server settings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (askBeforeSave == DialogResult.Yes)
            {
                ReadSettingControlsToVariables(); //Read All Textbox/ComboBox texts
                bool writeSuccess = WriteWorldSettingsFile(); //Write the texts into world settings ini

                if (writeSuccess)
                {
                    WriteServerSettingsJSON(); // Save the settings to a txt file to be loaded on start.
                    ReadWorldSettingsFile(); // Read the world setting ini and set it to display on my richtextbox
                    MessageBox.Show("Server & World Settings Saved");
                }
            }
            else
            {
                //Not saved
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDefaultWorldSettings();
        }

        private void ReadWorldSettingsFile()
        {
            // Get the executable directory
            // Combine the executable directory with the relative path to the INI file
            string iniFilePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");

            try
            {
                // Check if the file exists
                if (File.Exists(iniFilePath))
                {
                    // Read the content of the INI file
                    string iniContent = File.ReadAllText(iniFilePath);

                    // Display the content in the RichTextBox
                    richTextBox2.Text = iniContent;
                }
                else
                {
                    //MessageBox.Show("INI file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private bool WriteWorldSettingsFile()
        {
            // Get the executable directory
            // Combine the executable directory with the relative path to the INI file
            string iniFilePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");

            try
            {
                // Check if the file exists
                if (File.Exists(iniFilePath))
                {
                    // Read the content of the INI file
                    //string iniContent = File.ReadAllText(iniFilePath);

                    // Display the content in the RichTextBox
                    //richTextBox2.Text = iniContent;
                    string newWorldSettings = $"[/Script/Pal.PalGameWorldSettings]\n" +
                        $"OptionSettings=(Difficulty={serv_difficulty},DayTimeSpeedRate={serv_dayTimeSpeedRate},NightTimeSpeedRate={serv_nightTimeSpeedRate},ExpRate={serv_expRate},PalCaptureRate={serv_palCaptureRate},PalSpawnNumRate={serv_palSpawnNumRate},PalDamageRateAttack={serv_palDamageRateAttack},PalDamageRateDefense={serv_palDamageRateDefense},PlayerDamageRateAttack={serv_playerDamageRateAttack},PlayerDamageRateDefense={serv_playerDamageRateDefense},PlayerStomachDecreaceRate={serv_playerStomachDecreaseRate},PlayerStaminaDecreaceRate={serv_playerStaminaDecreaseRate},PlayerAutoHPRegeneRate={serv_playerAutoHpRegenRate},PlayerAutoHpRegeneRateInSleep={serv_playerAutoHpRegenRateInSleep},PalStomachDecreaceRate={serv_palStomachDecreaseRate},PalStaminaDecreaceRate={serv_palStaminaDecreaseRate},PalAutoHPRegeneRate={serv_palAutoHpRegeneRate},PalAutoHpRegeneRateInSleep={serv_palAutoHpRegeneRateInSleep},BuildObjectDamageRate={serv_buildObjectDamageRate},BuildObjectDeteriorationDamageRate={serv_buildObjectDeteriorationDamageRate},CollectionDropRate={serv_collectionDropRate},CollectionObjectHpRate={serv_collectionObjectHpRate},CollectionObjectRespawnSpeedRate={serv_collectionObjectRespawnSpeedRate},EnemyDropItemRate={serv_enemyDropItemRate},DeathPenalty={serv_deathPenalty},bEnablePlayerToPlayerDamage={serv_enablePlayerToPlayerDamage},bEnableFriendlyFire={serv_enableFriendlyFire},bEnableInvaderEnemy={serv_enableInvaderEnemy},bActiveUNKO={serv_activeUNKO},bEnableAimAssistPad={serv_enableAimAssistPad},bEnableAimAssistKeyboard={serv_enableAimAssistKeyboard},DropItemMaxNum={serv_dropItemMaxNum},DropItemMaxNum_UNKO={serv_dropItemMaxNum_UNKO},BaseCampMaxNum={serv_baseCampMaxNum},BaseCampWorkerMaxNum={serv_baseCampWorkerMaxNum},DropItemAliveMaxHours={serv_dropItemAliveMaxHours},bAutoResetGuildNoOnlinePlayers={serv_autoResetGuildNoOnlinePlayers},AutoResetGuildTimeNoOnlinePlayers={serv_autoResetGuildTimeNoOnlinePlayers},GuildPlayerMaxNum={serv_guildPlayerMaxNum},PalEggDefaultHatchingTime={serv_palEggDefaultHatchingTime},WorkSpeedRate={serv_workSpeedRate},bIsMultiplay={serv_isMultiplay},bIsPvP={serv_isPvP},bCanPickupOtherGuildDeathPenaltyDrop={serv_canPickupOtherGuildDeathPenaltyDrop},bEnableNonLoginPenalty={serv_enableNonLoginPenalty},bEnableFastTravel={serv_enableFastTravel},bIsStartLocationSelectByMap={serv_isStartLocationSelectByMap},bExistPlayerAfterLogout={serv_existPlayerAfterLogout},bEnableDefenseOtherGuildPlayer={serv_enableDefenseOtherGuildPlayer},CoopPlayerMaxNum={serv_coopPlayerMaxNum},ServerPlayerMaxNum={serv_serverPlayerMaxNum},ServerName=\"{serv_serverName}\",ServerDescription=\"{serv_serverDescription}\",AdminPassword=\"{serv_adminPassword}\",ServerPassword=\"{serv_serverPassword}\",PublicPort={serv_publicPort},PublicIP=\"{serv_publicIP}\",RCONEnabled={serv_rconEnabled},RCONPort={serv_rconPort},Region=\"{serv_region}\",bUseAuth={serv_useAuth},BanListURL=\"{serv_banListURL}\")";
                    File.WriteAllText(iniFilePath, newWorldSettings);
                    //return true to indicate success
                    return true;
                }
                else
                {
                    MessageBox.Show("INI file missing, need to run the server once in order to generate the file.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        private void LoadDefaultWorldSettings()
        {
            //Backup settings
            textBox_backupInterval.Text = dserv_backupInterval;
            textBox_maxBackup.Text = dserv_maxBackup;
            textBox_backupTo.Text = dserv_backupToDirectory;

            //Auto restart
            textBox_autoRestartEvery.Text = dserv_autoRestartEvery;

            //Server Settings
            textBox_serverName.Text = dserv_serverName;
            textBox_serverDescription.Text = dserv_serverDescription;
            textBox_serverPlayerMaxNum.Text = dserv_serverPlayerMaxNum;
            textBox_adminPassword.Text = dserv_adminPassword;
            textBox_serverPassword.Text = dserv_serverPassword;
            textBox_publicPort.Text = dserv_publicPort;
            textBox_publicIP.Text = dserv_publicIP;
            comboBox_rconEnabled.Text = dserv_rconEnabled;
            textBox_rconPort.Text = dserv_rconPort;
            comboBox_difficulty.Text = dserv_difficulty;
            textBox_dayTimeSpeedRate.Text = dserv_dayTimeSpeedRate;
            textBox_nightTimeSpeedRate.Text = dserv_nightTimeSpeedRate;
            textBox_expRate.Text = dserv_expRate;
            textBox_palCaptureRate.Text = dserv_palCaptureRate;
            textBox_palSpawnNumRate.Text = dserv_palSpawnNumRate;
            textBox_palDamageRateAttack.Text = dserv_palDamageRateAttack;
            textBox_palDamageRateDefense.Text = dserv_palDamageRateDefense;
            textBox_playerDamageRateAttack.Text = dserv_playerDamageRateAttack;
            textBox_playerDamageRateDefense.Text = dserv_playerDamageRateDefense;
            textBox_playerStomachDecreaceRate.Text = dserv_playerStomachDecreaseRate;
            textBox_playerStaminaDecreaceRate.Text = dserv_playerStaminaDecreaseRate;
            textBox_playerAutoHpRegeneRate.Text = dserv_playerAutoHpRegenRate;
            textBox_playerAutoHpRegeneRateInSleep.Text = dserv_playerAutoHpRegenRateInSleep;
            textBox_palStomachDecreaceRate.Text = dserv_palStomachDecreaseRate;
            textBox_palStaminaDecreaceRate.Text = dserv_palStaminaDecreaseRate;
            textBox_palAutoHpRegeneRate.Text = dserv_palAutoHpRegeneRate;
            textBox_palAutoHpRegeneRateInSleep.Text = dserv_palAutoHpRegeneRateInSleep;
            textBox_buildObjectDamageRate.Text = dserv_buildObjectDamageRate;
            textBox_buildObjectDeteriorationDamageRate.Text = dserv_buildObjectDeteriorationDamageRate;
            textBox_collectionDropRate.Text = dserv_collectionDropRate;
            textBox_collectionObjectHpRate.Text = dserv_collectionObjectHpRate;
            textBox_collectionObjectRespawnSpeedRate.Text = dserv_collectionObjectRespawnSpeedRate;
            textBox_enemyDropItemRate.Text = dserv_enemyDropItemRate;
            comboBox_deathPenalty.Text = dserv_deathPenalty;
            comboBox_enablePlayerToPlayerDamage.Text = dserv_enablePlayerToPlayerDamage;
            comboBox_enableFriendlyFire.Text = dserv_enableFriendlyFire;
            comboBox_enableInvaderEnemy.Text = dserv_enableInvaderEnemy;
            comboBox_activeUNKO.Text = dserv_activeUNKO;
            comboBox_enableAimAssistPad.Text = dserv_enableAimAssistPad;
            comboBox_enableAimAssistKeyboard.Text = dserv_enableAimAssistKeyboard;
            textBox_dropItemMaxNum.Text = dserv_dropItemMaxNum;
            textBox_dropItemMaxNum_UNKO.Text = dserv_dropItemMaxNum_UNKO;
            textBox_baseCampMaxNum.Text = dserv_baseCampMaxNum;
            textBox_baseCampWorkerMaxNum.Text = dserv_baseCampWorkerMaxNum;
            textBox_dropItemAliveMaxHours.Text = dserv_dropItemAliveMaxHours;
            comboBox_autoResetGuildNoOnlinePlayers.Text = dserv_autoResetGuildNoOnlinePlayers;
            textBox_autoResetGuildTimeNoOnlinePlayers.Text = dserv_autoResetGuildTimeNoOnlinePlayers;
            textBox_guildPlayerMaxNum.Text = dserv_guildPlayerMaxNum;
            textBox_palEggDefaultHatchingTime.Text = dserv_palEggDefaultHatchingTime;
            textBox_workSpeedRate.Text = dserv_workSpeedRate;
            comboBox_isMultiplay.Text = dserv_isMultiplay;
            comboBox_isPvP.Text = dserv_isPvP;
            comboBox_canPickupOtherGuildDeathPenaltyDrop.Text = dserv_canPickupOtherGuildDeathPenaltyDrop;
            comboBox_enableNonLoginPenalty.Text = dserv_enableNonLoginPenalty;
            comboBox_enableFastTravel.Text = dserv_enableFastTravel;
            comboBox_isStartLocationSelectByMap.Text = dserv_isStartLocationSelectByMap;
            comboBox_existPlayerAfterLogout.Text = dserv_existPlayerAfterLogout;
            comboBox_enableDefenseOtherGuildPlayer.Text = dserv_enableDefenseOtherGuildPlayer;
            textBox_coopPlayerMaxNum.Text = dserv_coopPlayerMaxNum;
            textBox_region.Text = dserv_region;
            comboBox_useAuth.Text = dserv_useAuth;
            textBox_banListURL.Text = dserv_banListURL;
        }

        private void ReadSettingControlsToVariables()
        {
            //Backup settings
            serv_backupInterval = textBox_backupInterval.Text;
            serv_maxBackup = textBox_maxBackup.Text;
            serv_backupToDirectory = textBox_backupTo.Text;

            //Auto restart
            serv_autoRestartEvery = textBox_autoRestartEvery.Text;

            //Server Settings
            serv_serverName = textBox_serverName.Text;
            serv_serverDescription = textBox_serverDescription.Text;
            serv_serverPlayerMaxNum = textBox_serverPlayerMaxNum.Text;
            serv_adminPassword = textBox_adminPassword.Text;
            serv_serverPassword = textBox_serverPassword.Text;
            serv_publicPort = textBox_publicPort.Text;
            serv_publicIP = textBox_publicIP.Text;
            //serv_rconEnabled = textBox_rconEnabled.Text;
            serv_rconPort = textBox_rconPort.Text;
            //serv_difficulty = textBox_difficulty.Text;
            serv_dayTimeSpeedRate = textBox_dayTimeSpeedRate.Text;
            serv_nightTimeSpeedRate = textBox_nightTimeSpeedRate.Text;
            serv_expRate = textBox_expRate.Text;
            serv_palCaptureRate = textBox_palCaptureRate.Text;
            serv_palSpawnNumRate = textBox_palSpawnNumRate.Text;
            serv_palDamageRateAttack = textBox_palDamageRateAttack.Text;
            serv_palDamageRateDefense = textBox_palDamageRateDefense.Text;
            serv_playerDamageRateAttack = textBox_playerDamageRateAttack.Text;
            serv_playerDamageRateDefense = textBox_playerDamageRateDefense.Text;
            serv_playerStomachDecreaseRate = textBox_playerStomachDecreaceRate.Text;
            serv_playerStaminaDecreaseRate = textBox_playerStaminaDecreaceRate.Text;
            serv_playerAutoHpRegenRate = textBox_playerAutoHpRegeneRate.Text;
            serv_playerAutoHpRegenRateInSleep = textBox_playerAutoHpRegeneRateInSleep.Text;
            serv_palStomachDecreaseRate = textBox_palStomachDecreaceRate.Text;
            serv_palStaminaDecreaseRate = textBox_palStaminaDecreaceRate.Text;
            serv_palAutoHpRegeneRate = textBox_palAutoHpRegeneRate.Text;
            serv_palAutoHpRegeneRateInSleep = textBox_palAutoHpRegeneRateInSleep.Text;
            serv_buildObjectDamageRate = textBox_buildObjectDamageRate.Text;
            serv_buildObjectDeteriorationDamageRate = textBox_buildObjectDeteriorationDamageRate.Text;
            serv_collectionDropRate = textBox_collectionDropRate.Text;
            serv_collectionObjectHpRate = textBox_collectionObjectHpRate.Text;
            serv_collectionObjectRespawnSpeedRate = textBox_collectionObjectRespawnSpeedRate.Text;
            serv_enemyDropItemRate = textBox_enemyDropItemRate.Text;
            //serv_deathPenalty = textBox_deathPenalty.Text;
            //serv_enablePlayerToPlayerDamage = textBox_enablePlayerToPlayerDamage.Text;
            //serv_enableFriendlyFire = textBox_enableFriendlyFire.Text;
            //serv_enableInvaderEnemy = textBox_enableInvaderEnemy.Text;
            //serv_activeUNKO = textBox_activeUNKO.Text;
            //serv_enableAimAssistPad = textBox_enableAimAssistPad.Text;
            //serv_enableAimAssistKeyboard = textBox_enableAimAssistKeyboard.Text;
            serv_dropItemMaxNum = textBox_dropItemMaxNum.Text;
            serv_dropItemMaxNum_UNKO = textBox_dropItemMaxNum_UNKO.Text;
            serv_baseCampMaxNum = textBox_baseCampMaxNum.Text;
            serv_baseCampWorkerMaxNum = textBox_baseCampWorkerMaxNum.Text;
            serv_dropItemAliveMaxHours = textBox_dropItemAliveMaxHours.Text;
            //serv_autoResetGuildNoOnlinePlayers = textBox_autoResetGuildNoOnlinePlayers.Text;
            serv_autoResetGuildTimeNoOnlinePlayers = textBox_autoResetGuildTimeNoOnlinePlayers.Text;
            serv_guildPlayerMaxNum = textBox_guildPlayerMaxNum.Text;
            serv_palEggDefaultHatchingTime = textBox_palEggDefaultHatchingTime.Text;
            serv_workSpeedRate = textBox_workSpeedRate.Text;
            //serv_isMultiplay = textBox_isMultiplay.Text;
            //serv_isPvP = textBox_isPvP.Text;
            //serv_canPickupOtherGuildDeathPenaltyDrop = textBox_canPickupOtherGuildDeathPenaltyDrop.Text;
            //serv_enableNonLoginPenalty = textBox_enableNonLoginPenalty.Text;
            //serv_enableFastTravel = textBox_enableFastTravel.Text;
            //serv_isStartLocationSelectByMap = textBox_isStartLocationSelectByMap.Text;
            //serv_existPlayerAfterLogout = textBox_existPlayerAfterLogout.Text;
            //serv_enableDefenseOtherGuildPlayer = textBox_enableDefenseOtherGuildPlayer.Text;
            serv_coopPlayerMaxNum = textBox_coopPlayerMaxNum.Text;
            serv_region = textBox_region.Text;
            //serv_useAuth = textBox_useAuth.Text;
            serv_banListURL = textBox_banListURL.Text;

            //Combo boxes
            serv_rconEnabled = comboBox_rconEnabled.Text;
            serv_difficulty = comboBox_difficulty.Text;
            serv_deathPenalty = comboBox_deathPenalty.Text;
            serv_enablePlayerToPlayerDamage = comboBox_enablePlayerToPlayerDamage.Text;
            serv_enableFriendlyFire = comboBox_enableFriendlyFire.Text;
            serv_enableInvaderEnemy = comboBox_enableInvaderEnemy.Text;
            serv_activeUNKO = comboBox_activeUNKO.Text;
            serv_enableAimAssistPad = comboBox_enableAimAssistPad.Text;
            serv_enableAimAssistKeyboard = comboBox_enableAimAssistKeyboard.Text;
            serv_autoResetGuildNoOnlinePlayers = comboBox_autoResetGuildNoOnlinePlayers.Text;
            serv_isMultiplay = comboBox_isMultiplay.Text;
            serv_isPvP = comboBox_isPvP.Text;
            serv_canPickupOtherGuildDeathPenaltyDrop = comboBox_canPickupOtherGuildDeathPenaltyDrop.Text;
            serv_enableNonLoginPenalty = comboBox_enableNonLoginPenalty.Text;
            serv_enableFastTravel = comboBox_enableFastTravel.Text;
            serv_isStartLocationSelectByMap = comboBox_isStartLocationSelectByMap.Text;
            serv_existPlayerAfterLogout = comboBox_existPlayerAfterLogout.Text;
            serv_enableDefenseOtherGuildPlayer = comboBox_enableDefenseOtherGuildPlayer.Text;
            serv_useAuth = comboBox_useAuth.Text;
        }



        private void WriteServerSettingsJSON()
        {

            // Create settings object
            var settings = new ServerSettingsPreset
            {
                //Backup settings
                json_backupInterval = textBox_backupInterval.Text,
                json_maxBackup = textBox_maxBackup.Text,
                json_backupToDirectory = textBox_backupTo.Text,

                //Auto restart
                json_autoRestartEvery = textBox_autoRestartEvery.Text,

                // Server settings
                json_serverName = textBox_serverName.Text,
                json_serverDescription = textBox_serverDescription.Text,
                json_serverPlayerMaxNum = textBox_serverPlayerMaxNum.Text,
                json_adminPassword = textBox_adminPassword.Text,
                json_serverPassword = textBox_serverPassword.Text,
                json_publicPort = textBox_publicPort.Text,
                json_publicIP = textBox_publicIP.Text,
                json_rconEnabled = comboBox_rconEnabled.Text,
                json_rconPort = textBox_rconPort.Text,
                json_difficulty = comboBox_difficulty.Text,
                json_dayTimeSpeedRate = textBox_dayTimeSpeedRate.Text,
                json_nightTimeSpeedRate = textBox_nightTimeSpeedRate.Text,
                json_expRate = textBox_expRate.Text,
                json_palCaptureRate = textBox_palCaptureRate.Text,
                json_palSpawnNumRate = textBox_palSpawnNumRate.Text,
                json_palDamageRateAttack = textBox_palDamageRateAttack.Text,
                json_palDamageRateDefense = textBox_palDamageRateDefense.Text,
                json_playerDamageRateAttack = textBox_playerDamageRateAttack.Text,
                json_playerDamageRateDefense = textBox_playerDamageRateDefense.Text,
                json_playerStomachDecreaseRate = textBox_playerStomachDecreaceRate.Text,
                json_playerStaminaDecreaseRate = textBox_playerStaminaDecreaceRate.Text,
                json_playerAutoHpRegeneRate = textBox_playerAutoHpRegeneRate.Text,
                json_playerAutoHpRegeneRateInSleep = textBox_playerAutoHpRegeneRateInSleep.Text,
                json_palStomachDecreaseRate = textBox_palStomachDecreaceRate.Text,
                json_palStaminaDecreaseRate = textBox_palStaminaDecreaceRate.Text,
                json_palAutoHpRegeneRate = textBox_palAutoHpRegeneRate.Text,
                json_palAutoHpRegeneRateInSleep = textBox_palAutoHpRegeneRateInSleep.Text,
                json_buildObjectDamageRate = textBox_buildObjectDamageRate.Text,
                json_buildObjectDeteriorationDamageRate = textBox_buildObjectDeteriorationDamageRate.Text,
                json_collectionDropRate = textBox_collectionDropRate.Text,
                json_collectionObjectHpRate = textBox_collectionObjectHpRate.Text,
                json_collectionObjectRespawnSpeedRate = textBox_collectionObjectRespawnSpeedRate.Text,
                json_enemyDropItemRate = textBox_enemyDropItemRate.Text,
                json_deathPenalty = comboBox_deathPenalty.Text,
                json_enablePlayerToPlayerDamage = comboBox_enablePlayerToPlayerDamage.Text,
                json_enableFriendlyFire = comboBox_enableFriendlyFire.Text,
                json_enableInvaderEnemy = comboBox_enableInvaderEnemy.Text,
                json_activeUNKO = comboBox_activeUNKO.Text,
                json_enableAimAssistPad = comboBox_enableAimAssistPad.Text,
                json_enableAimAssistKeyboard = comboBox_enableAimAssistKeyboard.Text,
                json_dropItemMaxNum = textBox_dropItemMaxNum.Text,
                json_dropItemMaxNum_UNKO = textBox_dropItemMaxNum_UNKO.Text,
                json_baseCampMaxNum = textBox_baseCampMaxNum.Text,
                json_baseCampWorkerMaxNum = textBox_baseCampWorkerMaxNum.Text,
                json_dropItemAliveMaxHours = textBox_dropItemAliveMaxHours.Text,
                json_autoResetGuildNoOnlinePlayers = comboBox_autoResetGuildNoOnlinePlayers.Text,
                json_autoResetGuildTimeNoOnlinePlayers = textBox_autoResetGuildTimeNoOnlinePlayers.Text,
                json_guildPlayerMaxNum = textBox_guildPlayerMaxNum.Text,
                json_palEggDefaultHatchingTime = textBox_palEggDefaultHatchingTime.Text,
                json_workSpeedRate = textBox_workSpeedRate.Text,
                json_isMultiplay = comboBox_isMultiplay.Text,
                json_isPvP = comboBox_isPvP.Text,
                json_canPickupOtherGuildDeathPenaltyDrop = comboBox_canPickupOtherGuildDeathPenaltyDrop.Text,
                json_enableNonLoginPenalty = comboBox_enableNonLoginPenalty.Text,
                json_enableFastTravel = comboBox_enableFastTravel.Text,
                json_isStartLocationSelectByMap = comboBox_isStartLocationSelectByMap.Text,
                json_existPlayerAfterLogout = comboBox_existPlayerAfterLogout.Text,
                json_enableDefenseOtherGuildPlayer = comboBox_enableDefenseOtherGuildPlayer.Text,
                json_coopPlayerMaxNum = textBox_coopPlayerMaxNum.Text,
                json_region = textBox_region.Text,
                json_useAuth = comboBox_useAuth.Text,
                json_banListURL = textBox_banListURL.Text

            };

            // Serialize settings to JSON
            string json = JsonSerializer.Serialize(settings);

            // Save JSON to file
            File.WriteAllText(serverSettingsFileName, json);

            //MessageBox.Show("Settings saved successfully.");

        }

        private void LoadServerSettingsJSON()
        {
            if (File.Exists(serverSettingsFileName))
            {
                // Read JSON from file
                string json = File.ReadAllText(serverSettingsFileName);

                // Deserialize JSON to settings object
                var settings = JsonSerializer.Deserialize<ServerSettingsPreset>(json);

                // Update UI with loaded settings
                ////backup settings
                textBox_backupInterval.Text = settings.json_backupInterval;
                textBox_maxBackup.Text = settings.json_maxBackup;
                textBox_backupTo.Text = settings.json_backupToDirectory;

                //Auto restart
                textBox_autoRestartEvery.Text = settings.json_autoRestartEvery;

                ////server settings
                textBox_serverName.Text = settings.json_serverName;
                textBox_serverDescription.Text = settings.json_serverDescription;
                textBox_serverPlayerMaxNum.Text = settings.json_serverPlayerMaxNum;
                textBox_adminPassword.Text = settings.json_adminPassword;
                textBox_serverPassword.Text = settings.json_serverPassword;
                textBox_publicPort.Text = settings.json_publicPort;
                textBox_publicIP.Text = settings.json_publicIP;
                comboBox_rconEnabled.Text = settings.json_rconEnabled;
                textBox_rconPort.Text = settings.json_rconPort;
                comboBox_difficulty.Text = settings.json_difficulty;
                textBox_dayTimeSpeedRate.Text = settings.json_dayTimeSpeedRate;
                textBox_nightTimeSpeedRate.Text = settings.json_nightTimeSpeedRate;
                textBox_expRate.Text = settings.json_expRate;
                textBox_palCaptureRate.Text = settings.json_palCaptureRate;
                textBox_palSpawnNumRate.Text = settings.json_palSpawnNumRate;
                textBox_palDamageRateAttack.Text = settings.json_palDamageRateAttack;
                textBox_palDamageRateDefense.Text = settings.json_palDamageRateDefense;
                textBox_playerDamageRateAttack.Text = settings.json_playerDamageRateAttack;
                textBox_playerDamageRateDefense.Text = settings.json_playerDamageRateDefense;
                textBox_playerStomachDecreaceRate.Text = settings.json_playerStomachDecreaseRate;
                textBox_playerStaminaDecreaceRate.Text = settings.json_playerStaminaDecreaseRate;
                textBox_playerAutoHpRegeneRate.Text = settings.json_playerAutoHpRegeneRate;
                textBox_playerAutoHpRegeneRateInSleep.Text = settings.json_playerAutoHpRegeneRateInSleep;
                textBox_palStomachDecreaceRate.Text = settings.json_palStomachDecreaseRate;
                textBox_palStaminaDecreaceRate.Text = settings.json_palStaminaDecreaseRate;
                textBox_palAutoHpRegeneRate.Text = settings.json_palAutoHpRegeneRate;
                textBox_palAutoHpRegeneRateInSleep.Text = settings.json_palAutoHpRegeneRateInSleep;
                textBox_buildObjectDamageRate.Text = settings.json_buildObjectDamageRate;
                textBox_buildObjectDeteriorationDamageRate.Text = settings.json_buildObjectDeteriorationDamageRate;
                textBox_collectionDropRate.Text = settings.json_collectionDropRate;
                textBox_collectionObjectHpRate.Text = settings.json_collectionObjectHpRate;
                textBox_collectionObjectRespawnSpeedRate.Text = settings.json_collectionObjectRespawnSpeedRate;
                textBox_enemyDropItemRate.Text = settings.json_enemyDropItemRate;
                comboBox_deathPenalty.Text = settings.json_deathPenalty;
                comboBox_enablePlayerToPlayerDamage.Text = settings.json_enablePlayerToPlayerDamage;
                comboBox_enableFriendlyFire.Text = settings.json_enableFriendlyFire;
                comboBox_enableInvaderEnemy.Text = settings.json_enableInvaderEnemy;
                comboBox_activeUNKO.Text = settings.json_activeUNKO;
                comboBox_enableAimAssistPad.Text = settings.json_enableAimAssistPad;
                comboBox_enableAimAssistKeyboard.Text = settings.json_enableAimAssistKeyboard;
                textBox_dropItemMaxNum.Text = settings.json_dropItemMaxNum;
                textBox_dropItemMaxNum_UNKO.Text = settings.json_dropItemMaxNum_UNKO;
                textBox_baseCampMaxNum.Text = settings.json_baseCampMaxNum;
                textBox_baseCampWorkerMaxNum.Text = settings.json_baseCampWorkerMaxNum;
                textBox_dropItemAliveMaxHours.Text = settings.json_dropItemAliveMaxHours;
                comboBox_autoResetGuildNoOnlinePlayers.Text = settings.json_autoResetGuildNoOnlinePlayers;
                textBox_autoResetGuildTimeNoOnlinePlayers.Text = settings.json_autoResetGuildTimeNoOnlinePlayers;
                textBox_guildPlayerMaxNum.Text = settings.json_guildPlayerMaxNum;
                textBox_palEggDefaultHatchingTime.Text = settings.json_palEggDefaultHatchingTime;
                textBox_workSpeedRate.Text = settings.json_workSpeedRate;
                comboBox_isMultiplay.Text = settings.json_isMultiplay;
                comboBox_isPvP.Text = settings.json_isPvP;
                comboBox_canPickupOtherGuildDeathPenaltyDrop.Text = settings.json_canPickupOtherGuildDeathPenaltyDrop;
                comboBox_enableNonLoginPenalty.Text = settings.json_enableNonLoginPenalty;
                comboBox_enableFastTravel.Text = settings.json_enableFastTravel;
                comboBox_isStartLocationSelectByMap.Text = settings.json_isStartLocationSelectByMap;
                comboBox_existPlayerAfterLogout.Text = settings.json_existPlayerAfterLogout;
                comboBox_enableDefenseOtherGuildPlayer.Text = settings.json_enableDefenseOtherGuildPlayer;
                textBox_coopPlayerMaxNum.Text = settings.json_coopPlayerMaxNum;
                textBox_region.Text = settings.json_region;
                comboBox_useAuth.Text = settings.json_useAuth;
                textBox_banListURL.Text = settings.json_banListURL;


                //MessageBox.Show("Settings loaded successfully.");
            }
            else
            {
                // Create default settings
            }

        }

        private void CreateServerSettingsJSON()
        {
            //CHECK TO SEE IF IT EXISTS IF NOT THEN CREATE DEFAULT VALUES FOR IT.
            if (!File.Exists(serverSettingsFileName))
            {
                // Create default settings
                var defaultSettings = new ServerSettingsPreset
                {
                    json_backupInterval = dserv_backupInterval,
                    json_maxBackup = dserv_maxBackup,
                    json_backupToDirectory = dserv_backupToDirectory,
                    json_autoRestartEvery = dserv_autoRestartEvery,
                    json_difficulty = dserv_difficulty,
                    json_dayTimeSpeedRate = dserv_dayTimeSpeedRate,
                    json_nightTimeSpeedRate = dserv_nightTimeSpeedRate,
                    json_expRate = dserv_expRate,
                    json_palCaptureRate = dserv_palCaptureRate,
                    json_palSpawnNumRate = dserv_palSpawnNumRate,
                    json_palDamageRateAttack = dserv_palDamageRateAttack,
                    json_palDamageRateDefense = dserv_palDamageRateDefense,
                    json_playerDamageRateAttack = dserv_playerDamageRateAttack,
                    json_playerDamageRateDefense = dserv_playerDamageRateDefense,
                    json_playerStomachDecreaseRate = dserv_playerStomachDecreaseRate,
                    json_playerStaminaDecreaseRate = dserv_playerStaminaDecreaseRate,
                    json_playerAutoHpRegeneRate = dserv_playerAutoHpRegenRate,
                    json_playerAutoHpRegeneRateInSleep = dserv_playerAutoHpRegenRateInSleep,
                    json_palStomachDecreaseRate = dserv_palStomachDecreaseRate,
                    json_palStaminaDecreaseRate = dserv_palStaminaDecreaseRate,
                    json_palAutoHpRegeneRate = dserv_palAutoHpRegeneRate,
                    json_palAutoHpRegeneRateInSleep = dserv_palAutoHpRegeneRateInSleep,
                    json_buildObjectDamageRate = dserv_buildObjectDamageRate,
                    json_buildObjectDeteriorationDamageRate = dserv_buildObjectDeteriorationDamageRate,
                    json_collectionDropRate = dserv_collectionDropRate,
                    json_collectionObjectHpRate = dserv_collectionObjectHpRate,
                    json_collectionObjectRespawnSpeedRate = dserv_collectionObjectRespawnSpeedRate,
                    json_enemyDropItemRate = dserv_enemyDropItemRate,
                    json_deathPenalty = dserv_deathPenalty,
                    json_enablePlayerToPlayerDamage = dserv_enablePlayerToPlayerDamage,
                    json_enableFriendlyFire = dserv_enableFriendlyFire,
                    json_enableInvaderEnemy = dserv_enableInvaderEnemy,
                    json_activeUNKO = dserv_activeUNKO,
                    json_enableAimAssistPad = dserv_enableAimAssistPad,
                    json_enableAimAssistKeyboard = dserv_enableAimAssistKeyboard,
                    json_dropItemMaxNum = dserv_dropItemMaxNum,
                    json_dropItemMaxNum_UNKO = dserv_dropItemMaxNum_UNKO,
                    json_baseCampMaxNum = dserv_baseCampMaxNum,
                    json_baseCampWorkerMaxNum = dserv_baseCampWorkerMaxNum,
                    json_dropItemAliveMaxHours = dserv_dropItemAliveMaxHours,
                    json_autoResetGuildNoOnlinePlayers = dserv_autoResetGuildNoOnlinePlayers,
                    json_autoResetGuildTimeNoOnlinePlayers = dserv_autoResetGuildTimeNoOnlinePlayers,
                    json_guildPlayerMaxNum = dserv_guildPlayerMaxNum,
                    json_palEggDefaultHatchingTime = dserv_palEggDefaultHatchingTime,
                    json_workSpeedRate = dserv_workSpeedRate,
                    json_isMultiplay = dserv_isMultiplay,
                    json_isPvP = dserv_isPvP,
                    json_canPickupOtherGuildDeathPenaltyDrop = dserv_canPickupOtherGuildDeathPenaltyDrop,
                    json_enableNonLoginPenalty = dserv_enableNonLoginPenalty,
                    json_enableFastTravel = dserv_enableFastTravel,
                    json_isStartLocationSelectByMap = dserv_isStartLocationSelectByMap,
                    json_existPlayerAfterLogout = dserv_existPlayerAfterLogout,
                    json_enableDefenseOtherGuildPlayer = dserv_enableDefenseOtherGuildPlayer,
                    json_coopPlayerMaxNum = dserv_coopPlayerMaxNum,
                    json_serverPlayerMaxNum = dserv_serverPlayerMaxNum,
                    json_serverName = dserv_serverName,
                    json_serverDescription = dserv_serverDescription,
                    json_adminPassword = dserv_adminPassword,
                    json_serverPassword = dserv_serverPassword,
                    json_publicPort = dserv_publicPort,
                    json_publicIP = dserv_publicIP,
                    json_rconEnabled = dserv_rconEnabled,
                    json_rconPort = dserv_rconPort,
                    json_region = dserv_region,
                    json_useAuth = dserv_useAuth,
                    json_banListURL = dserv_banListURL

                };

                // Serialize default settings to JSON
                string defaultJson = JsonSerializer.Serialize(defaultSettings);

                // Save JSON to file
                File.WriteAllText(serverSettingsFileName, defaultJson);

                //MessageBox.Show("Default settings created and saved.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the base directory of the application

            string iniFilePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");
            OpenFileDirectoryGiven(iniFilePath);


        }

        private void OpenFileDirectoryGiven(string directory)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = directory, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveGameTimer_Start()
        {
            if (serv_backupInterval != "0" && serv_backupInterval != "")
            {
                try
                {
                    int newInt;

                    if (int.TryParse(serv_backupInterval, out newInt))
                    {
                        // Parsing successful, newMaxBackupInt now holds the parsed integer value
                        Console.WriteLine("Parsing successful. Parsed integer value: " + newInt);
                    }
                    else
                    {
                        // Parsing failed, serv_maxBackup does not contain a valid integer format
                        Console.WriteLine("Parsing failed. The input string is not in a correct format.");
                    }

                    int actualTimer = (newInt * 1000);
                    timer1.Interval = actualTimer;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                timer1.Start();
            }

        }

        public void SaveGameTimer_Stop()
        {
            timer1.Stop();

        }

        private void SaveGame()
        {
            if (serv_backupInterval != "0" || forceBackup == true)
            {
                try
                {
                    string savePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "SaveGames");
                    if (!string.IsNullOrWhiteSpace(savePath) && !string.IsNullOrWhiteSpace(serv_backupToDirectory))
                    {
                        try
                        {
                            // Get the current date and time
                            DateTime currentDateTime = DateTime.Now;
                            // Format the date and time as a string
                            string currentDateTimeString = currentDateTime.ToString("yyyy_MM_dd_HH_mm_ss");
                            string mainFolderName = new DirectoryInfo(savePath).Name;
                            if (!forceBackup)
                            {
                                // THIS IS AUTO SAVE
                                string autoSaveDestinationMainFolderPath = Path.Combine(serv_backupToDirectory, "SaveFiles", "AutoSave", $"GameSave_{currentDateTimeString}", mainFolderName);
                                Directory.CreateDirectory(autoSaveDestinationMainFolderPath);

                                // Copy all files and subdirectories recursively
                                foreach (string dirPath in Directory.GetDirectories(savePath, "*", SearchOption.AllDirectories))
                                {
                                    Directory.CreateDirectory(dirPath.Replace(savePath, autoSaveDestinationMainFolderPath));
                                }

                                foreach (string newPath in Directory.GetFiles(savePath, "*.*", SearchOption.AllDirectories))
                                {
                                    File.Copy(newPath, newPath.Replace(savePath, autoSaveDestinationMainFolderPath), true);
                                }

                                CheckMaxBackup();
                            }
                            else if (forceBackup)
                            {
                                // THIS IS MANUAL SAVE
                                string manualSaveDestinationMainFolderPath = Path.Combine(serv_backupToDirectory, "SaveFiles", "ManualSave", $"GameSave_{currentDateTimeString}", mainFolderName);
                                Directory.CreateDirectory(manualSaveDestinationMainFolderPath);

                                // Copy all files and subdirectories recursively
                                foreach (string dirPath in Directory.GetDirectories(savePath, "*", SearchOption.AllDirectories))
                                {
                                    Directory.CreateDirectory(dirPath.Replace(savePath, manualSaveDestinationMainFolderPath));
                                }

                                foreach (string newPath in Directory.GetFiles(savePath, "*.*", SearchOption.AllDirectories))
                                {
                                    File.Copy(newPath, newPath.Replace(savePath, manualSaveDestinationMainFolderPath), true);
                                }
                            }

                            forceBackup = false;

                            //MessageBox.Show("Backup completed successfully!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show($"Error during backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        //MessageBox.Show($"Failed To Saved");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CheckMaxBackup() //Check max backup and delete oldest until x left.
        {

            //MessageBox.Show(serv_backupToDirectory);


            int newMaxBackupInt;
            if (int.TryParse(serv_maxBackup, out newMaxBackupInt))
            {
                // Parsing successful, newMaxBackupInt now holds the parsed integer value
                Console.WriteLine("Parsing successful. Parsed integer value: " + newMaxBackupInt);
            }
            else
            {
                // Parsing failed, serv_maxBackup does not contain a valid integer format
                Console.WriteLine("Parsing failed. The input string is not in a correct format.");
                return;
            }


            if (Directory.Exists(serv_backupToDirectory))
            {
                string saveFilePath = Path.Combine(serv_backupToDirectory, "SaveFiles", "AutoSave");
                string[] subdirectories = Directory.GetDirectories(saveFilePath);

                while (subdirectories.Length > newMaxBackupInt)
                {
                    var oldestDirectory = subdirectories
                        .Select(d => new DirectoryInfo(d))
                        .OrderBy(d => d.CreationTime)
                        .First();

                    try
                    {
                        oldestDirectory.Delete(true);
                        subdirectories = Directory.GetDirectories(saveFilePath); // Update subdirectories array
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show($"Error deleting directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // Exit the loop if an error occurs
                    }
                }

                //MessageBox.Show("Directory cleanup completed.", "Cleanup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("Directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_backupTo_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Display the selected folder path in a TextBox.
                    textBox_backupTo.Text = folderBrowserDialog.SelectedPath;
                    serv_backupToDirectory = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void button_manualSave_Click(object sender, EventArgs e)
        {
            forceBackup = true;
            SaveGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                SaveGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_openManualAutoSaveDirectory_Click(object sender, EventArgs e)
        {

            try
            {
                string savedDirectory = Path.Combine(serv_backupToDirectory, "SaveFiles");
                Process.Start(new ProcessStartInfo { FileName = savedDirectory, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AutoRestartServerTimer_Start()
        {
            if (serv_autoRestartEvery != "0" && serv_autoRestartEvery != "")
            {
                Debug.WriteLine(serv_autoRestartEvery);
                try
                {
                    int newInt;

                    if (int.TryParse(serv_autoRestartEvery, out newInt))
                    {
                        // Parsing successful, newMaxBackupInt now holds the parsed integer value
                        Debug.WriteLine("Parsing successful. Parsed integer value: " + newInt);
                    }
                    else
                    {
                        // Parsing failed, serv_maxBackup does not contain a valid integer format
                        Debug.WriteLine("Parsing failed. The input string is not in a correct format.");
                    }

                    int actualTimer = (newInt * 1000);
                    timer2.Interval = actualTimer;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                timer2.Start();
            }
        }

        public void AutoRestartServerTimer_Stop()
        {
            timer2.Stop();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (mainForm.isServerStarted)
                {
                    mainForm.StopServer();
                    mainForm.StartServer();
                }
                else
                {
                    Debug.WriteLine("Server not started");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }


}