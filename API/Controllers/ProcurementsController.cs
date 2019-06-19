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
using BusinessLogic.Service;
using DataAccess.Context;
using DataAccess.Models;

namespace API.Controllers
{
    public class ProcurementsController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly IProcurementService iProcurementService;
        public ProcurementsController() { }
        public ProcurementsController(IProcurementService _iProcurementService)
        {
            iProcurementService = _iProcurementService;
        }
        // GET: api/Procurements
        public List<Procurement> GetProcurements()
        {
            return iProcurementService.Get();
        }

        // GET: api/Procurements/5
        [ResponseType(typeof(Procurement))]
        public IHttpActionResult GetProcurement(int id)
        {
            Procurement procurement = db.Procurements.Find(id);
            if (procurement == null)
            {
                return NotFound();
            }

            return Ok(procurement);
        }

        // PUT: api/Procurements/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProcurement(int id, Procurement procurement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != procurement.Id)
            {
                return BadRequest();
            }

            db.Entry(procurement).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcurementExists(id))
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

        // POST: api/Procurements
        [ResponseType(typeof(Procurement))]
        public IHttpActionResult PostProcurement(Procurement procurement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Procurements.Add(procurement);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = procurement.Id }, procurement);
        }

        // DELETE: api/Procurements/5
        [ResponseType(typeof(Procurement))]
        public IHttpActionResult DeleteProcurement(int id)
        {
            Procurement procurement = db.Procurements.Find(id);
            if (procurement == null)
            {
                return NotFound();
            }

            db.Procurements.Remove(procurement);
            db.SaveChanges();

            return Ok(procurement);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProcurementExists(int id)
        {
            return db.Procurements.Count(e => e.Id == id) > 0;
        }
    }
}