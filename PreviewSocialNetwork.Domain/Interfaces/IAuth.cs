using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreviewSocialNetwork.Domain.Models;

namespace PreviewSocialNetwork.Domain.Interfaces
{
    public interface IAuth
    {
        bool LoginAuthorization(User user);
    }
}
