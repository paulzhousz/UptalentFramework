using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UptalentFramework.Localization;

namespace MVCTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // register the localization routes
            // note: this must be invoked before the RouteConfig.RegisterRoutes
            LocalizationConfig.RegisterRoutes(RouteTable.Routes);
            // specify the localiztion resource provider (and culture name resolver)
            LocalizationConfig.RegisterResourceProvider(() => new LocalizationDbResourceProvider());
            // register the localizable model providers
            LocalizationConfig.RegisterModelProviders();

            //IOC
            AutofacConfig.Register();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
