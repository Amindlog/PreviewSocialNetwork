using System;
using PreviewSocialNetwork.App.Services;

namespace PreviewSocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new LogicServiceExpILogicServices();
            logic.StartProgram();

            Console.WriteLine("----");
        }
    }
}
