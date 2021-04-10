using System;
using PreviewSocialNetwork.App.Config;
using PreviewSocialNetwork.App.Services;
using PreviewSocialNetwork.View;

namespace StartProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new LogicService(new ConfigService());//подключение конфигурации.
            logic.StartProgram();
        }
    }
}