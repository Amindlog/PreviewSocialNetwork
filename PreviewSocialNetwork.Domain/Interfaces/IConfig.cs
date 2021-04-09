using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    /// <summary>
    /// Интерфейс получения конфигурации в сервисах.
    /// </summary>
    public interface IConfig
    {
        /// <summary>
        /// Коллекция ключ, значение конфигурации.
        /// </summary>
       Dictionary<string, string> Configuration { get; set; }
    }
}
