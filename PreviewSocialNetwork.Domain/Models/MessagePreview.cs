using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreviewSocialNetwork.Domain.Interfaces;

namespace PreviewSocialNetwork.Domain.Models
{
    public class MessagePreview : IMessagePreview
    {
        public string MessageText { get; }
        public string TimeMessage { get; }
    }
}
