using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    public interface IMessagePreview
    {
        /// <summary>
        /// Текст отправляемого сообщения.
        /// </summary>
        string MessageText { get; }
        /// <summary>
        /// Время отправленного сообщения.
        /// </summary>
        string TimeMessage { get; }
    }
}
