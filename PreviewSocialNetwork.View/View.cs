using System;

namespace PreviewSocialNetwork.View
{
    public class View
    {
        static public void PrintLine(string text)
        {
            Console.WriteLine(text);
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