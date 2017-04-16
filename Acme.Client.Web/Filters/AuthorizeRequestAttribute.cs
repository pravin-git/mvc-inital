using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acme.Client.Web.Filters
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorizeRequestAttribute : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //throw new NotImplementedException();
        }
    }
}