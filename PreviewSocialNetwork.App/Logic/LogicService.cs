using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreviewSocialNetwork.Domain.Interfaces;

namespace PreviewSocialNetwork.App.Logic
{
    public class LogicService : ILogicServices
    {
        public IServiceSocialNetwork Service { get; }
        public IAuth Authorization { get; }
        public List<int> ParserStringGetIssue(string message)
        {
            throw new NotImplementedException();
        }
    }
}
