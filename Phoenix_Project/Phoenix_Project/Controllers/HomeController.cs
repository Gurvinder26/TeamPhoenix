using Phoenix_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phoenix_Project.Controllers
{
    public class HomeController : Controller
    {
        private Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();
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

        
        public ActionResult Gallery()
        {
            ViewBag.Message = "Your Gallery page.";

            return View();
        }


        public ActionResult Order()
        {
            ViewBag.Message = "Your Order page.";

            return View();
        }

        public ActionResult Catering()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Catering(Booking user)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Bookings.Add(user);
            //    db.SaveChanges();

            //    return View("Order","Home");
            //}
            return RedirectToAction("index");
        }
    }
}
