using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PreviewSocialNetwork.Domain.Interfaces;
using PreviewSocialNetwork.Domain.Models;

namespace PreviewSocialNetwork.App.Services
{
    public class TelegramService : IServiceSocialNetwork, IAuth
    {
        private string _botToken = "718470687:AAF-SsRrPbXWoPyHLo8lIN7aHowpGzjg-Go";
        private int chat_id = 0;
        private HttpClient client;

        public TelegramService()
        {
            client = new HttpClient();
        }

        public bool SendSocialNetwork(IMessagePreview message)
        {
            throw new NotImplementedException();
        }

        public bool LoginAuthorization(User user)
        {
            throw new NotImplementedException();
        }

        public async Task SendMessage (HttpClient client, IMessagePreview message)
        {
            var response = await client.GetAsync($"https://api.telegram.org/bot{_botToken}/sendMessage?{chat_id}5&text={message.TimeMessage}{message.MessageText}");
            Console.WriteLine(response.ToString());

        }

        public async Task GetUpdate(HttpClient client)
        {
            var response = await client.GetAsync($"https://api.telegram.org/bot{_botToken}/getUpdates");
            //var deser = JsonSerializer.Deserialize<Chat>(response);
        }
    }

    //"chat": {
    //"id": -1001370618615,
    //"title": "Tes",
    //"username": "Tewaaaaa",
    //"type": "channel"

    public class Chat
    {
        public int id;
        public string title;
        public string username;
        public string type;
    }
}
