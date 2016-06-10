using Autofac.Integration.Mvc;
using BrickManager.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BrickManager.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            UseFeatureFolders();

            RegisterDependencies();
        }

        private void UseFeatureFolders()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new FeatureViewLocationRazorViewEngine());
        }

        private void RegisterDependencies()
        {
            var container = Bootstrap.Create(builder => {
                builder.RegisterControllers(typeof(MvcApplication).Assembly);
            });

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
