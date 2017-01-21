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
    public class AccessoriesController : Controller
    {
        private AccessorieDBContext db = new AccessorieDBContext();

        //
        // GET: /Accessories/

        public ViewResult Index()
        {
            return View(db.Accessories.ToList());
        }

        //
        // GET: /Accessories/Details/5

        public ViewResult Details(int id)
        {
            AccessorieDB accessoriedb = db.Accessories.Find(id);
            return View(accessoriedb);
        }

        //
        // GET: /Accessories/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Accessories/Create

        [HttpPost]
        public ActionResult Create(AccessorieDB accessoriedb)
        {
            if (ModelState.IsValid)
            {
                db.Accessories.Add(accessoriedb);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(accessoriedb);
        }
        
        //
        // GET: /Accessories/Edit/5
 
        public ActionResult Edit(int id)
        {
            AccessorieDB accessoriedb = db.Accessories.Find(id);
            return View(accessoriedb);
        }

        //
        // POST: /Accessories/Edit/5

        [HttpPost]
        public ActionResult Edit(AccessorieDB accessoriedb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessoriedb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessoriedb);
        }

        //
        // GET: /Accessories/Delete/5
 
        public ActionResult Delete(int id)
        {
            AccessorieDB accessoriedb = db.Accessories.Find(id);
            return View(accessoriedb);
        }

        //
        // POST: /Accessories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            AccessorieDB accessoriedb = db.Accessories.Find(id);
            db.Accessories.Remove(accessoriedb);
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