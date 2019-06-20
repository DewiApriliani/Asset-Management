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
using DataAccess.ViewModel;

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
        public Handover GetHandover(int id)
        {
            return iHandoverService.Get(id);
        }

        // PUT: api/Handovers/5
       // public void UpdateHandover(int id, HandoverVM handoverVM)
        //{
        //    iHandoverService.Update(id, handoverVM);
        //}

        // POST: api/Handovers
        public void insertHandover(HandoverVM Handover)
        {
            iHandoverService.Insert(Handover);
        }

        // DELETE: api/Handovers/5

    }
}