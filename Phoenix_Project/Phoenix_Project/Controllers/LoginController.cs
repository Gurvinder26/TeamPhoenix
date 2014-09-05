using Phoenix_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Phoenix_Project.Controllers
{
    public class LoginController : Controller
    {
        private  Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Login user)
        {
            if (ModelState.IsValid)
            {

                //var login = from user2 in db.Users
                //           where user2.UserName == user.Username && user2.Password == user.Password
                //           select user2;

               

                //if (login.Count() == 1)
            if(user.Username == "sing1205" && user.Password=="123456")
                {

                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    
                   
                        return RedirectToAction("Index", "Home");
                    

                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username or Password");
                }
            }
            return View();
        }

	}
}