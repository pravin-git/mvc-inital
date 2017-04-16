using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Acme.Client.Web.Security
{
    public class FormAuthentication : IWebAuthenticate
    {
        public void SignIn(string userName)
        {
            FormsAuthentication.SetAuthCookie(userName, true);
        }

        public void Signout()
        {
            FormsAuthentication.SignOut();
        }
    }
}