using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{ 
    public class ChairsController : Controller
    {
        private ChairDBContext db = new ChairDBContext();

        //
        // GET: /Chairs/

        public ViewResult Index()
        {
            return View(db.Chairs.ToList());
        }

        //
        // GET: /Chairs/Details/5

        public ViewResult Details(int id)
        {
            ChairDB chairdb = db.Chairs.Find(id);
            return View(chairdb);
        }

        //
        // GET: /Chairs/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Chairs/Create

        [HttpPost]
        public ActionResult Create(ChairDB chairdb)
        {
            if (ModelState.IsValid)
            {
                db.Chairs.Add(chairdb);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(chairdb);
        }
        
        //
        // GET: /Chairs/Edit/5
 
        public ActionResult Edit(int id)
        {
            ChairDB chairdb = db.Chairs.Find(id);
            return View(chairdb);
        }

        //
        // POST: /Chairs/Edit/5

        [HttpPost]
        public ActionResult Edit(ChairDB chairdb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chairdb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chairdb);
        }

        //
        // GET: /Chairs/Delete/5
 
        public ActionResult Delete(int id)
        {
            ChairDB chairdb = db.Chairs.Find(id);
            return View(chairdb);
        }

        //
        // POST: /Chairs/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ChairDB chairdb = db.Chairs.Find(id);
            db.Chairs.Remove(chairdb);
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