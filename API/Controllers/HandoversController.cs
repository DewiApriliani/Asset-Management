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
using DataAccess.Context;
using DataAccess.Models;
using Common.Repository;
using BusinessLogic.Service;

namespace API.Controllers
{
    public class HandoversController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly IHandoverService iHandoverService;
        public HandoversController() { }
        public HandoversController(IHandoverService _iHandoverService)
        {
            iHandoverService = _iHandoverService;
        }
        
        // GET: api/Handovers
        public List<Handover> GetHandovers()
        {
            return iHandoverService.Get();
        }

        // GET: api/Handovers/5
        [ResponseType(typeof(Handover))]
        public IHttpActionResult GetHandover(int id)
        {
            Handover handover = db.Handovers.Find(id);
            if (handover == null)
            {
                return NotFound();
            }

            return Ok(handover);
        }

        // PUT: api/Handovers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHandover(int id, Handover handover)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != handover.Id)
            {
                return BadRequest();
            }

            db.Entry(handover).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HandoverExists(id))
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

        // POST: api/Handovers
        [ResponseType(typeof(Handover))]
        public IHttpActionResult PostHandover(Handover handover)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Handovers.Add(handover);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = handover.Id }, handover);
        }

        // DELETE: api/Handovers/5
        [ResponseType(typeof(Handover))]
        public IHttpActionResult DeleteHandover(int id)
        {
            Handover handover = db.Handovers.Find(id);
            if (handover == null)
            {
                return NotFound();
            }

            db.Handovers.Remove(handover);
            db.SaveChanges();

            return Ok(handover);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HandoverExists(int id)
        {
            return db.Handovers.Count(e => e.Id == id) > 0;
        }
    }
}