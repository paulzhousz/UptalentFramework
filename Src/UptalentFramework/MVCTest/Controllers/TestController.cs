using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTest.Service;
using UptalentFramework.Data;

namespace MVCTest.Controllers
{
    public class TestController : Controller
    {
        private ITestService _testService;
        // GET: Test
        public TestController(ITestService testService)
        {
            _testService = testService;
        }
        public ActionResult Index()
        {
            _testService.Method1();
            return View();
        }
    }
}