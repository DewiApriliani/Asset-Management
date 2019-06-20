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
        public void UpdateProcurement(int id, ProcurementVM procurementVM)
        {
            iProcurementService.Update(id, procurementVM);
        }

        // POST: api/Procurements
        public void InsertProcurement(ProcurementVM procurementVM)
        {
            iProcurementService.Insert(procurementVM);
        }

        // DELETE: api/Procurements/5
        public void DeleteProcurement(int id)
        {
            iProcurementService.Delete(id);
        }
    }
}