using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UptalentFramework.Localization;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = LocalizationResourceProvider.Current.GetString("Controller_HomeIndex_Message1");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = LocalizationResourceProvider.Current.GetString("Controller_HomeAbout_Message");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}