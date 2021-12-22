using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CVprojectGroup38.Data;
using CVprojectGroup38.Models;

namespace CVprojectGroup38.Controllers
{
    public class ProjectClassesController : Controller
    {
        private Data.ApplicationDbContext db = new Data.ApplicationDbContext();

        // GET: ProjectClasses
        public ActionResult Index()
        {
            return View(db.ProjectClasses.ToList());
        }

        public ActionResult Index1()
        {
            var projectList = db.ProjectClasses.ToList();

            return View(projectList);
        }

        // GET: ProjectClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectClass projectClass = db.ProjectClasses.Find(id);
            if (projectClass == null)
            {
                return HttpNotFound();
            }
            return View(projectClass);
        }

        // GET: ProjectClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Projectname")] ProjectClass projectClass)
        {
            if (ModelState.IsValid)
            {
                db.ProjectClasses.Add(projectClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectClass);
        }

        // GET: ProjectClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectClass projectClass = db.ProjectClasses.Find(id);
            if (projectClass == null)
            {
                return HttpNotFound();
            }
            return View(projectClass);
        }

        // POST: ProjectClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Projectname")] ProjectClass projectClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectClass);
        }

        // GET: ProjectClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectClass projectClass = db.ProjectClasses.Find(id);
            if (projectClass == null)
            {
                return HttpNotFound();
            }
            return View(projectClass);
        }

        // POST: ProjectClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectClass projectClass = db.ProjectClasses.Find(id);
            db.ProjectClasses.Remove(projectClass);
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
