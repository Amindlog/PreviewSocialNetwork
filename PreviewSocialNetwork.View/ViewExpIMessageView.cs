using System;
using PreviewSocialNetwork.Domain.Interfaces;

namespace PreviewSocialNetwork.View
{
    public class ViewExpIMessageView : IMessageView
    {
        public void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        public  void SuccessSendMessage()
        {
            Console.Clear();
            Console.WriteLine("Все сообщения успешно отправлены.");
        }
        public void ErrorSendMessage()
        {
            Console.Clear();
            Console.WriteLine("Не все сообщения были отправлены.");
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1 - Отправить сообщение:");
            Console.WriteLine("0 - Выйти из приложения.");
        }

        public  void InputText()
        {
            Console.Clear();
            PrintLine("Введите текст для отправки в соцсети:");
        }

        public  void PrintTextExitApp()
        {
            PrintLine("Приложение завершено.");
        }
    }
}