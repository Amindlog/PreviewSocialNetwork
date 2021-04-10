using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PreviewSocialNetwork.Domain.Interfaces;
using PreviewSocialNetwork.Domain.Models;
using PreviewSocialNetwork.TelegramService.ModelJson;

namespace PreviewSocialNetwork.App.Services
{
    public class TelegramService : IServiceSocialNetwork
    {
        private string _botToken = "";
        private HashSet<long> _allChatIdsList;


        public HttpClient Client { get; set; }

        public TelegramService(IConfig config)
        {
            _botToken = config.GetTelegramConfig().Token.ToString();
            Client = new HttpClient();
            _allChatIdsList = new HashSet<long>();

            GetUpdate(Client);
        }

        public bool SendSocialNetwork(IMessagePreview message)
        {
            var res = false;
            foreach (var item in _allChatIdsList)
            {
                var result = SendMessage(Client, message, item);
                res = true;
            }
            if (res == true)
            {
                return true;
            }

            return false;

        }


        public async Task<bool> SendMessage(HttpClient client, IMessagePreview message, long chatIds)
        {

            var url = $"https://api.telegram.org/bot{_botToken}/sendMessage?chat_id={chatIds}&text={message.TimeMessage}{message.MessageText}";
            var response = await client.GetAsync(url);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }


        public async Task GetUpdate(HttpClient client)
        {
            var response = await client.GetAsync($"https://api.telegram.org/bot{_botToken}/getUpdates?limit=10");
            var res = response.Content.ReadAsStringAsync().Result;
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(res);
            foreach (var item in myDeserializedClass.Result)
            {
                _allChatIdsList.Add(item.ChannelPost.SenderChat.Id);
            }

        }
    }


}
