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
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Order");
            }
            var item = from i in db.MenuItems
                       where i.Id == id
                       select i;
            ViewBag.model2 = item;
            ViewBag.id = id;
            return View();
        }

       
       
        // GET: /AddToCart/Details/5
   [ActionName("Index")]
    [HttpPost]
        public ActionResult AddConfirmed(int id,[Bind(Include = "Quantity")] ShoppingCart shoppingcart)
        {
            
          Boolean itemExist = false;
            string x = shoppingcart.Quantity.ToString();
            var price1 = from i in db.MenuItems
                        where i.Id == id
                        select i.ItemPrice;
            double totalPrice =  Convert.ToInt32(x) * price1.First();
            
            var user = from u in db.Users
                       where u.UserName == User.Identity.Name
                       select u;
        int userid = user.First().UserId;

        var alreadyExist = from userItem in db.ShoppingCarts
                           where userItem.UserId == userid
                           select userItem;
                               
            foreach (var i in alreadyExist)
            {
                if (id == i.ItemId)
                {
                    itemExist = true;
                    break;
                }

            }

            if (itemExist == true)
            {
                var id1 = from x2 in db.ShoppingCarts
                          where x2.ItemId == id
                          select x2;

                double beforePrice = id1.First().Price;
                double nowPrice = beforePrice + totalPrice;

                int beforeQuantity = id1.First().Quantity;
                int nowQuantity = beforeQuantity + Convert.ToInt32(x);

              foreach (ShoppingCart item_ in id1)
{
                 item_.Price = nowPrice;
                item_.Quantity = nowQuantity;
}

              db.SaveChanges();
            ViewBag.item = price1.First().ToString();
            return View("AddConfirmed");
        }
            

    else{
          db.ShoppingCarts.Add(new ShoppingCart
            {
                ItemId = id,
                Price = totalPrice,
                UserId = userid,
                Quantity = Convert.ToInt32(x)
            });
          db.SaveChanges();
            ViewBag.item = price1.First().ToString();
            return View("AddConfirmed");
}
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
            int userId = user.First().UserId;
            var CartItems = from addedItems in db.ShoppingCarts
                            where addedItems.UserId == userId
                            select addedItems;

            ViewBag.model2 = db.MenuItems.ToList();
            ViewBag.Count = CartItems.Count();
            
            return View(CartItems);
        }

        public ActionResult Remove(int? id)
        {
           
            ShoppingCart menuitem = db.ShoppingCarts.Find(id);
            db.ShoppingCarts.Remove(menuitem);
            db.SaveChanges();

            return RedirectToAction("ViewShoppingCart");
        }

        public ActionResult OrderPlaced()
        {
            List<string> itemsMenu = new List<string>();
            var user = from u in db.Users
                       where u.UserName == User.Identity.Name
                       select u;
            int userId = user.First().UserId;
            var CartItems = from addedItems in db.ShoppingCarts
                            where addedItems.UserId == userId
                            select addedItems;
            double totalOrderPrice = 0;
            foreach (var citem in CartItems)
            {
                totalOrderPrice += citem.Price;
              
               itemsMenu.Add(citem.ItemId.ToString() +",");
                itemsMenu.Add(citem.Quantity.ToString() + ",");
            }

            String itemsIds="";
            foreach (string a in itemsMenu)
            {
                
               
                itemsIds += a;
            }

            db.OrderPlaceds.Add(new OrderPlaced
            {
              OrderDate = DateTime.Now.Date,
              UserId = userId,
              OrderStatus = "Placed",
              OrderPrice =totalOrderPrice,
              ItemIds = itemsIds,
              OrderTime = DateTime.Now.TimeOfDay
            });
           

            var menuitem = from itm in db.ShoppingCarts
                                    where itm.UserId == userId
                                    select itm;
            foreach (var mitm in menuitem)
            {
                db.ShoppingCarts.Remove(mitm);
              
            }
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        
    }
}
