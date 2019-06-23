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
    public class EducationTablesController : Controller
    {
        private ResumeContext db = new ResumeContext();

        // GET: Admin/EducationTables
        public ActionResult Index()
        {
            return View(db.EducationTables.ToList());
        }

        // GET: Admin/EducationTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationTables educationTables = db.EducationTables.Find(id);
            if (educationTables == null)
            {
                return HttpNotFound();
            }
            return View(educationTables);
        }

        // GET: Admin/EducationTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/EducationTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon,Univeristy,Faculty,StartingYear,FinishingYear")] EducationTables educationTables)
        {
            if (ModelState.IsValid)
            {
                db.EducationTables.Add(educationTables);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(educationTables);
        }

        // GET: Admin/EducationTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationTables educationTables = db.EducationTables.Find(id);
            if (educationTables == null)
            {
                return HttpNotFound();
            }
            return View(educationTables);
        }

        // POST: Admin/EducationTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon,Univeristy,Faculty,StartingYear,FinishingYear")] EducationTables educationTables)
        {
            if (ModelState.IsValid)
            {
                db.Entry(educationTables).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(educationTables);
        }

        // GET: Admin/EducationTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationTables educationTables = db.EducationTables.Find(id);
            if (educationTables == null)
            {
                return HttpNotFound();
            }
            return View(educationTables);
        }

        // POST: Admin/EducationTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EducationTables educationTables = db.EducationTables.Find(id);
            db.EducationTables.Remove(educationTables);
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
