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
    public class TablesController : Controller
    {
        private TableDBContext db = new TableDBContext();

        //
        // GET: /Tables/

        public ViewResult Index()
        {
            return View(db.Tables.ToList());
        }

        //
        // GET: /Tables/Details/5

        public ViewResult Details(int id)
        {
            TableDB tabledb = db.Tables.Find(id);
            return View(tabledb);
        }

        //
        // GET: /Tables/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Tables/Create

        [HttpPost]
        public ActionResult Create(TableDB tabledb)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(tabledb);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(tabledb);
        }
        
        //
        // GET: /Tables/Edit/5
 
        public ActionResult Edit(int id)
        {
            TableDB tabledb = db.Tables.Find(id);
            return View(tabledb);
        }

        //
        // POST: /Tables/Edit/5

        [HttpPost]
        public ActionResult Edit(TableDB tabledb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabledb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tabledb);
        }

        //
        // GET: /Tables/Delete/5
 
        public ActionResult Delete(int id)
        {
            TableDB tabledb = db.Tables.Find(id);
            return View(tabledb);
        }

        //
        // POST: /Tables/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            TableDB tabledb = db.Tables.Find(id);
            db.Tables.Remove(tabledb);
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