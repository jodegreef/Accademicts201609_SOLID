using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoCWeb.Controllers
{
    public class HomeController : Controller
    {
        private IHelloWorldService _service ;
        public HomeController(IHelloWorldService service)
        {
            _service = service;
        }

        public ActionResult Hello()
        {
            //return Content(new HelloWorldService().Hello());
            return Content(_service.Hello());
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}