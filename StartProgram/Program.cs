using System;
using PreviewSocialNetwork.App.Services;
using PreviewSocialNetwork.View;

namespace StartProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new LogicServiceExpILogicServices();
            logic.StartProgram();
        }
    }
}