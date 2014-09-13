using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace UptalentFramework.Localization
{
    public class LocalizationControllerHelper
    {
        public static void OnBeginExecuteCore(Controller controller)
        {
            if (controller.RouteData.Values[Constants.RouteParamnameLang] != null &&
                !string.IsNullOrWhiteSpace(controller.RouteData.Values[Constants.RouteParamnameLang].ToString()))
            {
                // set the culture from the route data (url)
                var lang = controller.RouteData.Values[Constants.RouteParamnameLang].ToString();
                //if lang is not in support lang list,set lang=defaultlang
                if (!Constants.SupportLangsList.ContainsKey(lang))
                {
                    lang = Constants.DefaultLang;
                }

                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else
            {
                // load the culture info from the cookie
                var cookie = controller.HttpContext.Request.Cookies[Constants.CookieName];
                var langHeader = string.Empty;
                if (cookie != null)
                {
                    // set the culture by the cookie content
                    langHeader = cookie.Value;
                }
                else
                {
                    // set the culture by the location if not speicified
                    langHeader = controller.HttpContext.Request.UserLanguages[0];
                }

                if (!Constants.SupportLangsList.ContainsKey(langHeader))
                {
                    langHeader = Constants.DefaultLang;
                }
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(langHeader);
                // set the lang value into route data
                controller.RouteData.Values[Constants.RouteParamnameLang] = langHeader;
            }

            // save the location into cookie
            HttpCookie _cookie = new HttpCookie(Constants.CookieName, Thread.CurrentThread.CurrentUICulture.Name);
            _cookie.Expires = DateTime.Now.AddYears(1);
            controller.HttpContext.Response.SetCookie(_cookie);
        } 
    }
}