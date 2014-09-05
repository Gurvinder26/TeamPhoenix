using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phoenix_Project.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
	}
}