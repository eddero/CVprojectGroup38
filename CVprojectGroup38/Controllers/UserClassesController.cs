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
    public class UserClassesController : Controller
    {
        private Data.ApplicationDbContext db = new Data.ApplicationDbContext();

       
        #region Edvin codes

        //test edvin
        public ActionResult Index1(int projectId)
        {
            
            var userList = db.UserClasses.Where(proj => proj.WorkOnProject == projectId).ToList();

            return View(userList);
        }


        //Test edvin
        public ActionResult Details1(int id)
        {
            var user = db.UserClasses.Single(usr => usr.Id == id);

            return View(user);
        }

        #endregion

        // GET: UserClasses
        public ActionResult Index()
        {
            return View(db.UserClasses.ToList());
        }


        // GET: UserClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserClass userClass = db.UserClasses.Find(id);
            if (userClass == null)
            {
                return HttpNotFound();
            }
            return View(userClass);
        }


        // GET: UserClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserName,UserPassword,WorkOnProject")] UserClass userClass)
        {
            if (ModelState.IsValid)
            {
                
                db.UserClasses.Add(userClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userClass);

        }

        // GET: UserClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserClass userClass = db.UserClasses.Find(id);
            if (userClass == null)
            {
                return HttpNotFound();
            }
            return View(userClass);
        }

        // POST: UserClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserName,UserPassword")] UserClass userClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userClass);
        }

        // GET: UserClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserClass userClass = db.UserClasses.Find(id);
            if (userClass == null)
            {
                return HttpNotFound();
            }
            return View(userClass);
        }

        // POST: UserClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserClass userClass = db.UserClasses.Find(id);
            db.UserClasses.Remove(userClass);
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
