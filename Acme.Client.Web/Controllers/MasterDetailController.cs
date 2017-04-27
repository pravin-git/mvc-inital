using Acme.Client.Web.Filters;
using Acme.Common.DataContract;
using Acme.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acme.Client.Web.Controllers
{
    [LayoutInjector("_Layout")]
    public class MasterDetailController : BaseController
    {
        IUserService userService;

        public MasterDetailController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var viewModel = this.userService.GetAllUsers();
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult GetUser(int userId)
        {
            var model = this.userService.GetUserById(userId);
            return View("UserDetail", model);
        }
    }
}