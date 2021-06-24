using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreviewSocialNetwork.Domain.Models;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    /// <summary>
    /// Интерфейс получения конфигурации в сервисах.
    /// </summary>
    public interface IConfig
    {
        static List<TelegramConfig> TelegramConfigs { get; set; }
        static List<VkConfig> VkConfigs { get; set; }
        TelegramConfig GetTelegramConfig();
        VkConfig GetVkConfig();
    }
}
