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
        /// Свойство содержащее данные для авторизации.
        /// </summary>
        IAuth Authorization { get; }


        /// <summary>
        /// Метод парсинга строки для получения сервис отправки сообщения.
        /// </summary>
        /// <param name="message">Текст задачи.</param>
        /// <returns>1 - Telegram, 2 - Discord, 3 - Vk</returns>
        List<int> ParserStringGetIssue(string message);



        /// <summary>
        /// Метод авторизации в сервисах.
        /// </summary>
        /// <param name="auth">Интерфейс авторизации.</param>
        /// <returns>true - авторизация успешна, false - авторизация не прошла.</returns>
        bool AuthorizationServices(IAuth auth);




    }
}
