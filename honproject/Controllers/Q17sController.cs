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
    public class Q17sController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Q1s
        public ActionResult Index()
        {
            return View(db.Q17s.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q17 q17 = db.Q17s.Find(id);
            if (q17 == null)
            {
                return HttpNotFound();
            }
            return View(q17);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Q17 q17)
        {
            if (ModelState.IsValid)
            {
                db.Q17s.Add(q17);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(q17);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q17 q17 = db.Q17s.Find(id);
            if (q17 == null)
            {
                return HttpNotFound();
            }
            return View(q17);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Q17 q17)
        {
            if (ModelState.IsValid)
            {
                db.Entry(q17).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(q17);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q17 q17 = db.Q17s.Find(id);
            if (q17 == null)
            {
                return HttpNotFound();
            }
            return View(q17);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Q17 q17 = db.Q17s.Find(id);
            db.Q17s.Remove(q17);
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