using PreviewSocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using PreviewSocialNetwork.App.Config;
using PreviewSocialNetwork.Domain.Models;

namespace PreviewSocialNetwork.App.Services
{
    public delegate bool SendMessageDelegate(IMessagePreview message);
    public class LogicService : ILogicServices
    {

        private IMessageView _view;
        private SendMessageDelegate _sendMessage;
        
        public LogicService(IConfig config)
        {
            _view = new View.ViewExpIMessageView(); //подключение к вьюшке


            //IServiceSocialNetwork vk = new VkService();
            //IServiceSocialNetwork discord = new DiscordService();
            IServiceSocialNetwork telegram = new TelegramService(config.GetTelegramConfig().Token, new HttpClient());
            //IServiceSocialNetwork twitter = new TwitterService();


            //_sendMessage = vk.SendSocialNetwork;
            //_sendMessage += discord.SendSocialNetwork;
            _sendMessage += telegram.SendSocialNetwork;
            //_sendMessage += twitter.SendSocialNetwork;

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
                _view.PrintLine("Доступные действия: \n1 - Отправить сообщение: \n0 - Выйти из приложения.");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        _view.PrintLine("Введите текст для отправки в соцсети:");
                        if (_sendMessage.Invoke(new MessagePreview()
                                        {
                                            MessageText = Console.ReadLine(),
                                            TimeMessage = DateTime.Now.ToString()
                                        }))
                        {
                            _view.SuccessSendMessage();
                        }
                        else
                        {
                            _view.ErrorSendMessage("Отправка сообщений не удалась");
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad0:
                    case ConsoleKey.D0:
                        finised = false;
                        _view.PrintLine("Приложение завершено.");
                        break;
                }
            }


        }
    }
}
