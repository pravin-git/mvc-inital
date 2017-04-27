using Acme.Client.Web.Filters;
using Acme.Client.Web.Security;
using Acme.Client.Web.WebHelper;
using Acme.Common.DataContract;
using Acme.Common.Logger;
using Acme.Service.Contract;
using Acme.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acme.Client.Web.Controllers
{
    [LayoutInjector("_Layout")]
    public class AccountController : Controller
    {
        IUserService userService;
        IWebAuthenticate formAuthetication;
        IWebStore sessionManager;
        ILogger logger;

        public AccountController(IUserService userService, IWebAuthenticate formAuthetication, IWebStore sessionManager, ILogger logger)
        {
            this.userService = userService;
            this.formAuthetication = formAuthetication;
            this.sessionManager = sessionManager;
            this.logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            logger.Log("My First Log");
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(UserLogin userLogin)
        {
            bool isAuthenticated = userService.IsUserValid(userLogin);
            if (isAuthenticated)
            {
                formAuthetication.SignIn(userLogin.UserName);
                sessionManager.UserContext = userService.GetUserContext(userLogin.UserName);
                if (sessionManager.UserContext.UserRoles.Any(r => r.RoleName == "Administrator"))
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if (sessionManager.UserContext.UserRoles.Any(r => r.RoleName == "Normal User"))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "UnAuthorized");
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            formAuthetication.Signout();
            return RedirectToAction("Login");
        }
    }
}