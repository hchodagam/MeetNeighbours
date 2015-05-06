using Castle.Windsor;
using meetneighbours.web.DI_IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace meetneighbours.web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private IWindsorContainer container;

        public MvcApplication()
        {
            this.container =
                new WindsorContainer().Install(new DependencyInstaller());

          
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var controllerFactory = new ControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
            GlobalConfiguration.Configuration.Services.Replace(
             typeof(IHttpControllerActivator),
             new WindsorActivator(this.container));
        }
    }
}
