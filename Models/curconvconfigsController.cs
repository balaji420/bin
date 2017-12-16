using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CurApi.Models
{
    public class curconvconfigsController : Controller
    {
        private ConConfigContext db = new ConConfigContext();

        // GET: curconvconfigs
        public ActionResult Index()
        {
            return View(db.curconvconfigs.ToList());
        }

        // GET: curconvconfigs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            curconvconfig curconvconfig = db.curconvconfigs.Find(id);
            if (curconvconfig == null)
            {
                return HttpNotFound();
            }
            return View(curconvconfig);
        }

        // GET: curconvconfigs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: curconvconfigs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CrvPk,CrvLocFk,CrvBasCurFk,CrvConCurFk,CrvByRt,CrvSelRt,CrvEffFrm,CrvEffTo,CrvConvVal,CrvCutOffTm,CrvFcr1,CrvFcr2,CrvFcr3,CrvRowid,CrvCreatedBy,CrvCreatedDt,CrvModifiedBy,CrvModifiedDt,CrvDelFlg,CrvDelId")] curconvconfig curconvconfig)
        {
            if (ModelState.IsValid)
            {
                db.curconvconfigs.Add(curconvconfig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curconvconfig);
        }

        // GET: curconvconfigs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            curconvconfig curconvconfig = db.curconvconfigs.Find(id);
            if (curconvconfig == null)
            {
                return HttpNotFound();
            }
            return View(curconvconfig);
        }

        // POST: curconvconfigs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CrvPk,CrvLocFk,CrvBasCurFk,CrvConCurFk,CrvByRt,CrvSelRt,CrvEffFrm,CrvEffTo,CrvConvVal,CrvCutOffTm,CrvFcr1,CrvFcr2,CrvFcr3,CrvRowid,CrvCreatedBy,CrvCreatedDt,CrvModifiedBy,CrvModifiedDt,CrvDelFlg,CrvDelId")] curconvconfig curconvconfig)
        {
            if (ModelState.IsValid)
            {
                db.Entry(curconvconfig).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(curconvconfig);
        }

        // GET: curconvconfigs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            curconvconfig curconvconfig = db.curconvconfigs.Find(id);
            if (curconvconfig == null)
            {
                return HttpNotFound();
            }
            return View(curconvconfig);
        }

        // POST: curconvconfigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            curconvconfig curconvconfig = db.curconvconfigs.Find(id);
            db.curconvconfigs.Remove(curconvconfig);
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
