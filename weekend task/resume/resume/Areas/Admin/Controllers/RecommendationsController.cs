using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using resume.DAL;
using resume.Models;

namespace resume.Areas.Admin.Controllers
{
    public class RecommendationsController : Controller
    {
        private ResumeContext db = new ResumeContext();

        // GET: Admin/Recommendations
        public ActionResult Index()
        {
            return View(db.Recommendations.ToList());
        }

        // GET: Admin/Recommendations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recommendations recommendations = db.Recommendations.Find(id);
            if (recommendations == null)
            {
                return HttpNotFound();
            }
            return View(recommendations);
        }

        // GET: Admin/Recommendations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Recommendations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,Name,Work")] Recommendations recommendations)
        {
            if (ModelState.IsValid)
            {
                db.Recommendations.Add(recommendations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recommendations);
        }

        // GET: Admin/Recommendations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recommendations recommendations = db.Recommendations.Find(id);
            if (recommendations == null)
            {
                return HttpNotFound();
            }
            return View(recommendations);
        }

        // POST: Admin/Recommendations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,Name,Work")] Recommendations recommendations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recommendations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recommendations);
        }

        // GET: Admin/Recommendations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recommendations recommendations = db.Recommendations.Find(id);
            if (recommendations == null)
            {
                return HttpNotFound();
            }
            return View(recommendations);
        }

        // POST: Admin/Recommendations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recommendations recommendations = db.Recommendations.Find(id);
            db.Recommendations.Remove(recommendations);
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
