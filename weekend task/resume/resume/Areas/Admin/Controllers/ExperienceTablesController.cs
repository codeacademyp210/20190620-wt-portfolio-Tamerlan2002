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
    public class ExperienceTablesController : Controller
    {
        private ResumeContext db = new ResumeContext();

        // GET: Admin/ExperienceTables
        public ActionResult Index()
        {
            return View(db.ExperienceTables.ToList());
        }

        // GET: Admin/ExperienceTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExperienceTable experienceTable = db.ExperienceTables.Find(id);
            if (experienceTable == null)
            {
                return HttpNotFound();
            }
            return View(experienceTable);
        }

        // GET: Admin/ExperienceTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ExperienceTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StartTime,FinishTime,Place,City,Position,About")] ExperienceTable experienceTable)
        {
            if (ModelState.IsValid)
            {
                db.ExperienceTables.Add(experienceTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(experienceTable);
        }

        // GET: Admin/ExperienceTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExperienceTable experienceTable = db.ExperienceTables.Find(id);
            if (experienceTable == null)
            {
                return HttpNotFound();
            }
            return View(experienceTable);
        }

        // POST: Admin/ExperienceTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StartTime,FinishTime,Place,City,Position,About")] ExperienceTable experienceTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(experienceTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(experienceTable);
        }

        // GET: Admin/ExperienceTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExperienceTable experienceTable = db.ExperienceTables.Find(id);
            if (experienceTable == null)
            {
                return HttpNotFound();
            }
            return View(experienceTable);
        }

        // POST: Admin/ExperienceTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExperienceTable experienceTable = db.ExperienceTables.Find(id);
            db.ExperienceTables.Remove(experienceTable);
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
