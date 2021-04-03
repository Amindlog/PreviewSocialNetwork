using PreviewSocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.App.Services
{
    public class MassagePreviewExpIMessagePreviw : IMessagePreview
    {
        string MessageText { get; }
    
        string TimeMessage { get; }
    }
}
