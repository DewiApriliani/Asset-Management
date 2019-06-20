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
using DataAccess.ViewModel;

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
        public Condition GetCondition(int id)
        {
            return iConditionService.Get(id);
        }

        // PUT: api/Conditions/5
        public HttpResponseMessage UpdateCondition(int id, ConditionVM conditionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = iConditionService.Update(id, conditionVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK);
            }
            return message;
        }

        // POST: api/Conditions
        public HttpResponseMessage InsertCondition(ConditionVM conditionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = iConditionService.Insert(conditionVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.Created);
            }
            return message;
        }

        // DELETE: api/Conditions/5
        public void DeleteCondition(int id)
        {
            iConditionService.Delete(id);
        }
    }
}