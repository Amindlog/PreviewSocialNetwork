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
        private int _chat_id = 0;
        public HttpClient Client { get; set; }

        public TelegramService()
        {
            Client = new HttpClient();
            GetUpdate(Client);
        }

        public bool SendSocialNetwork(IMessagePreview message)
        {
            SendMessage(Client, message);
            return true;
        }


        public async void SendMessage (HttpClient client, IMessagePreview message)
        {
            var response = await client.GetAsync($"https://api.telegram.org/bot{_botToken}/sendMessage?{_chat_id}5&text={message.TimeMessage}{message.MessageText}");

            Console.WriteLine($"Ответ от Telegram: " + response.StatusCode);
        

        }

        public async Task GetUpdate(HttpClient client)
        {
            var response = await client.GetAsync($"https://api.telegram.org/bot{_botToken}/getUpdates?limit=1");
            var res = response.Content.ReadAsStringAsync().Result;
            var stringResultSplit = res.Substring(95).Split(',');
            int.TryParse(stringResultSplit[0], out _chat_id);
        }
    }

    
}
