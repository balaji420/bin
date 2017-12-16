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
    public class CurconfigController : Controller
    {
        private CurApiContext db = new CurApiContext();

        // GET: Curconfig
        public ActionResult Index()
        {
            return View(db.profacurconvconfig.ToList());
        }

        //public ViewResult Index()
        //{
        //    return View(db.profacurconvconfig.ToList());
        //}


        // GET: Curconfig/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            curconvconfig curconvconfig = db.profacurconvconfig.Find(id);
            if (curconvconfig == null)
            {
                return HttpNotFound();
            }
            return View(curconvconfig);
        }

        // GET: Curconfig/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curconfig/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CrvPk,CrvLocFk,CrvBasCurFk,CrvConCurFk,CrvByRt,CrvSelRt,CrvEffFrm,CrvEffTo,CrvConvVal,CrvCutOffTm,CrvFcr1,CrvFcr2,CrvFcr3,CrvRowid,CrvCreatedBy,CrvCreatedDt,CrvModifiedBy,CrvModifiedDt,CrvDelFlg,CrvDelId")] curconvconfig curconvconfig)
        {
            if (ModelState.IsValid)
            {
                db.profacurconvconfig.Add(curconvconfig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curconvconfig);
        }

        // GET: Curconfig/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            curconvconfig curconvconfig = db.profacurconvconfig.Find(id);
            if (curconvconfig == null)
            {
                return HttpNotFound();
            }
            return View(curconvconfig);
        }

        // POST: Curconfig/Edit/5
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

        // GET: Curconfig/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            curconvconfig curconvconfig = db.profacurconvconfig.Find(id);
            if (curconvconfig == null)
            {
                return HttpNotFound();
            }
            return View(curconvconfig);
        }

        // POST: Curconfig/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            curconvconfig curconvconfig = db.profacurconvconfig.Find(id);
            db.profacurconvconfig.Remove(curconvconfig);
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
