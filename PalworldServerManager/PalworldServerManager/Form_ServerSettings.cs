using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalworldServerManager
{
    public partial class Form_ServerSettings : Form
    {
        //
        //Palworld World Server Settings Parameter Description
        //
        // BACKUP INTERVAL
        private bool forceBackup = false;
        private string serv_backupInterval;
        private string serv_maxBackup;
        private string serv_backupToDirectory;


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

        public Form_ServerSettings()
        {
            InitializeComponent();
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
            ReadWorldSettingsFile();
            ReadSettingPresetFromSaved();
            serv_backupInterval = textBox_backupInterval.Text;
            serv_backupToDirectory = textBox_backupTo.Text;
            serv_maxBackup = textBox_maxBackup.Text;
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
                    SaveSettingPreset(); // Save the settings to a txt file to be loaded on start.
                    ReadWorldSettingsFile(); // Read the world setting ini and set it to display on my richtextbox
                    MessageBox.Show("Server World Settings Saved");
                }
            }
            else
            {
                //Not saved
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetWorldSettingsDefault();
            //MessageBox.Show("Default Server World Settings Loaded. Remember to save it if youre happy with it.");
        }

        private void ReadWorldSettingsFile()
        {
            // Get the executable directory
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Combine the executable directory with the relative path to the INI file
            string iniFilePath = Path.Combine(exeDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");

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
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Combine the executable directory with the relative path to the INI file
            string iniFilePath = Path.Combine(exeDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");

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

        private void SetWorldSettingsDefault()
        {
            //Backup settings
            textBox_backupInterval.Text = dserv_backupInterval;
            textBox_maxBackup.Text = dserv_maxBackup;
            textBox_backupTo.Text = dserv_backupToDirectory;

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

        private void SaveSettingPreset()
        {
            //Properties.Settings.Default.Saved_backupInterval = serv_backupInterval;
            //Properties.Settings.Default.Saved_maxBackup = serv_maxBackup;
            //Properties.Settings.Default.Saved_backupTo = serv_backupToDirectory;
            //Properties.Settings.Default.Saved_serverName = serv_serverName;
            //Properties.Settings.Default.Saved_serverDescription = serv_serverDescription;
            //Properties.Settings.Default.Saved_serverPlayerMaxNum = serv_serverPlayerMaxNum;
            //Properties.Settings.Default.Saved_adminPassword = serv_adminPassword;
            //Properties.Settings.Default.Saved_serverPassword = serv_serverPassword;
            //Properties.Settings.Default.Saved_publicPort = serv_publicPort;
            //Properties.Settings.Default.Saved_publicIP = serv_publicIP;
            //Properties.Settings.Default.Saved_rconEnabled = serv_rconEnabled;
            //Properties.Settings.Default.Saved_RconPort = serv_rconPort;
            //Properties.Settings.Default.Saved_difficulty = serv_difficulty;
            //Properties.Settings.Default.Saved_dayTimeSpeedRate = serv_dayTimeSpeedRate;
            //Properties.Settings.Default.Saved_nightTimeSpeedRate = serv_nightTimeSpeedRate;
            //Properties.Settings.Default.Saved_expRate = serv_expRate;

            //Backup Settings
            Properties.Settings.Default.Saved_backupInterval = serv_backupInterval;
            Properties.Settings.Default.Saved_maxBackup = serv_maxBackup;
            Properties.Settings.Default.Saved_backupTo = serv_backupToDirectory;

            //Server Settings
            Properties.Settings.Default.Saved_difficulty = serv_difficulty;
            Properties.Settings.Default.Saved_dayTimeSpeedRate = serv_dayTimeSpeedRate;
            Properties.Settings.Default.Saved_nightTimeSpeedRate = serv_nightTimeSpeedRate;
            Properties.Settings.Default.Saved_expRate = serv_expRate;
            Properties.Settings.Default.Saved_palCaptureRate = serv_palCaptureRate;
            Properties.Settings.Default.Saved_palSpawnNumRate = serv_palSpawnNumRate;
            Properties.Settings.Default.Saved_palDamageRateAttack = serv_palDamageRateAttack;
            Properties.Settings.Default.Saved_palDamageRateDefense = serv_palDamageRateDefense;
            Properties.Settings.Default.Saved_playerDamageRateAttack = serv_playerDamageRateAttack;
            Properties.Settings.Default.Saved_playerDamageRateDefense = serv_playerDamageRateDefense;
            Properties.Settings.Default.Saved_playerStomachDecreaseRate = serv_playerStomachDecreaseRate;
            Properties.Settings.Default.Saved_playerStaminaDecreaseRate = serv_playerStaminaDecreaseRate;
            Properties.Settings.Default.Saved_playerAutoHpRegeneRate = serv_playerAutoHpRegenRate;
            Properties.Settings.Default.Saved_playerAutoHpRegeneRateInSleep = serv_playerAutoHpRegenRateInSleep;
            Properties.Settings.Default.Saved_palStomachDecreaseRate = serv_palStomachDecreaseRate;
            Properties.Settings.Default.Saved_palStaminaDecreaseRate = serv_palStaminaDecreaseRate;
            Properties.Settings.Default.Saved_palAutoHpRegeneRate = serv_palAutoHpRegeneRate;
            Properties.Settings.Default.Saved_palAutoHpRegeneRateInSleep = serv_palAutoHpRegeneRateInSleep;
            Properties.Settings.Default.Saved_buildObjectDamageRate = serv_buildObjectDamageRate;
            Properties.Settings.Default.Saved_buildObjectDeteriorationDamageRate = serv_buildObjectDeteriorationDamageRate;
            Properties.Settings.Default.Saved_collectionDropRate = serv_collectionDropRate;
            Properties.Settings.Default.Saved_collectionObjectHpRate = serv_collectionObjectHpRate;
            Properties.Settings.Default.Saved_collectionObjectRespawnSpeedRate = serv_collectionObjectRespawnSpeedRate;
            Properties.Settings.Default.Saved_enemyDropItemRate = serv_enemyDropItemRate;
            Properties.Settings.Default.Saved_deathPenalty = serv_deathPenalty;
            Properties.Settings.Default.Saved_enablePlayerToPlayerDamage = serv_enablePlayerToPlayerDamage;
            Properties.Settings.Default.Saved_enableFriendlyFire = serv_enableFriendlyFire;
            Properties.Settings.Default.Saved_enableInvaderEnemy = serv_enableInvaderEnemy;
            Properties.Settings.Default.Saved_activeUNKO = serv_activeUNKO;
            Properties.Settings.Default.Saved_enableAimAssistPad = serv_enableAimAssistPad;
            Properties.Settings.Default.Saved_enableAimAssistKeyboard = serv_enableAimAssistKeyboard;
            Properties.Settings.Default.Saved_dropItemMaxNum = serv_dropItemMaxNum;
            Properties.Settings.Default.Saved_dropItemMaxNum_UNKO = serv_dropItemMaxNum_UNKO;
            Properties.Settings.Default.Saved_baseCampMaxNum = serv_baseCampMaxNum;
            Properties.Settings.Default.Saved_baseCampWorkerMaxNum = serv_baseCampWorkerMaxNum;
            Properties.Settings.Default.Saved_dropItemAliveMaxHours = serv_dropItemAliveMaxHours;
            Properties.Settings.Default.Saved_autoResetGuildNoOnlinePlayers = serv_autoResetGuildNoOnlinePlayers;
            Properties.Settings.Default.Saved_autoResetGuildTimeNoOnlinePlayers = serv_autoResetGuildTimeNoOnlinePlayers;
            Properties.Settings.Default.Saved_guildPlayerMaxNum = serv_guildPlayerMaxNum;
            Properties.Settings.Default.Saved_palEggDefaultHatchingTime = serv_palEggDefaultHatchingTime;
            Properties.Settings.Default.Saved_workSpeedRate = serv_workSpeedRate;
            Properties.Settings.Default.Saved_isMultiplay = serv_isMultiplay;
            Properties.Settings.Default.Saved_isPvP = serv_isPvP;
            Properties.Settings.Default.Saved_canPickupOtherGuildDeathPenaltyDrop = serv_canPickupOtherGuildDeathPenaltyDrop;
            Properties.Settings.Default.Saved_enableNonLoginPenalty = serv_enableNonLoginPenalty;
            Properties.Settings.Default.Saved_enableFastTravel = serv_enableFastTravel;
            Properties.Settings.Default.Saved_isStartLocationSelectByMap = serv_isStartLocationSelectByMap;
            Properties.Settings.Default.Saved_existPlayerAfterLogout = serv_existPlayerAfterLogout;
            Properties.Settings.Default.Saved_enableDefenseOtherGuildPlayer = serv_enableDefenseOtherGuildPlayer;
            Properties.Settings.Default.Saved_coopPlayerMaxNum = serv_coopPlayerMaxNum;
            Properties.Settings.Default.Saved_region = serv_region;
            Properties.Settings.Default.Saved_useAuth = serv_useAuth;
            Properties.Settings.Default.Saved_banListURL = serv_banListURL;
            Properties.Settings.Default.Saved_serverPlayerMaxNum = serv_serverPlayerMaxNum;
            Properties.Settings.Default.Saved_serverName = serv_serverName;
            Properties.Settings.Default.Saved_serverDescription = serv_serverDescription;
            Properties.Settings.Default.Saved_adminPassword = serv_adminPassword;
            Properties.Settings.Default.Saved_serverPassword = serv_serverPassword;
            Properties.Settings.Default.Saved_publicPort = serv_publicPort;
            Properties.Settings.Default.Saved_publicIP = serv_publicIP;
            Properties.Settings.Default.Saved_rconEnabled = serv_rconEnabled;
            Properties.Settings.Default.Saved_rconPort = serv_rconPort;


            // Save the settings
            Properties.Settings.Default.Save();

        }

        private void ReadSettingPresetFromSaved()
        {
                    //backup settings
                    textBox_backupInterval.Text = Properties.Settings.Default.Saved_backupInterval;
                    textBox_maxBackup.Text = Properties.Settings.Default.Saved_maxBackup;
                    textBox_backupTo.Text = Properties.Settings.Default.Saved_backupTo;

                    //server settings
                    textBox_serverName.Text = Properties.Settings.Default.Saved_serverName;
                    textBox_serverDescription.Text = Properties.Settings.Default.Saved_serverDescription;
                    textBox_serverPlayerMaxNum.Text = Properties.Settings.Default.Saved_serverPlayerMaxNum;
                    textBox_adminPassword.Text = Properties.Settings.Default.Saved_adminPassword;
                    textBox_serverPassword.Text = Properties.Settings.Default.Saved_serverPassword;
                    textBox_publicPort.Text = Properties.Settings.Default.Saved_publicPort;
                    textBox_publicIP.Text = Properties.Settings.Default.Saved_publicIP;
                    comboBox_rconEnabled.Text = Properties.Settings.Default.Saved_rconEnabled;
                    textBox_rconPort.Text = Properties.Settings.Default.Saved_rconPort;
                    comboBox_difficulty.Text = Properties.Settings.Default.Saved_difficulty;
                    textBox_dayTimeSpeedRate.Text = Properties.Settings.Default.Saved_dayTimeSpeedRate;
                    textBox_nightTimeSpeedRate.Text = Properties.Settings.Default.Saved_nightTimeSpeedRate;
                    textBox_expRate.Text = Properties.Settings.Default.Saved_expRate;
                    textBox_palCaptureRate.Text = Properties.Settings.Default.Saved_palCaptureRate;
                    textBox_palSpawnNumRate.Text = Properties.Settings.Default.Saved_palSpawnNumRate;
                    textBox_palDamageRateAttack.Text = Properties.Settings.Default.Saved_palDamageRateAttack;
                    textBox_palDamageRateDefense.Text = Properties.Settings.Default.Saved_palDamageRateDefense;
                    textBox_playerDamageRateAttack.Text = Properties.Settings.Default.Saved_playerDamageRateAttack;
                    textBox_playerDamageRateDefense.Text = Properties.Settings.Default.Saved_playerDamageRateDefense;
                    textBox_playerStomachDecreaceRate.Text = Properties.Settings.Default.Saved_playerStomachDecreaseRate;
                    textBox_playerStaminaDecreaceRate.Text = Properties.Settings.Default.Saved_playerStaminaDecreaseRate;
                    textBox_playerAutoHpRegeneRate.Text = Properties.Settings.Default.Saved_playerAutoHpRegeneRate;
                    textBox_playerAutoHpRegeneRateInSleep.Text = Properties.Settings.Default.Saved_playerAutoHpRegeneRateInSleep;
                    textBox_palStomachDecreaceRate.Text = Properties.Settings.Default.Saved_palStomachDecreaseRate;
                    textBox_palStaminaDecreaceRate.Text = Properties.Settings.Default.Saved_palStaminaDecreaseRate;
                    textBox_palAutoHpRegeneRate.Text = Properties.Settings.Default.Saved_palAutoHpRegeneRate;
                    textBox_palAutoHpRegeneRateInSleep.Text = Properties.Settings.Default.Saved_palAutoHpRegeneRateInSleep;
                    textBox_buildObjectDamageRate.Text = Properties.Settings.Default.Saved_buildObjectDamageRate;
                    textBox_buildObjectDeteriorationDamageRate.Text = Properties.Settings.Default.Saved_buildObjectDeteriorationDamageRate;
                    textBox_collectionDropRate.Text = Properties.Settings.Default.Saved_collectionDropRate;
                    textBox_collectionObjectHpRate.Text = Properties.Settings.Default.Saved_collectionObjectHpRate;
                    textBox_collectionObjectRespawnSpeedRate.Text = Properties.Settings.Default.Saved_collectionObjectRespawnSpeedRate;
                    textBox_enemyDropItemRate.Text = Properties.Settings.Default.Saved_enemyDropItemRate;
                    comboBox_deathPenalty.Text = Properties.Settings.Default.Saved_deathPenalty;
                    comboBox_enablePlayerToPlayerDamage.Text = Properties.Settings.Default.Saved_enablePlayerToPlayerDamage;
                    comboBox_enableFriendlyFire.Text = Properties.Settings.Default.Saved_enableFriendlyFire;
                    comboBox_enableInvaderEnemy.Text = Properties.Settings.Default.Saved_enableInvaderEnemy;
                    comboBox_activeUNKO.Text = Properties.Settings.Default.Saved_activeUNKO;
                    comboBox_enableAimAssistPad.Text = Properties.Settings.Default.Saved_enableAimAssistPad;
                    comboBox_enableAimAssistKeyboard.Text = Properties.Settings.Default.Saved_enableAimAssistKeyboard;
                    textBox_dropItemMaxNum.Text = Properties.Settings.Default.Saved_dropItemMaxNum;
                    textBox_dropItemMaxNum_UNKO.Text = Properties.Settings.Default.Saved_dropItemMaxNum_UNKO;
                    textBox_baseCampMaxNum.Text = Properties.Settings.Default.Saved_baseCampMaxNum;
                    textBox_baseCampWorkerMaxNum.Text = Properties.Settings.Default.Saved_baseCampWorkerMaxNum;
                    textBox_dropItemAliveMaxHours.Text = Properties.Settings.Default.Saved_dropItemAliveMaxHours;
                    comboBox_autoResetGuildNoOnlinePlayers.Text = Properties.Settings.Default.Saved_autoResetGuildNoOnlinePlayers;
                    textBox_autoResetGuildTimeNoOnlinePlayers.Text = Properties.Settings.Default.Saved_autoResetGuildTimeNoOnlinePlayers;
                    textBox_guildPlayerMaxNum.Text = Properties.Settings.Default.Saved_guildPlayerMaxNum;
                    textBox_palEggDefaultHatchingTime.Text = Properties.Settings.Default.Saved_palEggDefaultHatchingTime;
                    textBox_workSpeedRate.Text = Properties.Settings.Default.Saved_workSpeedRate;
                    comboBox_isMultiplay.Text = Properties.Settings.Default.Saved_isMultiplay;
                    comboBox_isPvP.Text = Properties.Settings.Default.Saved_isPvP;
                    comboBox_canPickupOtherGuildDeathPenaltyDrop.Text = Properties.Settings.Default.Saved_canPickupOtherGuildDeathPenaltyDrop;
                    comboBox_enableNonLoginPenalty.Text = Properties.Settings.Default.Saved_enableNonLoginPenalty;
                    comboBox_enableFastTravel.Text = Properties.Settings.Default.Saved_enableFastTravel;
                    comboBox_isStartLocationSelectByMap.Text = Properties.Settings.Default.Saved_isStartLocationSelectByMap;
                    comboBox_existPlayerAfterLogout.Text = Properties.Settings.Default.Saved_existPlayerAfterLogout;
                    comboBox_enableDefenseOtherGuildPlayer.Text = Properties.Settings.Default.Saved_enableDefenseOtherGuildPlayer;
                    textBox_coopPlayerMaxNum.Text = Properties.Settings.Default.Saved_coopPlayerMaxNum;
                    textBox_region.Text = Properties.Settings.Default.Saved_region;
                    comboBox_useAuth.Text = Properties.Settings.Default.Saved_useAuth;
                    textBox_banListURL.Text = Properties.Settings.Default.Saved_banListURL;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the base directory of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
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
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string savePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "SaveGames");
                    if (!string.IsNullOrWhiteSpace(savePath) && !string.IsNullOrWhiteSpace(serv_backupToDirectory))
                    {
                        try
                        {
                            // Get the current date and time
                            DateTime currentDateTime = DateTime.Now;
                            // Format the date and time as a string
                            string currentDateTimeString = currentDateTime.ToString("yyyy_MM_dd_HH_mm_ss");

                            // Create the main folder in the destination directory
                            string mainFolderName = new DirectoryInfo(savePath).Name;
                            string destinationMainFolderPath = Path.Combine(serv_backupToDirectory,"SaveFiles", $"GameSave_{currentDateTimeString}", mainFolderName);
                            Directory.CreateDirectory(destinationMainFolderPath);

                            // Copy all files and subdirectories recursively
                            foreach (string dirPath in Directory.GetDirectories(savePath, "*", SearchOption.AllDirectories))
                            {
                                Directory.CreateDirectory(dirPath.Replace(savePath, destinationMainFolderPath));
                            }

                            foreach (string newPath in Directory.GetFiles(savePath, "*.*", SearchOption.AllDirectories))
                            {
                                File.Copy(newPath, newPath.Replace(savePath, destinationMainFolderPath), true);
                            }

                            CheckMaxBackup();
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
                string saveFilePath = Path.Combine(serv_backupToDirectory, "SaveFiles");
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
    }


}