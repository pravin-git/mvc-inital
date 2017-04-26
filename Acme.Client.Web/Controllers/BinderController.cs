using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Acme.Common.DataContract;
using Acme.Client.Web.Filters;

namespace Acme.Client.Web.Controllers
{
    [LayoutInjector("_Layout")]
    public class BinderController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            ICollection<UserRole> lst = new List<UserRole>()
            {
                new UserRole
                {
                    RoleId = 1,
                    RoleName = "Sales"
                },
                new UserRole
                {
                    RoleId = 2,
                    RoleName = "Admin"
                },
                new UserRole
                {
                    RoleId = 3,
                    RoleName = "Supplier"
                }
            };
            
            return View(lst);
        }

        [HttpPost]
        public ActionResult Index(ICollection<UserRole> lst)
        {
            return RedirectToAction("Index", "Home");
        }

    }
}