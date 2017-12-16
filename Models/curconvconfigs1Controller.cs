using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CurApi.Models
{
    public class curconvconfigs1Controller : ApiController
    {
        private ConConfigContext db = new ConConfigContext();

        // GET: api/curconvconfigs1
        public IQueryable<curconvconfig> Getcurconvconfigs()
        {
            return db.curconvconfigs;
        }

        // GET: api/curconvconfigs1/5
        [ResponseType(typeof(curconvconfig))]
        public IHttpActionResult Getcurconvconfig(int id)
        {
            curconvconfig curconvconfig = db.curconvconfigs.Find(id);
            if (curconvconfig == null)
            {
                return NotFound();
            }

            return Ok(curconvconfig);
        }

        // PUT: api/curconvconfigs1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcurconvconfig(int id, curconvconfig curconvconfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != curconvconfig.CrvPk)
            {
                return BadRequest();
            }

            db.Entry(curconvconfig).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!curconvconfigExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/curconvconfigs1
        [ResponseType(typeof(curconvconfig))]
        public IHttpActionResult Postcurconvconfig(curconvconfig curconvconfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.curconvconfigs.Add(curconvconfig);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = curconvconfig.CrvPk }, curconvconfig);
        }

        // DELETE: api/curconvconfigs1/5
        [ResponseType(typeof(curconvconfig))]
        public IHttpActionResult Deletecurconvconfig(int id)
        {
            curconvconfig curconvconfig = db.curconvconfigs.Find(id);
            if (curconvconfig == null)
            {
                return NotFound();
            }

            db.curconvconfigs.Remove(curconvconfig);
            db.SaveChanges();

            return Ok(curconvconfig);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool curconvconfigExists(int id)
        {
            return db.curconvconfigs.Count(e => e.CrvPk == id) > 0;
        }
    }
}