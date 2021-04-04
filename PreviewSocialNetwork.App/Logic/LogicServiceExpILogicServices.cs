using PreviewSocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.App.Services
{
    public delegate bool SendMessage(IMessagePreview message);
    public class LogicServiceExpILogicServices : ILogicServices
    {
        public LogicServiceExpILogicServices()
        {
            var vk = new VkService();
            var discord = new DiscordService();
            var telegram = new TelegramService();
            var twitter = new TwitterService();

            SendMessage sendMessage = vk.SendSocialNetwork;
            sendMessage += discord.SendSocialNetwork;
            sendMessage += telegram.SendSocialNetwork;
            sendMessage += twitter.SendSocialNetwork;
        }

        public void StartProgram()
        {
            Loop();
        }

        private void Loop()
        {
            
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
