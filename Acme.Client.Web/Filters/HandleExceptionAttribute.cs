using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acme.Client.Web.Filters
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HandleExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string redirectUrl = "~/Error/Index";
            //Log filterContext.Exception here
            if (filterContext.ExceptionHandled)
            {
                return;
            }
            if (filterContext.Exception.GetType() == typeof(UnauthorizedAccessException))
            {

                redirectUrl = "~/UnAuthorized/Index";
            }
           
            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.Result = new RedirectResult(redirectUrl);
        }
    }
}