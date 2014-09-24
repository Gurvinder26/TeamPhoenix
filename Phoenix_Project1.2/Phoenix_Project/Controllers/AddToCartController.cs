using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Phoenix_Project;

namespace Phoenix_Project.Controllers
{[Authorize]
    public class AddToCartController : Controller
    {
        private Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();

        [HttpGet]
        public ActionResult Index(int id)
        {
            var item = from i in db.MenuItems
                       where i.Id == id
                       select i;
            return View(item);
        }

       
       
        // GET: /AddToCart/Details/5
        public ActionResult AddConfirmed(int id )
        {
            if (id.ToString() == "" )
            {
                return RedirectToAction("Index", "Home");
            }
         //   string x =  Convert.ToString(Request.Form["Quantity"]);
            string x = "2";
            var price1 = from i in db.MenuItems
                        where i.Id == id
                        select id;
            float totalPrice =  Convert.ToInt32(x) * price1.First();

            
            var user = from u in db.Users
                       where u.UserName == User.Identity.Name
                       select u;

            

            int userid = user.First().UserId;
          db.ShoppingCarts.Add(new ShoppingCart
            {
                ItemId = id,
                Price = totalPrice,
                UserId = userid,
                Quantity = Convert.ToInt32(x)
            });
            db.SaveChanges();
            return View();
        }
        public ActionResult OrderItem()
        {
           
            return View();
        }
        public ActionResult ViewShoppingCart()
        {
            var user = from u in db.Users
                       where u.UserName == User.Identity.Name
                       select u;
            var CartItems = from addedItems in db.ShoppingCarts
                            where addedItems.UserId == user.First().UserId
                            select addedItems;
            
            return View(CartItems);
        }
        
    }
}
