using System;

namespace PreviewSocialNetwork.View
{
    public class View
    {
        static public void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        static public void SuccessSendMessage()
        {
            Console.Clear();
            Console.WriteLine("Все сообщения успешно отправиелы.");
        }
        static public void ErrorSendMessage()
        {
            Console.Clear();
            Console.WriteLine("Не все сообщения были отправиелы.");
        }
        static public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1 - Отправить сообщение:");
            Console.WriteLine("0 - Выйти из приложения.");
        }

        static public void Action1()
        {
            Console.Clear();
            PrintLine("Введите текст для отправки в соцсети:");
        }

        static public void Action0()
        {
            PrintLine("Приложение завершено.");
        }
    }
}