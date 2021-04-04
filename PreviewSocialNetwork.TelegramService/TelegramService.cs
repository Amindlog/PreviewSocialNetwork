using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PreviewSocialNetwork.Domain.Interfaces;
using PreviewSocialNetwork.Domain.Models;

namespace PreviewSocialNetwork.App.Services
{
    public class TelegramService : IServiceSocialNetwork
    {
        private string _botToken = "718470687:AAF-SsRrPbXWoPyHLo8lIN7aHowpGzjg-Go";
        private static long _chat_id;
        public HttpClient Client { get; set; }

        public TelegramService()
        {
            Client = new HttpClient();
            GetUpdate(Client);
        }

        public bool SendSocialNetwork(IMessagePreview message)
        {
            var result = SendMessage(Client, message);
            if (result.Result == true)
            {
                return true;
            }

            return false;

        }


        public async Task<bool> SendMessage (HttpClient client, IMessagePreview message)
        {
            var url = $"https://api.telegram.org/bot{_botToken}/sendMessage?chat_id={_chat_id}&text={message.TimeMessage}{message.MessageText}";
            var response = await client.GetAsync(url);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine($"Ответ от Telegram: " + response.StatusCode);
                return true;
            }

            return false;

        }

        public async Task GetUpdate(HttpClient client)
        {
            var response = await client.GetAsync($"https://api.telegram.org/bot{_botToken}/getUpdates?limit=1");
            var res = response.Content.ReadAsStringAsync().Result;
            var stringResultSplit = res.Substring(95).Split(',');
            _chat_id = Convert.ToInt64(stringResultSplit[0]);
        }
    }

    
}
