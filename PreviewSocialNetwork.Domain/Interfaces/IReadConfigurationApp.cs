using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    /// <summary>
    /// Интерфес чтения конфигурационного файла.
    /// </summary>
    public interface IReadConfigurationApp : IConfig
    {
        /// <summary>
        /// Метод чтения конфигурации из файла.
        /// </summary>
        /// <returns>true - конфигурация загружена, false - ошибка чтения.</returns>
        bool ReadConfigurationTask();
    }
}
