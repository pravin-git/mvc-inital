using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acme.Client.Web.Controllers
{
    public class UnAuthorizedController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}