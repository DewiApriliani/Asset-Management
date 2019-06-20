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
        public Procurement GetProcurment(int id)
        {
            return iProcurementService.Get(id);
        }

        // PUT: api/Procurements/5
      

        // POST: api/Procurements
        public void insertProcurment(ProcurementVM procurment)
        {
            iProcurementService.Insert(procurment);
        }

        // DELETE: api/Procurements/5


    }
}