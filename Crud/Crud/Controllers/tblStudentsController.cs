using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Crud.Models;

namespace Crud.Controllers
{
    public class tblStudentsController : Controller
    {
        private EFCrudEntities8 db = new EFCrudEntities8();

        // GET: tblStudents
        public ActionResult Index()
        {
            var tblStudents = db.tblStudents.Include(t => t.tblGrades);
           
            return View(tblStudents.ToList());
        }

        public JsonResult GetMarksList(int GradeId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<tblMark> markList = db.tblMark.Where(x => x.GradeId == GradeId).ToList();
            return Json(markList, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetStudentNames(string name)
        {
           
            db.Configuration.ProxyCreationEnabled = false;
            var StudentNames = db.tblStudents.Where(x => x.Name.Contains(name));

            return Json(StudentNames, JsonRequestBehavior.AllowGet);
        }



        // GET: tblStudents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStudents tblStudents = db.tblStudents.Find(id);
            if (tblStudents == null)
            {
                return HttpNotFound();
            }
            return View(tblStudents);
        }

        // GET: tblStudents/Create
        public ActionResult Create()
        {
          
           // ViewBag.GradeId = new SelectList(db.tblGrades, "Id", "Name");
            List<tblGrades> GradeList = db.tblGrades.ToList();
            ViewBag.Grades =new SelectList(GradeList, "Id", "Name");
            return View();
        }



        // POST: tblStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Regno,GradeId")] tblStudents tblStudents)
        {
            if (ModelState.IsValid)
            {
                db.tblStudents.Add(tblStudents);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GradeId = new SelectList(db.tblGrades, "Id", "Name", tblStudents.GradeId);
            return View(tblStudents);
        }

        // GET: tblStudents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStudents tblStudents = db.tblStudents.Find(id);
            if (tblStudents == null)
            {
                return HttpNotFound();
            }
            ViewBag.GradeId = new SelectList(db.tblGrades, "Id", "Name", tblStudents.GradeId);
            return View(tblStudents);
        }

        // POST: tblStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Regno,GradeId")] tblStudents tblStudents)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblStudents).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GradeId = new SelectList(db.tblGrades, "Id", "Name", tblStudents.GradeId);
            return View(tblStudents);
        }

        // GET: tblStudents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStudents tblStudents = db.tblStudents.Find(id);
            if (tblStudents == null)
            {
                return HttpNotFound();
            }
            return View(tblStudents);
        }

        // POST: tblStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblStudents tblStudents = db.tblStudents.Find(id);
            db.tblStudents.Remove(tblStudents);
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
