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
    public class LoaningsController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly ILoaningService iLoaningService;
        public LoaningsController() { }
        public LoaningsController(ILoaningService _iLoaningService)
        {
            iLoaningService = _iLoaningService;
        }

        // GET: api/Loanings
        public List<Loaning> GetLoanings()
        {
            return iLoaningService.Get();
        }

        // GET: api/Loanings/5
        [ResponseType(typeof(Loaning))]
        public IHttpActionResult GetLoaning(int id)
        {
            Loaning loaning = db.Loanings.Find(id);
            if (loaning == null)
            {
                return NotFound();
            }

            return Ok(loaning);
        }

        // PUT: api/Loanings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLoaning(int id, Loaning loaning)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != loaning.Id)
            {
                return BadRequest();
            }

            db.Entry(loaning).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaningExists(id))
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

        // POST: api/Loanings
        [ResponseType(typeof(Loaning))]
        public IHttpActionResult PostLoaning(Loaning loaning)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Loanings.Add(loaning);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = loaning.Id }, loaning);
        }

        // DELETE: api/Loanings/5
        [ResponseType(typeof(Loaning))]
        public IHttpActionResult DeleteLoaning(int id)
        {
            Loaning loaning = db.Loanings.Find(id);
            if (loaning == null)
            {
                return NotFound();
            }

            db.Loanings.Remove(loaning);
            db.SaveChanges();

            return Ok(loaning);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LoaningExists(int id)
        {
            return db.Loanings.Count(e => e.Id == id) > 0;
        }
    }
}