using honproject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using PagedList;
using PagedList.Mvc;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.Security;
using Microsoft.AspNet.Identity.EntityFramework;

namespace honproject.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ResponsesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Response
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "author_desc" : "";
            ViewBag.IDSortParm = sortOrder == "ID" ? "ID_desc" : "ID";

            if (searchString != null)
            {

            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var responses = from o in db.Responses
                            select o;

            if (!String.IsNullOrEmpty(searchString))
            {
                responses = responses.Where(s => s.Author.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "author_desc":
                    responses = responses.OrderByDescending(s => s.Author);
                    break;
                case "ID":
                    responses = responses.OrderBy(s => s.ID);
                    break;
                case "ID_desc":
                    responses = responses.OrderByDescending(s => s.ID);
                    break;
                default:  // Name ascending 
                    responses = responses.OrderBy(s => s.Author);
                    break;
            }


            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(responses.ToPagedList(pageNumber, pageSize));

        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Response response = db.Responses.Find(id);
            if (response == null)
            {
                return HttpNotFound();
            }

            return View(response);
        }

        public ActionResult Create()
        {
            ViewBag.Q1Id = new SelectList(db.Q1s, "ID", "Name");
            ViewBag.Q2Id = new SelectList(db.Q2s, "ID", "Name");
            ViewBag.Q3Id = new SelectList(db.Q3s, "ID", "Name");
            ViewBag.Q4Id = new SelectList(db.Q4s, "ID", "Name");
            ViewBag.Q5Id = new SelectList(db.Q5s, "ID", "Name");
            ViewBag.Q6Id = new SelectList(db.Q6s, "ID", "Name");
            ViewBag.Q7Id = new SelectList(db.Q7s, "ID", "Name");
            ViewBag.Q8Id = new SelectList(db.Q8s, "ID", "Name");
            ViewBag.Q9Id = new SelectList(db.Q9s, "ID", "Name");
            ViewBag.Q10Id = new SelectList(db.Q10s, "ID", "Name");
            ViewBag.Q11Id = new SelectList(db.Q11s, "ID", "Name");
            ViewBag.Q12Id = new SelectList(db.Q12s, "ID", "Name");
            ViewBag.Q13Id = new SelectList(db.Q13s, "ID", "Name");
            ViewBag.Q14Id = new SelectList(db.Q14s, "ID", "Name");
            ViewBag.Q15Id = new SelectList(db.Q15s, "ID", "Name");
            ViewBag.Q16Id = new SelectList(db.Q16s, "ID", "Name");
            ViewBag.Q17Id = new SelectList(db.Q17s, "ID", "Name");
            ViewBag.Q18Id = new SelectList(db.Q18s, "ID", "Name");
            ViewBag.Q19Id = new SelectList(db.Q19s, "ID", "Name");
            ViewBag.Q20Id = new SelectList(db.Q20s, "ID", "Name");
            ViewBag.Q21Id = new SelectList(db.Q21s, "ID", "Name");
            ViewBag.Q22Id = new SelectList(db.Q22s, "ID", "Name");
            ViewBag.Q23Id = new SelectList(db.Q23s, "ID", "Name");
            ViewBag.Q24Id = new SelectList(db.Q24s, "ID", "Name");
            ViewBag.Q25Id = new SelectList(db.Q25s, "ID", "Name");
            ViewBag.Q26Id = new SelectList(db.Q26s, "ID", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Q1Id,Q2Id,Q3Id,Q4Id,Q5Id,Q6Id,Q7Id,Q8Id,Q9Id,Q10Id,Q11Id, Q12Id, Q13Id, Q14Id, Q15Id, Q16Id, Q17Id, Q18Id, Q19Id, Q20Id, Q21Id, Q22Id, Q23Id, Q24Id, Q25Id, Q26Id")] Response response)
        {
            response.CreationDate = DateTime.Now;
            response.Author = User.Identity.Name;
            if (ModelState.IsValid)
            {
                db.Responses.Add(response);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Q1Id = new SelectList(db.Q1s, "ID", "Name", response.Q1Id);
            ViewBag.Q2Id = new SelectList(db.Q2s, "ID", "Name", response.Q2Id);
            ViewBag.Q3Id = new SelectList(db.Q3s, "ID", "Name", response.Q3Id);
            ViewBag.Q4Id = new SelectList(db.Q4s, "ID", "Name", response.Q4Id);
            ViewBag.Q5Id = new SelectList(db.Q5s, "ID", "Name", response.Q5Id);
            ViewBag.Q6Id = new SelectList(db.Q6s, "ID", "Name", response.Q6Id);
            ViewBag.Q7Id = new SelectList(db.Q7s, "ID", "Name", response.Q7Id);
            ViewBag.Q8Id = new SelectList(db.Q8s, "ID", "Name", response.Q8Id);
            ViewBag.Q9Id = new SelectList(db.Q9s, "ID", "Name", response.Q9Id);
            ViewBag.Q10Id = new SelectList(db.Q10s, "ID", "Name", response.Q10Id);
            ViewBag.Q11Id = new SelectList(db.Q11s, "ID", "Name", response.Q11Id);
            ViewBag.Q12Id = new SelectList(db.Q12s, "ID", "Name", response.Q12Id);
            ViewBag.Q13Id = new SelectList(db.Q13s, "ID", "Name", response.Q13Id);
            ViewBag.Q14Id = new SelectList(db.Q14s, "ID", "Name", response.Q14Id);
            ViewBag.Q15Id = new SelectList(db.Q15s, "ID", "Name", response.Q15Id);
            ViewBag.Q16Id = new SelectList(db.Q16s, "ID", "Name", response.Q16Id);
            ViewBag.Q17Id = new SelectList(db.Q17s, "ID", "Name", response.Q17Id);
            ViewBag.Q18Id = new SelectList(db.Q18s, "ID", "Name", response.Q18Id);
            ViewBag.Q19Id = new SelectList(db.Q19s, "ID", "Name", response.Q19Id);
            ViewBag.Q20Id = new SelectList(db.Q20s, "ID", "Name", response.Q20Id);
            ViewBag.Q21Id = new SelectList(db.Q21s, "ID", "Name", response.Q21Id);
            ViewBag.Q22Id = new SelectList(db.Q22s, "ID", "Name", response.Q22Id);
            ViewBag.Q23Id = new SelectList(db.Q23s, "ID", "Name", response.Q23Id);
            ViewBag.Q24Id = new SelectList(db.Q24s, "ID", "Name", response.Q24Id);
            ViewBag.Q25Id = new SelectList(db.Q25s, "ID", "Name", response.Q25Id);
            ViewBag.Q26Id = new SelectList(db.Q26s, "ID", "Name", response.Q26Id);
            return View(response);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Response response = db.Responses.Find(id);
            if (response == null)
            {
                return HttpNotFound();
            }
            ViewBag.Q1Id = new SelectList(db.Q1s, "ID", "Name", response.Q1Id);
            ViewBag.Q2Id = new SelectList(db.Q2s, "ID", "Name", response.Q2Id);
            ViewBag.Q3Id = new SelectList(db.Q3s, "ID", "Name", response.Q3Id);
            ViewBag.Q4Id = new SelectList(db.Q4s, "ID", "Name", response.Q4Id);
            ViewBag.Q5Id = new SelectList(db.Q5s, "ID", "Name", response.Q5Id);
            ViewBag.Q6Id = new SelectList(db.Q6s, "ID", "Name", response.Q6Id);
            ViewBag.Q7Id = new SelectList(db.Q7s, "ID", "Name", response.Q7Id);
            ViewBag.Q8Id = new SelectList(db.Q8s, "ID", "Name", response.Q8Id);
            ViewBag.Q9Id = new SelectList(db.Q9s, "ID", "Name", response.Q9Id);
            ViewBag.Q10Id = new SelectList(db.Q10s, "ID", "Name", response.Q10Id);
            ViewBag.Q11Id = new SelectList(db.Q11s, "ID", "Name", response.Q11Id);
            ViewBag.Q12Id = new SelectList(db.Q12s, "ID", "Name", response.Q12Id);
            ViewBag.Q13Id = new SelectList(db.Q13s, "ID", "Name", response.Q13Id);
            ViewBag.Q14Id = new SelectList(db.Q14s, "ID", "Name", response.Q14Id);
            ViewBag.Q15Id = new SelectList(db.Q15s, "ID", "Name", response.Q15Id);
            ViewBag.Q16Id = new SelectList(db.Q16s, "ID", "Name", response.Q16Id);
            ViewBag.Q17Id = new SelectList(db.Q17s, "ID", "Name", response.Q17Id);
            ViewBag.Q18Id = new SelectList(db.Q18s, "ID", "Name", response.Q18Id);
            ViewBag.Q19Id = new SelectList(db.Q19s, "ID", "Name", response.Q19Id);
            ViewBag.Q20Id = new SelectList(db.Q20s, "ID", "Name", response.Q20Id);
            ViewBag.Q21Id = new SelectList(db.Q21s, "ID", "Name", response.Q21Id);
            ViewBag.Q22Id = new SelectList(db.Q22s, "ID", "Name", response.Q22Id);
            ViewBag.Q23Id = new SelectList(db.Q23s, "ID", "Name", response.Q23Id);
            ViewBag.Q24Id = new SelectList(db.Q24s, "ID", "Name", response.Q24Id);
            ViewBag.Q25Id = new SelectList(db.Q25s, "ID", "Name", response.Q25Id);
            ViewBag.Q26Id = new SelectList(db.Q26s, "ID", "Name", response.Q26Id);
            return View(response);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Q1Id,Q2Id,Q3Id,Q4Id,Q5Id,Q6Id,Q7Id,Q8Id,Q9Id,Q10Id,Q11Id, Q12Id, Q13Id, Q14Id, Q15Id, Q16Id, Q17Id, Q18Id, Q19Id, Q20Id, Q21Id, Q22Id, Q23Id, Q24Id, Q25Id, Q26Id")] Response response)
        {
            response.CreationDate = DateTime.Now;
            response.Author = User.Identity.Name;
            if (ModelState.IsValid)
            {
                db.Entry(response).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Q1Id = new SelectList(db.Q1s, "ID", "Name", response.Q1Id);
            ViewBag.Q2Id = new SelectList(db.Q2s, "ID", "Name", response.Q2Id);
            ViewBag.Q3Id = new SelectList(db.Q3s, "ID", "Name", response.Q3Id);
            ViewBag.Q4Id = new SelectList(db.Q4s, "ID", "Name", response.Q4Id);
            ViewBag.Q5Id = new SelectList(db.Q5s, "ID", "Name", response.Q5Id);
            ViewBag.Q6Id = new SelectList(db.Q6s, "ID", "Name", response.Q6Id);
            ViewBag.Q7Id = new SelectList(db.Q7s, "ID", "Name", response.Q7Id);
            ViewBag.Q8Id = new SelectList(db.Q8s, "ID", "Name", response.Q8Id);
            ViewBag.Q9Id = new SelectList(db.Q9s, "ID", "Name", response.Q9Id);
            ViewBag.Q10Id = new SelectList(db.Q10s, "ID", "Name", response.Q10Id);
            ViewBag.Q11Id = new SelectList(db.Q11s, "ID", "Name", response.Q11Id);
            ViewBag.Q12Id = new SelectList(db.Q12s, "ID", "Name", response.Q12Id);
            ViewBag.Q13Id = new SelectList(db.Q13s, "ID", "Name", response.Q13Id);
            ViewBag.Q14Id = new SelectList(db.Q14s, "ID", "Name", response.Q14Id);
            ViewBag.Q15Id = new SelectList(db.Q15s, "ID", "Name", response.Q15Id);
            ViewBag.Q16Id = new SelectList(db.Q16s, "ID", "Name", response.Q16Id);
            ViewBag.Q17Id = new SelectList(db.Q17s, "ID", "Name", response.Q17Id);
            ViewBag.Q18Id = new SelectList(db.Q18s, "ID", "Name", response.Q18Id);
            ViewBag.Q19Id = new SelectList(db.Q19s, "ID", "Name", response.Q19Id);
            ViewBag.Q20Id = new SelectList(db.Q20s, "ID", "Name", response.Q20Id);
            ViewBag.Q21Id = new SelectList(db.Q21s, "ID", "Name", response.Q21Id);
            ViewBag.Q22Id = new SelectList(db.Q22s, "ID", "Name", response.Q22Id);
            ViewBag.Q23Id = new SelectList(db.Q23s, "ID", "Name", response.Q23Id);
            ViewBag.Q24Id = new SelectList(db.Q24s, "ID", "Name", response.Q24Id);
            ViewBag.Q25Id = new SelectList(db.Q25s, "ID", "Name", response.Q25Id);
            ViewBag.Q26Id = new SelectList(db.Q26s, "ID", "Name", response.Q26Id);
            return View(response);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Response response = db.Responses.Find(id);
            if (response == null)
            {
                return HttpNotFound();
            }
            return View(response);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Response response = db.Responses.Find(id);
            db.Responses.Remove(response);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}