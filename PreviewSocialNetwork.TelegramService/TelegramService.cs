using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
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

        public TelegramService(string token, HttpClient client)
        {
            _botToken = token;
            Client = client;
            _allChatIdsList = new HashSet<long>();

            GetUpdate(Client);
        }

        public bool SendSocialNetwork(IMessagePreview message)
        {
            var temp = false;

            foreach (var chatId in _allChatIdsList)
            {
                var result = SendMessage(Client, message, chatId);
                temp = true;
            }

            if (temp == true)
            {
                return true;
            }

            return false;
        }


        private async Task<bool> SendMessage(HttpClient client, IMessagePreview message, long chatIds)
        {
            if (client != null && message != null)
            {
                var url = $"https://api.telegram.org/bot{_botToken}/sendMessage?chat_id={chatIds}&text={message.TimeMessage}{message.MessageText}";

                var response = await client.GetAsync(url);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }

            return false;
        }


        private async void GetUpdate(HttpClient client)
        {
            if (client != null)
            {
                var response = await client.GetAsync($"https://api.telegram.org/bot{_botToken}/getUpdates?limit=10");

                var res = response.Content.ReadAsStringAsync().Result;

                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(res);

                foreach (var item in myDeserializedClass.Result)
                {
                    if (item.ChannelPost != null)
                    {
                        _allChatIdsList.Add(item.ChannelPost.SenderChat.Id);
                    }
                }
            }
        }
    }
}
