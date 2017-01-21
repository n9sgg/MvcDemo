using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Home Page";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "ABOUT  MESSAGE";
            return View(); 
        }
    }
}