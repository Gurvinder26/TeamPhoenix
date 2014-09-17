using Phoenix_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Phoenix_Project.Controllers
{
    public class RegisterController : Controller
    {
       private Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();
        // GET: /Register/
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                FormsAuthentication.SetAuthCookie(user.UserName, false);
            }
           
            return RedirectToAction("Index");
        }
	}
}