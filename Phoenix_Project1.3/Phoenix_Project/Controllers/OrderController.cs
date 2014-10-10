using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phoenix_Project.Controllers
{

    public class OrderController : Controller
    {
        private Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();
        //
        // GET: /Order/
        [Authorize]
        public ActionResult Index()
        {
            return View(db.MenuItems.ToList());
        }

        public ActionResult Category(String category)
        {
            if (category == "")
            {
               var category1 = from categories in db.MenuItems
                           select categories;
               category = category1.First().Category;
            }
            ViewBag.CategoryName = category;
            return View(db.MenuItems.ToList());
           
        }
	}
}