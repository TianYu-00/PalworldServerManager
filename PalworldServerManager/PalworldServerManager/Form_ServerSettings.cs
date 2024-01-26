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
            ReadSettingPreset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult askBeforeSave = MessageBox.Show("Do you want to proceed with saving your server settings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (askBeforeSave == DialogResult.Yes)
            {
                ReadManagerSettings(); //Read All Textbox/ComboBox texts
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

        private void ReadManagerSettings()
        {
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
            // Save TextBox values to a text file
            using (StreamWriter sw = new StreamWriter("serversettingpreset.txt"))
            {
                sw.WriteLine(serv_serverName);
                sw.WriteLine(serv_serverDescription);
                sw.WriteLine(serv_serverPlayerMaxNum);
                sw.WriteLine(serv_adminPassword);
                sw.WriteLine(serv_serverPassword);
                sw.WriteLine(serv_publicPort);
                sw.WriteLine(serv_publicIP);
                sw.WriteLine(serv_rconEnabled);
                sw.WriteLine(serv_rconPort);
                sw.WriteLine(serv_difficulty);
                sw.WriteLine(serv_dayTimeSpeedRate);
                sw.WriteLine(serv_nightTimeSpeedRate);
                sw.WriteLine(serv_expRate);
                sw.WriteLine(serv_palCaptureRate);
                sw.WriteLine(serv_palSpawnNumRate);
                sw.WriteLine(serv_palDamageRateAttack);
                sw.WriteLine(serv_palDamageRateDefense);
                sw.WriteLine(serv_playerDamageRateAttack);
                sw.WriteLine(serv_playerDamageRateDefense);
                sw.WriteLine(serv_playerStomachDecreaseRate);
                sw.WriteLine(serv_playerStaminaDecreaseRate);
                sw.WriteLine(serv_playerAutoHpRegenRate);
                sw.WriteLine(serv_playerAutoHpRegenRateInSleep);
                sw.WriteLine(serv_palStomachDecreaseRate);
                sw.WriteLine(serv_palStaminaDecreaseRate);
                sw.WriteLine(serv_palAutoHpRegeneRate);
                sw.WriteLine(serv_palAutoHpRegeneRateInSleep);
                sw.WriteLine(serv_buildObjectDamageRate);
                sw.WriteLine(serv_buildObjectDeteriorationDamageRate);
                sw.WriteLine(serv_collectionDropRate);
                sw.WriteLine(serv_collectionObjectHpRate);
                sw.WriteLine(serv_collectionObjectRespawnSpeedRate);
                sw.WriteLine(serv_enemyDropItemRate);
                sw.WriteLine(serv_deathPenalty);
                sw.WriteLine(serv_enablePlayerToPlayerDamage);
                sw.WriteLine(serv_enableFriendlyFire);
                sw.WriteLine(serv_enableInvaderEnemy);
                sw.WriteLine(serv_activeUNKO);
                sw.WriteLine(serv_enableAimAssistPad);
                sw.WriteLine(serv_enableAimAssistKeyboard);
                sw.WriteLine(serv_dropItemMaxNum);
                sw.WriteLine(serv_dropItemMaxNum_UNKO);
                sw.WriteLine(serv_baseCampMaxNum);
                sw.WriteLine(serv_baseCampWorkerMaxNum);
                sw.WriteLine(serv_dropItemAliveMaxHours);
                sw.WriteLine(serv_autoResetGuildNoOnlinePlayers);
                sw.WriteLine(serv_autoResetGuildTimeNoOnlinePlayers);
                sw.WriteLine(serv_guildPlayerMaxNum);
                sw.WriteLine(serv_palEggDefaultHatchingTime);
                sw.WriteLine(serv_workSpeedRate);
                sw.WriteLine(serv_isMultiplay);
                sw.WriteLine(serv_isPvP);
                sw.WriteLine(serv_canPickupOtherGuildDeathPenaltyDrop);
                sw.WriteLine(serv_enableNonLoginPenalty);
                sw.WriteLine(serv_enableFastTravel);
                sw.WriteLine(serv_isStartLocationSelectByMap);
                sw.WriteLine(serv_existPlayerAfterLogout);
                sw.WriteLine(serv_enableDefenseOtherGuildPlayer);
                sw.WriteLine(serv_coopPlayerMaxNum);
                sw.WriteLine(serv_region);
                sw.WriteLine(serv_useAuth);
                sw.WriteLine(serv_banListURL);
            }

            //MessageBox.Show("Data saved successfully!");
        }

        private void ReadSettingPreset()
        {
            // Read values from the text file and set them to TextBoxes on form load
            if (File.Exists("serversettingpreset.txt"))
            {
                using (StreamReader sr = new StreamReader("serversettingpreset.txt"))
                {
                    textBox_serverName.Text = sr.ReadLine();
                    textBox_serverDescription.Text = sr.ReadLine();
                    textBox_serverPlayerMaxNum.Text = sr.ReadLine();
                    textBox_adminPassword.Text = sr.ReadLine();
                    textBox_serverPassword.Text = sr.ReadLine();
                    textBox_publicPort.Text = sr.ReadLine();
                    textBox_publicIP.Text = sr.ReadLine();
                    comboBox_rconEnabled.Text = sr.ReadLine();
                    textBox_rconPort.Text = sr.ReadLine();
                    comboBox_difficulty.Text = sr.ReadLine();
                    textBox_dayTimeSpeedRate.Text = sr.ReadLine();
                    textBox_nightTimeSpeedRate.Text = sr.ReadLine();
                    textBox_expRate.Text = sr.ReadLine();
                    textBox_palCaptureRate.Text = sr.ReadLine();
                    textBox_palSpawnNumRate.Text = sr.ReadLine();
                    textBox_palDamageRateAttack.Text = sr.ReadLine();
                    textBox_palDamageRateDefense.Text = sr.ReadLine();
                    textBox_playerDamageRateAttack.Text = sr.ReadLine();
                    textBox_playerDamageRateDefense.Text = sr.ReadLine();
                    textBox_playerStomachDecreaceRate.Text = sr.ReadLine();
                    textBox_playerStaminaDecreaceRate.Text = sr.ReadLine();
                    textBox_playerAutoHpRegeneRate.Text = sr.ReadLine();
                    textBox_playerAutoHpRegeneRateInSleep.Text = sr.ReadLine();
                    textBox_palStomachDecreaceRate.Text = sr.ReadLine();
                    textBox_palStaminaDecreaceRate.Text = sr.ReadLine();
                    textBox_palAutoHpRegeneRate.Text = sr.ReadLine();
                    textBox_palAutoHpRegeneRateInSleep.Text = sr.ReadLine();
                    textBox_buildObjectDamageRate.Text = sr.ReadLine();
                    textBox_buildObjectDeteriorationDamageRate.Text = sr.ReadLine();
                    textBox_collectionDropRate.Text = sr.ReadLine();
                    textBox_collectionObjectHpRate.Text = sr.ReadLine();
                    textBox_collectionObjectRespawnSpeedRate.Text = sr.ReadLine();
                    textBox_enemyDropItemRate.Text = sr.ReadLine();
                    comboBox_deathPenalty.Text = sr.ReadLine();
                    comboBox_enablePlayerToPlayerDamage.Text = sr.ReadLine();
                    comboBox_enableFriendlyFire.Text = sr.ReadLine();
                    comboBox_enableInvaderEnemy.Text = sr.ReadLine();
                    comboBox_activeUNKO.Text = sr.ReadLine();
                    comboBox_enableAimAssistPad.Text = sr.ReadLine();
                    comboBox_enableAimAssistKeyboard.Text = sr.ReadLine();
                    textBox_dropItemMaxNum.Text = sr.ReadLine();
                    textBox_dropItemMaxNum_UNKO.Text = sr.ReadLine();
                    textBox_baseCampMaxNum.Text = sr.ReadLine();
                    textBox_baseCampWorkerMaxNum.Text = sr.ReadLine();
                    textBox_dropItemAliveMaxHours.Text = sr.ReadLine();
                    comboBox_autoResetGuildNoOnlinePlayers.Text = sr.ReadLine();
                    textBox_autoResetGuildTimeNoOnlinePlayers.Text = sr.ReadLine();
                    textBox_guildPlayerMaxNum.Text = sr.ReadLine();
                    textBox_palEggDefaultHatchingTime.Text = sr.ReadLine();
                    textBox_workSpeedRate.Text = sr.ReadLine();
                    comboBox_isMultiplay.Text = sr.ReadLine();
                    comboBox_isPvP.Text = sr.ReadLine();
                    comboBox_canPickupOtherGuildDeathPenaltyDrop.Text = sr.ReadLine();
                    comboBox_enableNonLoginPenalty.Text = sr.ReadLine();
                    comboBox_enableFastTravel.Text = sr.ReadLine();
                    comboBox_isStartLocationSelectByMap.Text = sr.ReadLine();
                    comboBox_existPlayerAfterLogout.Text = sr.ReadLine();
                    comboBox_enableDefenseOtherGuildPlayer.Text = sr.ReadLine();
                    textBox_coopPlayerMaxNum.Text = sr.ReadLine();
                    textBox_region.Text = sr.ReadLine();
                    comboBox_useAuth.Text = sr.ReadLine();
                    textBox_banListURL.Text = sr.ReadLine();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the base directory of the application
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string iniFilePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");

                // Open the base directory using the default file explorer
                Process.Start(iniFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}