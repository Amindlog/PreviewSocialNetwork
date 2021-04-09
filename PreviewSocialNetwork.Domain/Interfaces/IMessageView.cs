using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    public interface IMessageView
    {
        void SuccessSendMessage();
        void ErrorSendMessage(string messageError);
        void PrintLine(string text);
    }
}
