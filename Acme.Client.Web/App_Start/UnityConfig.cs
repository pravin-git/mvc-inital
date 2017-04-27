using Acme.Client.Web.Factory;
using Acme.Client.Web.Security;
using Acme.Client.Web.WebHelper;
using Acme.Service.Contract;
using Acme.Service.Implementation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acme.Client.Web
{
    public static class UnityConfig
    {

        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container, DependencyResolver.Current));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IWebAuthenticate, FormAuthentication>();
            container.RegisterType<IWebStore, SessionManager>();

            return container;
        }  
      
    }
}