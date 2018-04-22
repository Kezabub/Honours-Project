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
    public class Q2sController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Q1s
        public ActionResult Index()
        {
            return View(db.Q2s.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q2 q2 = db.Q2s.Find(id);
            if (q2 == null)
            {
                return HttpNotFound();
            }
            return View(q2);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Q2 q2)
        {
            if (ModelState.IsValid)
            {
                db.Q2s.Add(q2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(q2);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q2 q2 = db.Q2s.Find(id);
            if (q2 == null)
            {
                return HttpNotFound();
            }
            return View(q2);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Q2 q2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(q2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(q2);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q2 q2 = db.Q2s.Find(id);
            if (q2 == null)
            {
                return HttpNotFound();
            }
            return View(q2);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Q2 q2 = db.Q2s.Find(id);
            db.Q2s.Remove(q2);
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