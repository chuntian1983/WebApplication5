using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class teachersController : Controller
    {
        private TeacherDbcontent db = new TeacherDbcontent();

        // GET: teachers
        public ActionResult Index()
        {
            //return View(db.teachers.OrderBy(teacher=>teacher.id).ToList());
           return View(db.teachers.OrderByDescending(teacher=>teacher.id).ToList());
        }

        // GET: teachers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teacher teacher = db.teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // GET: teachers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: teachers/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,strname,tel,creattime")] teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.teachers.Add(teacher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teacher);
        }

        // GET: teachers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teacher teacher = db.teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: teachers/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,strname,tel,creattime")] teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        // GET: teachers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teacher teacher = db.teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            teacher teacher = db.teachers.Find(id);
            db.teachers.Remove(teacher);
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
