using PreviewSocialNetwork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.App.Services
{
    public class AuthService
    {
        public static Dictionary<int, User> TrueAuth { get; set; }
    }
}
