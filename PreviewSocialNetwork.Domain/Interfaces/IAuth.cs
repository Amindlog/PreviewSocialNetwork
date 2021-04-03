using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    public interface IAuth
    {
        
        /// <summary>
        /// Логин.
        /// </summary>
        string Login { get; }
        /// <summary>
        /// Пароль.
        /// </summary>
        string Password { get; }

        bool LoginAuthorization(string login, string password);
    }
}
