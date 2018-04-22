using honproject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace honproject.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class Q12sController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Q1s
        public ActionResult Index()
        {
            return View(db.Q12s.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q12 q12 = db.Q12s.Find(id);
            if (q12 == null)
            {
                return HttpNotFound();
            }
            return View(q12);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Q12 q12)
        {
            if (ModelState.IsValid)
            {
                db.Q12s.Add(q12);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(q12);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q12 q12 = db.Q12s.Find(id);
            if (q12 == null)
            {
                return HttpNotFound();
            }
            return View(q12);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Q12 q12)
        {
            if (ModelState.IsValid)
            {
                db.Entry(q12).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(q12);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q12 q12 = db.Q12s.Find(id);
            if (q12 == null)
            {
                return HttpNotFound();
            }
            return View(q12);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Q12 q12 = db.Q12s.Find(id);
            db.Q12s.Remove(q12);
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