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
    }
}