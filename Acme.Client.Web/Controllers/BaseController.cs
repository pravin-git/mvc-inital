using Acme.Client.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acme.Client.Web.Controllers
{
    [Authenticate (Order=1)]
    [AuthorizeRequest(Order = 2)]
    [HandleException(Order = 3)]
    public class BaseController : Controller
    {
    }
}