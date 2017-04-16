using Acme.Common.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acme.Client.Web.WebHelper
{
    public class SessionManager : IWebStore
    {
        public UserContext UserContext
        {
            get
            {
                return HttpContext.Current.Session["UserContext"] as UserContext;
            }
            set
            {
                HttpContext.Current.Session["UserContext"] = value;
            }
        }
    }
}