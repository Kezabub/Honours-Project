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
    public class Q25sController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Q1s
        public ActionResult Index()
        {
            return View(db.Q25s.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q25 q25 = db.Q25s.Find(id);
            if (q25 == null)
            {
                return HttpNotFound();
            }
            return View(q25);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Q25 q25)
        {
            if (ModelState.IsValid)
            {
                db.Q25s.Add(q25);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(q25);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q25 q25 = db.Q25s.Find(id);
            if (q25 == null)
            {
                return HttpNotFound();
            }
            return View(q25);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Q25 q25)
        {
            if (ModelState.IsValid)
            {
                db.Entry(q25).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(q25);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q25 q25 = db.Q25s.Find(id);
            if (q25 == null)
            {
                return HttpNotFound();
            }
            return View(q25);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Q25 q25 = db.Q25s.Find(id);
            db.Q25s.Remove(q25);
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