﻿using System;
using System.Threading;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace UptalentFramework.Localization
{
    public static class LocalizationConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "Account", // Route name
                "Account/{action}", // URL with parameters
                new { controller = "Account", action = "Index" } // Parameter defaults
            );

            routes.MapRoute(
                Constants.RouteName, // Route name
                string.Format("{{{0}}}/{{controller}}/{{action}}/{{id}}", Constants.RouteParamnameLang), // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        public static void RegisterResourceProvider(Func<ILocalizationResourceProvider> initializer)
        {
            LocalizationResourceProvider.RegisterResourceProvider(initializer);
            LocalizationResourceProvider.RegisterCultureNameResolver(() => Thread.CurrentThread.CurrentUICulture.Name);
        }

        public static void RegisterResourceProvider(Func<ILocalizationResourceProvider> initializer, Func<string> cultureNameResolver)
        {
            LocalizationResourceProvider.RegisterResourceProvider(initializer);
            LocalizationResourceProvider.RegisterCultureNameResolver(cultureNameResolver);
        }

        public static void RegisterModelProviders()
        {
            // register the model metadata provider
            ModelMetadataProviders.Current = new LocalizableDataAnnotationsModelMetadataProvider();

            // register the model validation provider
            var provider = ModelValidatorProviders.Providers.Where(p => p.GetType() == typeof(DataAnnotationsModelValidatorProvider)).FirstOrDefault();
            if (provider != null)
            {
                ModelValidatorProviders.Providers.Remove(provider);
            }
            provider = new LocalizableDataAnnotationsModelValidatorProvider();
            ModelValidatorProviders.Providers.Add(provider);
        }
    }
}