using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    public interface IServiceSocialNetwork
    {
        /// <summary>
        /// Метод отправки сообщения на социальные сети.
        /// </summary>
        /// <param name="message">Анонс.</param>
        /// <returns>true - сообщение отправлено успешно, false - ошибка отправки.</returns>
        bool SendSocialNetwork(IMessagePreview message);

    }
}
