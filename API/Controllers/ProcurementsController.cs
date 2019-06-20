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
        public Procurement GetProcurement(int id)
        {
            return iProcurementService.Get(id);
        }

        // PUT: api/Procurements/5
        public HttpResponseMessage UpdateProcurement(int id, ProcurementVM procurementVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = iProcurementService.Update(id, procurementVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK);
            }
            return message;
        }

        // POST: api/Procurements
        public HttpResponseMessage InsertProcurement(ProcurementVM procurementVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = iProcurementService.Insert(procurementVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.Created);
            }
            return message;
        }

        // DELETE: api/Procurements/5
        public void DeleteProcurement(int id)
        {
            iProcurementService.Delete(id);
        }
    }
}