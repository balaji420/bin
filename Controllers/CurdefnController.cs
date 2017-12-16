using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CurApi.Models;

namespace CurApi.Controllers
{
    public class CurdefnController : Controller
    {
        private CurApiContext db = new CurApiContext();

        // GET: Curdefn
        public ActionResult Index()
        {
            return View(db.ProFaCurdef.ToList());
       

        }

        // GET: Curdefn/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProFaCurdef curdef = db.ProFaCurdef.Find(id);
            if (curdef == null)
            {
                return HttpNotFound();
            }
            return View(curdef);
        }

        // GET: Curdefn/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curdefn/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GnmPK,GnmCd,GnmDesc,GnmDispNm,GnmSecCur")] ProFaCurdef curdef)
        {
            if (ModelState.IsValid)
            {
                db.ProFaCurdef.Add(curdef);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curdef);
        }

        // GET: Curdefn/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProFaCurdef curdef = db.ProFaCurdef.Find(id);
            if (curdef == null)
            {
                return HttpNotFound();
            }
            return View(curdef);
        }

        // POST: Curdefn/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GnmPK,GnmCd,GnmDesc,GnmDispNm,GnmSecCur")] ProFaCurdef curdef)
        {
            if (ModelState.IsValid)
            {
                db.Entry(curdef).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(curdef);
        }

        // GET: Curdefn/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProFaCurdef curdef = db.ProFaCurdef.Find(id);
            if (curdef == null)
            {
                return HttpNotFound();
            }
            return View(curdef);
        }

        // POST: Curdefn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ProFaCurdef curdef = db.ProFaCurdef.Find(id);
            db.ProFaCurdef.Remove(curdef);
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
