using PreviewSocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.App.Services
{
    public class LogicServiceExpILogicServices : ILogicServices
    {
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
