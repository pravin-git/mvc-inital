using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Client.Web.Security
{
    public interface IWebAuthenticate
    {
        void SignIn(string userName);
        void Signout();
    }
}
