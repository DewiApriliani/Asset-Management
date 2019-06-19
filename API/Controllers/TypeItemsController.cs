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
using BusinessLogic.Service;

namespace API.Controllers
{
    public class TypeItemsController : ApiController
    {
        private MyContext db = new MyContext();



        public TypeItemsController() { }

        private readonly ITypeItemService iTypeItemService;
        bool status = false;

        // Konstruktor
        public TypeItemsController(ITypeItemService _iTypeItemService)
        {
            this.iTypeItemService = _iTypeItemService;
        }

        // GET: api/TypeItems
        public List<TypeItem> GetTypeItems()
        {
            return iTypeItemService.Get();
        }

        // GET: api/TypeItems/5
        [ResponseType(typeof(TypeItem))]
        public IHttpActionResult GetTypeItem(int id)
        {
            TypeItem typeItem = db.TypeItems.Find(id);
            if (typeItem == null)
            {
                return NotFound();
            }

            return Ok(typeItem);
        }

        // PUT: api/TypeItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTypeItem(int id, TypeItem typeItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != typeItem.Id)
            {
                return BadRequest();
            }

            db.Entry(typeItem).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeItemExists(id))
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

        // POST: api/TypeItems
        [ResponseType(typeof(TypeItem))]
        public IHttpActionResult PostTypeItem(TypeItem typeItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TypeItems.Add(typeItem);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = typeItem.Id }, typeItem);
        }

        // DELETE: api/TypeItems/5
        [ResponseType(typeof(TypeItem))]
        public IHttpActionResult DeleteTypeItem(int id)
        {
            TypeItem typeItem = db.TypeItems.Find(id);
            if (typeItem == null)
            {
                return NotFound();
            }

            db.TypeItems.Remove(typeItem);
            db.SaveChanges();

            return Ok(typeItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TypeItemExists(int id)
        {
            return db.TypeItems.Count(e => e.Id == id) > 0;
        }
    }
}