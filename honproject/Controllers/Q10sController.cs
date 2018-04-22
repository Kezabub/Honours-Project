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
    public class Q10sController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Q10s
        public ActionResult Index()
        {
            return View(db.Q10s.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q10 q10 = db.Q10s.Find(id);
            if (q10 == null)
            {
                return HttpNotFound();
            }
            return View(q10);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Q10 q10)
        {
            if (ModelState.IsValid)
            {
                db.Q10s.Add(q10);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(q10);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q10 q10 = db.Q10s.Find(id);
            if (q10 == null)
            {
                return HttpNotFound();
            }
            return View(q10);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Q10 q10)
        {
            if (ModelState.IsValid)
            {
                db.Entry(q10).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(q10);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Q10 q10 = db.Q10s.Find(id);
            if (q10 == null)
            {
                return HttpNotFound();
            }
            return View(q10);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Q10 q10 = db.Q10s.Find(id);
            db.Q10s.Remove(q10);
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