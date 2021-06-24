using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PreviewSocialNetwork.Domain.Interfaces;
using PreviewSocialNetwork.Domain.Models;
using PreviewSocialNetwork.View;

namespace PreviewSocialNetwork.App.Config
{
    public class ConfigService : IReadConfigurationApp
    {
        private IMessageView _messageView;
        public static List<TelegramConfig> TelegramConfigs { get; set; } = new List<TelegramConfig>();//сделано коллекцией для будущего
        public static List<VkConfig> VkConfigs { get; set; } = new List<VkConfig>();//сделано коллекцией для будущего

        public ConfigService()
        {
            _messageView = new ViewExpIMessageView();
            ReadConfigurationTask();
        }
        public bool ReadConfigurationTask()
        {
            if (!File.Exists("Config.json"))
            {
                _messageView.ErrorSendMessage("Нет файла конфигурации.");
            }

            try
            {

                using (var stream = new StreamReader("Config.json"))
                {
                    var temp = stream.ReadToEnd();
                    var configTempDeserializeObject = JsonConvert.DeserializeObject<ConfigurationAppModel>(temp);

                    TelegramConfigs.Add(configTempDeserializeObject.TelegramConfig);
                    VkConfigs.Add(configTempDeserializeObject.VkConfig);

                    return true;

                }
            }
            catch (Exception e)
            {
                _messageView.ErrorSendMessage(e.ToString());
                throw;
            }
        }

        public TelegramConfig GetTelegramConfig()//возвращаем конфиг данные
        {
            if (TelegramConfigs != null)
                return TelegramConfigs[0];

            return null;
        }

        public VkConfig GetVkConfig()//возвращаем конфиг данные
        {
            if (VkConfigs != null)
            {
                return VkConfigs[0];
            }

            return null;
        }
    }
}
