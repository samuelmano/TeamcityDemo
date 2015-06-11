using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamcityDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mano application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Mano contact page.";

            return View();
        }
    }
}