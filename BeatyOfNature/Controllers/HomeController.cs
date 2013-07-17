using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeatyOfNature.Models;
namespace BeatyOfNature.Controllers
{
    public class HomeController : Controller
    {
        private WildCatsDataContext db = new WildCatsDataContext();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Beauty of Nature";

            return View(db.WildCats.ToList());
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
