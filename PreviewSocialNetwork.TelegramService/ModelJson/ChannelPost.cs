using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PreviewSocialNetwork.TelegramService.ModelJson
{
    public class ChannelPost
    {
        [JsonProperty("message_id")]
        public int MessageId { get; set; }

        [JsonProperty("sender_chat")]
        public SenderChat SenderChat { get; set; }

        [JsonProperty("chat")]
        public Chat Chat { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("entities")]
        public List<Entity> Entities { get; set; }
    }
}
