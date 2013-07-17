using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeatyOfNature.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Beauty of Nature";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
    }
}
