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
{
      [Authorize(Users="sing1205")]
    public class MenuItemController : Controller
    {
        private Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();

        // GET: /MenuItem/
        public ActionResult Index()
        {
            return View(db.MenuItems.ToList());
        }

        // GET: /MenuItem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItem menuitem = db.MenuItems.Find(id);
            if (menuitem == null)
            {
                return HttpNotFound();
            }
            return View(menuitem);
        }

        // GET: /MenuItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MenuItem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,ItemName,ItemDesc,ItemPrice,image,Category")] MenuItem menuitem)
        {
            if (ModelState.IsValid)
            {
                db.MenuItems.Add(menuitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuitem);
        }

        // GET: /MenuItem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItem menuitem = db.MenuItems.Find(id);
            if (menuitem == null)
            {
                return HttpNotFound();
            }
            return View(menuitem);
        }

        // POST: /MenuItem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,ItemName,ItemDesc,ItemPrice,image,Category")] MenuItem menuitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuitem);
        }

        // GET: /MenuItem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItem menuitem = db.MenuItems.Find(id);
            if (menuitem == null)
            {
                return HttpNotFound();
            }
            return View(menuitem);
        }

        // POST: /MenuItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuItem menuitem = db.MenuItems.Find(id);
            db.MenuItems.Remove(menuitem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
