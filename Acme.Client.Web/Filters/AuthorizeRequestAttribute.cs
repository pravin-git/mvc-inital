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
            string actionName = filterContext.ActionDescriptor.ActionName;
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            object[] actionMethodSelectors = filterContext.ActionDescriptor.GetCustomAttributes(typeof(ActionMethodSelectorAttribute), true);

            string verb = actionMethodSelectors[0].GetType().Name;

            if (controllerName == "Important")
            {
                throw new UnauthorizedAccessException();
            }
            

            //throw new UnauthorizedAccessException("Access Denied");
        }
    }
}