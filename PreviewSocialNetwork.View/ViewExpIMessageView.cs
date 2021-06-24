using System;
using PreviewSocialNetwork.Domain.Interfaces;

namespace PreviewSocialNetwork.View
{
    public class ViewExpIMessageView : IMessageView
    {
        public void PrintLine(string text)
        {
            Console.Clear();
            Console.WriteLine(text);
        }

        public void SuccessSendMessage()
        {
            PrintLine("Все сообщения успешно отправлены.");
        }
        public void ErrorSendMessage(string messageError)
        {
            PrintLine($"Ошибка: {messageError}");
        }

    }
}