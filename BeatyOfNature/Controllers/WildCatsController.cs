using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeatyOfNature.Models;
using System.IO;


namespace BeatyOfNature.Controllers
{ 
    public class WildCatsController : Controller
    {
        
        private WildCatsDataContext db = new WildCatsDataContext();
        string path = null;
        //
        // GET: /WildCats/

        public ViewResult Index()
        {
            return View(db.WildCats.ToList());
        }

        //
        // GET: /WildCats/Details/5

        public ViewResult Details(int id)
        {
            WildCat wildcat = db.WildCats.Find(id);
            return View(wildcat);
        }

        //
        // GET: /WildCats/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /WildCats/Create

        [HttpPost]
        public ActionResult Create(WildCat wildcat, HttpPostedFileBase ImageUrl)
        {
            if (ModelState.IsValid)
            {
                //try
                //{
                //    var fileName = Path.GetFileName(ImageUrl.FileName);
                //    //path = AppDomain.CurrentDomain.BaseDirectory + "Images\\" + fileName;
                //    path = HttpContext.Server.MapPath("~/UserContent/" + fileName);
                //    ImageUrl.SaveAs(path);
                   
                // }
                //catch {
                //    ViewBag.errorMessage = "Upload Fail";
                //}
                //wildcat.ImageUrl = path;
                db.WildCats.Add(wildcat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wildcat);
        }
       
        //
        // GET: /WildCats/Edit/5
 
        public ActionResult Edit(int id)
        {
            WildCat wildcat = db.WildCats.Find(id);
            return View(wildcat);
        }

        //
        // POST: /WildCats/Edit/5

        [HttpPost]
        public ActionResult Edit(WildCat wildcat)
        {
            if (ModelState.IsValid)
            {
                
                db.Entry(wildcat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wildcat);
        }

        //
        // GET: /WildCats/Delete/5
 
        public ActionResult Delete(int id)
        {
            WildCat wildcat = db.WildCats.Find(id);
            return View(wildcat);
        }

        //
        // POST: /WildCats/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WildCat wildcat = db.WildCats.Find(id);
            db.WildCats.Remove(wildcat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
    
}