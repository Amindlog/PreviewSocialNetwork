using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Models
{
    public class ConfigurationAppModel
    {
        public TelegramConfig TelegramConfig { get; set; }
        public VkConfig VkConfig { get; set; }
    }
}
