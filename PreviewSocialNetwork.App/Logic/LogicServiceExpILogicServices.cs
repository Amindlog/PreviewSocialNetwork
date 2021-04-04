using PreviewSocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using PreviewSocialNetwork.Domain.Models;

namespace PreviewSocialNetwork.App.Services
{
    public delegate bool SendMessage(IMessagePreview message);
    public class LogicServiceExpILogicServices : ILogicServices
    {
        private SendMessage _sendMessage;
        public LogicServiceExpILogicServices()
        {
            var vk = new VkService();
            var discord = new DiscordService();
            var telegram = new TelegramService();
            var twitter = new TwitterService();

            _sendMessage = vk.SendSocialNetwork;
            _sendMessage += discord.SendSocialNetwork;
            _sendMessage += telegram.SendSocialNetwork;
            _sendMessage += twitter.SendSocialNetwork;
        }

        public void StartProgram()
        {
            Loop();
        }

        private void Loop()
        {
            bool finised = true;
            while (finised)
            {
                View.View.Menu();
                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        View.View.Action1();
                        _sendMessage.Invoke(new MessagePreview()
                            {
                                MessageText = Console.ReadLine(),
                                TimeMessage = DateTime.Now.ToString()
                            });
                        break;
                    case ConsoleKey.NumPad0:
                    case ConsoleKey.D0:
                        finised = false;
                        View.View.Action0();
                        break;
                }
            }


        }
        public IServiceSocialNetwork Service { get; }

        public List<int> ParserStringGetIssue(string message)//1 2 3
        {
            List<int> list = new List<int>();
            string[] words = message.Split(' ');
            foreach (var item in words)
            {
                list.Add(Convert.ToInt32(item));
            }
            return list;
        }

    }
}
