using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Models
{
    public class VkConfig
    {
        public ulong AppId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
