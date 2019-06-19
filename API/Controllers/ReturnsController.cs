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
    public class ReturnsController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly IReturnService iReturnService;
        public ReturnsController() { }
        public ReturnsController(IReturnService _iReturnService)
        {
            iReturnService = _iReturnService;
        }

        // GET: api/Return
        public List<Return> GetReturns()
        {
            return iReturnService.Get();
        }

        // GET: api/Returns/5
        [ResponseType(typeof(Return))]
        public IHttpActionResult GetReturn(int id)
        {
            Return @return = db.Returns.Find(id);
            if (@return == null)
            {
                return NotFound();
            }

            return Ok(@return);
        }

        // PUT: api/Returns/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReturn(int id, Return @return)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @return.Id)
            {
                return BadRequest();
            }

            db.Entry(@return).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReturnExists(id))
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

        // POST: api/Returns
        [ResponseType(typeof(Return))]
        public IHttpActionResult PostReturn(Return @return)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Returns.Add(@return);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = @return.Id }, @return);
        }

        // DELETE: api/Returns/5
        [ResponseType(typeof(Return))]
        public IHttpActionResult DeleteReturn(int id)
        {
            Return @return = db.Returns.Find(id);
            if (@return == null)
            {
                return NotFound();
            }

            db.Returns.Remove(@return);
            db.SaveChanges();

            return Ok(@return);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReturnExists(int id)
        {
            return db.Returns.Count(e => e.Id == id) > 0;
        }
    }
}