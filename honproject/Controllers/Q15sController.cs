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
    public class Q15sController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Q1s
        public ActionResult Index()
        {
            return View(db.Q15s.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q15 q15 = db.Q15s.Find(id);
            if (q15 == null)
            {
                return HttpNotFound();
            }
            return View(q15);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Q15 q15)
        {
            if (ModelState.IsValid)
            {
                db.Q15s.Add(q15);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(q15);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q15 q15 = db.Q15s.Find(id);
            if (q15 == null)
            {
                return HttpNotFound();
            }
            return View(q15);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Q15 q15)
        {
            if (ModelState.IsValid)
            {
                db.Entry(q15).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(q15);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q15 q15 = db.Q15s.Find(id);
            if (q15 == null)
            {
                return HttpNotFound();
            }
            return View(q15);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Q15 q15 = db.Q15s.Find(id);
            db.Q15s.Remove(q15);
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