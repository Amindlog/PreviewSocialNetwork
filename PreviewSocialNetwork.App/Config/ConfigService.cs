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
        public Dictionary<string, string> Configuration { get; set; }

        public ConfigService()
        {
            _messageView = new ViewExpIMessageView();
        }
        public async Task<bool> ReadConfigurationTask()
        {
            if (File.Exists("~/StartProgram/Config.json"))
            {
                _messageView.ErrorSendMessage("Нет файла конфигурации.");
            }

            try
            {

                using (var stream = new StreamReader("~/StartProgram/Config.json"))
                {
                    var temp = await stream.ReadToEndAsync();
                    var config = JsonConvert.DeserializeObject<ConModel>(temp);
                    return true;

                }
            }
            catch (Exception e)
            {
                _messageView.ErrorSendMessage(e.ToString());
                throw;
            }

        }
    }
}
