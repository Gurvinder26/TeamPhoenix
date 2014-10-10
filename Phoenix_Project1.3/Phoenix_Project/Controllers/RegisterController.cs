using Phoenix_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public ActionResult Register(Phoenix_Project.Models.User user)
        {
            
            if (ModelState.IsValid)
            {
                db.Users.Add(new Phoenix_Project.User
                {
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserEmail = user.UserEmail,
                    UserPhoneNo = user.UserPhoneNo,
                    UserAddress1 = user.UserAddress1,
                    UserAddress2 = user.UserAddress2,
                    UserCity = user.UserCity,
                    UserProvince = user.UserProvince,
                    UserPostal = user.UserPostal,
                    Password = user.Password
                
                       });
                db.SaveChanges();
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Index", "Home");

            }
            return View("Register");
          
        }
	}
}