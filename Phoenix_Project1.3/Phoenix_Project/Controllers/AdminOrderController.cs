using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phoenix_Project.Controllers
{
     [Authorize(Users = "sing1205")]
    public class AdminOrderController : Controller
    {
        private Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();
        //
        // GET: /AdminOrder/
        public ActionResult Index()
        {

            ViewBag.MenuItems = db.MenuItems.ToList();
            var placedOrders = from ords in db.OrderPlaceds
                               where ords.OrderStatus == "Placed"
                               select ords;
            return View(placedOrders);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "AdminOrder");
            }
            else
            {
                OrderPlaced order = db.OrderPlaceds.Find(id);

                var userid = from user in db.Users
                             where user.UserId == order.UserId
                             select user;

                ViewBag.UserInfo = userid;
                return View(order);
            }
        }
        public ActionResult OrderDone(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "AdminOrder");
            }
            else
            {
                var order = from ord in db.OrderPlaceds
                            where ord.OrderNo == id
                            select ord;

                foreach (OrderPlaced order1 in order)
                {
                    order1.OrderStatus = "Done";
                    order1.OrderDoneTime = DateTime.Now.Date;
                }

                db.SaveChanges();

                return RedirectToAction("Index", "AdminOrder");
            }
        }
        public ActionResult CompletedOrders()
        {

            ViewBag.MenuItems = db.MenuItems.ToList();
            var placedOrders = from ords in db.OrderPlaceds
                               where ords.OrderStatus == "Done"
                               select ords;
            return View(placedOrders);
        }

	}
}