﻿using System;
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
    public class ConditionsController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly IConditionService iConditionService;
        public ConditionsController() { }
        public ConditionsController(IConditionService _iConditionService)
        {
            iConditionService = _iConditionService;
        }
        // GET: api/Conditions
        public List<Condition> GetConditions()
        {
            return iConditionService.Get();
        }

        // GET: api/Conditions/5
        [ResponseType(typeof(Condition))]
        public IHttpActionResult GetCondition(int id)
        {
            Condition condition = db.Conditions.Find(id);
            if (condition == null)
            {
                return NotFound();
            }

            return Ok(condition);
        }

        // PUT: api/Conditions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCondition(int id, Condition condition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != condition.Id)
            {
                return BadRequest();
            }

            db.Entry(condition).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConditionExists(id))
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

        // POST: api/Conditions
        [ResponseType(typeof(Condition))]
        public IHttpActionResult PostCondition(Condition condition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Conditions.Add(condition);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = condition.Id }, condition);
        }

        // DELETE: api/Conditions/5
        [ResponseType(typeof(Condition))]
        public IHttpActionResult DeleteCondition(int id)
        {
            Condition condition = db.Conditions.Find(id);
            if (condition == null)
            {
                return NotFound();
            }

            db.Conditions.Remove(condition);
            db.SaveChanges();

            return Ok(condition);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ConditionExists(int id)
        {
            return db.Conditions.Count(e => e.Id == id) > 0;
        }
    }
}