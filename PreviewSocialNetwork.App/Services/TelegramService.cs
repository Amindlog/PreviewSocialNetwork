﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreviewSocialNetwork.Domain.Interfaces;
using PreviewSocialNetwork.Domain.Models;

namespace PreviewSocialNetwork.App.Services
{
    public class TelegramService : IServiceSocialNetwork, IAuth
    {
        public bool SendSocialNetwork(IMessagePreview message)
        {
            throw new NotImplementedException();
        }

        public bool LoginAuthorization(User user)
        {
            throw new NotImplementedException();
        }
    }
}
