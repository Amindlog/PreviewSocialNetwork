using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    /// <summary>
    /// Интерфейс логики приложения.
    /// </summary>
    public interface ILogicServices
    {
        /// <summary>
        /// Свойство содержащее в себе сервис.
        /// </summary>
        IServiceSocialNetwork Service { get; }



        /// <summary>
        /// Метод парсинга строки для получения сервис отправки сообщения.
        /// </summary>
        /// <param name="message">Текст задачи.</param>
        /// <returns>1 - Telegram, 2 - Discord, 3 - Vk, 4 - Twitter</returns>
        List<int> ParserStringGetIssue(string message);

    }
}
