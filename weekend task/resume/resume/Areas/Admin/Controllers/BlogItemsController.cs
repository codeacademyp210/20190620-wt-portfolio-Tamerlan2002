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
    public class BlogItemsController : Controller
    {
        private ResumeContext db = new ResumeContext();

        // GET: Admin/BlogItems
        public ActionResult Index()
        {
            return View(db.BlogItems.ToList());
        }

        // GET: Admin/BlogItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogItems blogItems = db.BlogItems.Find(id);
            if (blogItems == null)
            {
                return HttpNotFound();
            }
            return View(blogItems);
        }

        // GET: Admin/BlogItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/BlogItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PhotoPath,UpperTitle,Text,DateShared")] BlogItems blogItems)
        {
            if (ModelState.IsValid)
            {
                db.BlogItems.Add(blogItems);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blogItems);
        }

        // GET: Admin/BlogItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogItems blogItems = db.BlogItems.Find(id);
            if (blogItems == null)
            {
                return HttpNotFound();
            }
            return View(blogItems);
        }

        // POST: Admin/BlogItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PhotoPath,UpperTitle,Text,DateShared")] BlogItems blogItems)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blogItems).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogItems);
        }

        // GET: Admin/BlogItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogItems blogItems = db.BlogItems.Find(id);
            if (blogItems == null)
            {
                return HttpNotFound();
            }
            return View(blogItems);
        }

        // POST: Admin/BlogItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BlogItems blogItems = db.BlogItems.Find(id);
            db.BlogItems.Remove(blogItems);
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
