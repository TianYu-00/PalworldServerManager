using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PalworldServerManager
{
    public partial class Form_DiscordWebHook : Form
    {
        //Webhook Guide: https://birdie0.github.io/discord-webhooks-guide/index.html
        //Avatar: https://i.imgur.com/qhTj0IT.jpeg
        //COLOR: 16761035
        Form_RCON rconForm;

        private string WebhookUrl;
        private string txtUsername;
        private string txtAvatarURL;

        //Embed
        private string txtEmbedTitle;
        private string txtEmbedDescription;
        private string txtEmbedColor;
        private string txtEmbedAuthor_name;
        private string txtEmbedAuthor_url;
        private string txtEmbedAuthor_icon;
        private string txtEmbedImage_url;
        private string txtEmbedThumbnail_url;
        private string txtEmbedFooter_text;
        private string txtEmbedFooter_url;


        public Form_DiscordWebHook(Form1 form)
        {
            InitializeComponent();
            rconForm = form.rconForm;
        }

        private void Form_DiscordWebHook_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private async Task SendMessageToWebhook(DiscordMessage message)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(message);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(WebhookUrl, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        Debug.WriteLine("Failed to send message to webhook: " + response.StatusCode);
                    }
                    else
                    {
                        Debug.WriteLine("Message sent successfully!");
                    }
                }
            }
            catch (Exception ex)
            { 
            
            }
            
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            SendEmbed();
        }


        public async void SendEmbed(string customTitle = null, string customMessage = null)
        {
            string sendMessage;
            string sendTitle;
            string sendFooter;
            if (customMessage != null)
            {
                sendMessage = customMessage;
            }
            else
            {
                sendMessage = txtEmbedDescription;
            }
            
            if (customTitle != null)
            {
                sendTitle = customTitle;
            }
            else
            {
                sendTitle = txtEmbedTitle;
            }

            //rconForm
            if (rconForm.isAutoUpdatePlayers)
            {
                sendFooter = "Online Players: " + rconForm.playerAmount.ToString();
            }
            else
            {
                sendFooter = txtEmbedFooter_text;
            }

            DiscordEmbedAuthor author = new DiscordEmbedAuthor()
            {
                authorName = txtEmbedAuthor_name,
                authorUrl = txtEmbedAuthor_url,
                aurhorIconUrl = txtEmbedAuthor_icon
            };

            DiscordEmbedImage image = new DiscordEmbedImage()
            {
                imageUrl = txtEmbedImage_url
            };

            DiscordEmbedThumbnail thumbnail = new DiscordEmbedThumbnail()
            {
                thumbnailUrl = txtEmbedThumbnail_url
            };

            DiscordEmbedFooter footer = new DiscordEmbedFooter()
            {
                footerText = sendFooter,
                footerIconUrl = txtEmbedFooter_url
            };

            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");


            DiscordMessage message = new DiscordMessage
            {
                Username = txtUsername,
                AvatarURL = txtAvatarURL,
                Embeds = new[]
                {
                    new DiscordEmbed
                    {
                        embedColor = txtEmbedColor,
                        embedTitle = sendTitle,
                        embedDescription = sendMessage,
                        embedAuthor = author,
                        embedImage = image,
                        embedThumbnail = thumbnail,
                        embedFooter = footer,
                        embedTimestamp = timestamp,


                    }
                }
            };

            await SendMessageToWebhook(message);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveData();
            
        }

        private void PreSend()
        {
            WebhookUrl = textBox_webhookURL.Text;
            txtUsername = textBox_username.Text;
            txtAvatarURL = textBox_avatarURL.Text;
            //Embeds
            txtEmbedTitle = textBox_embedTitle.Text;
            txtEmbedDescription = textBox_embedDescription.Text;
            txtEmbedColor = textBox_embedColor.Text;
            txtEmbedAuthor_name = textBox_embedAuthorName.Text;
            txtEmbedAuthor_url = textBox_embedAuthorURL.Text;
            txtEmbedAuthor_icon = textBox_embedAuthorIconURL.Text;
            txtEmbedImage_url = textBox_embedImageURL.Text;
            txtEmbedThumbnail_url = textBox_embedThumbnailURL.Text;
            txtEmbedFooter_text = textBox_embedFooterText.Text;
            txtEmbedFooter_url = textBox_embedFooterURL.Text;
            if (string.IsNullOrEmpty(textBox_embedColor.Text))
            {
                txtEmbedColor = 16761035.ToString();
            }
            if (string.IsNullOrEmpty(textBox_username.Text))
            {
                txtUsername = "Palworld Server Manager";
            }
            if (string.IsNullOrEmpty(textBox_avatarURL.Text))
            {
                txtAvatarURL = "https://i.imgur.com/qhTj0IT.jpeg";
            }
        }

        private void SaveData()
        {
            // Create an instance of SaveLoadData and set its properties from the TextBoxes
            var data = new SaveLoadData
            {
                json_webhookURL = textBox_webhookURL.Text,
                json_username = textBox_username.Text,
                json_avatarURL = textBox_avatarURL.Text,

                json_embedTitle = textBox_embedTitle.Text,
                json_embedDescription = textBox_embedDescription.Text,
                json_embedColor = textBox_embedColor.Text,
                json_embedAuthorName = textBox_embedAuthorName.Text,
                json_embedAuthorURL = textBox_embedAuthorURL.Text,
                json_embedAuthorIconURL = textBox_embedAuthorIconURL.Text,
                json_embedImageURL = textBox_embedImageURL.Text,
                json_embedThumbnailURL = textBox_embedThumbnailURL.Text,
                json_embedFooterText = textBox_embedFooterText.Text,
                json_embedFooterURL = textBox_embedFooterURL.Text

            };

            // Serialize the data to JSON
            string jsonData = JsonConvert.SerializeObject(data);

            try
            {
                // Save JSON to file
                File.WriteAllText("webhooksavedata.json", jsonData);
                Debug.WriteLine("Data saved successfully!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving data: {ex.Message}");
            }
            PreSend();
        }

        private void LoadData()
        {
            try
            {
                // Read JSON from file
                string jsonData = File.ReadAllText("webhooksavedata.json");

                // Deserialize JSON to DataModel object
                SaveLoadData data = JsonConvert.DeserializeObject<SaveLoadData>(jsonData);

                // Set TextBox values from deserialized properties
                textBox_webhookURL.Text = data.json_webhookURL;
                textBox_username.Text = data.json_username;
                textBox_avatarURL.Text = data.json_avatarURL;
                textBox_embedTitle.Text = data.json_embedTitle;
                textBox_embedDescription.Text = data.json_embedDescription;
                textBox_embedColor.Text = data.json_embedColor;
                textBox_embedAuthorName.Text = data.json_embedAuthorName;
                textBox_embedAuthorURL.Text = data.json_embedAuthorURL;
                textBox_embedAuthorIconURL.Text = data.json_embedAuthorIconURL;
                textBox_embedImageURL.Text = data.json_embedImageURL;
                textBox_embedThumbnailURL.Text = data.json_embedThumbnailURL;
                textBox_embedFooterText.Text = data.json_embedFooterText;
                textBox_embedFooterURL.Text = data.json_embedFooterURL;
                // Set other TextBox controls as needed
            }
            catch (FileNotFoundException)
            {
                Debug.WriteLine("Data file not found. Please save data first.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading data: {ex.Message}");
            }
            PreSend();
        }
    }

    public class DiscordMessage
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarURL { get; set; }

        [JsonProperty("embeds")]
        public DiscordEmbed[] Embeds { get; set; }
    }

    public class DiscordEmbed
    {
        [JsonProperty("color")]
        public string embedColor { get; set; }

        [JsonProperty("title")]
        public string embedTitle { get; set; }

        [JsonProperty("description")]
        public string embedDescription { get; set; }

        [JsonProperty("author")]
        public DiscordEmbedAuthor embedAuthor { get; set; }

        [JsonProperty("image")]
        public DiscordEmbedImage embedImage { get; set; }

        [JsonProperty("thumbnail")]
        public DiscordEmbedThumbnail embedThumbnail { get; set; }

        [JsonProperty("footer")]
        public DiscordEmbedFooter embedFooter { get; set; }

        [JsonProperty("timestamp")]
        public string embedTimestamp { get; set; }

    }

    public class DiscordEmbedAuthor
    {
        [JsonProperty("name")]
        public string authorName { get; set; }

        [JsonProperty("url")]
        public string authorUrl { get; set; }

        [JsonProperty("icon_url")]
        public string aurhorIconUrl { get; set; }
    }

    public class DiscordEmbedImage
    {
        [JsonProperty("url")]
        public string imageUrl { get; set; }
    }

    public class DiscordEmbedThumbnail
    {
        [JsonProperty("url")]
        public string thumbnailUrl { get; set; }
    }

    public class DiscordEmbedFooter
    {
        [JsonProperty("text")]
        public string footerText { get; set; }

        [JsonProperty("icon_url")]
        public string footerIconUrl { get; set; }
    }

    public class SaveLoadData
    {
        public string json_webhookURL { get; set; }
        public string json_username { get; set; }
        public string json_avatarURL { get; set; }
        public string json_embedTitle { get; set; }
        public string json_embedDescription { get; set; }
        public string json_embedColor { get; set; }
        public string json_embedAuthorName { get; set; }
        public string json_embedAuthorURL { get; set; }
        public string json_embedAuthorIconURL { get; set; }
        public string json_embedImageURL { get; set; }
        public string json_embedThumbnailURL { get; set; }
        public string json_embedFooterText { get; set; }
        public string json_embedFooterURL { get; set; }

    }
}
