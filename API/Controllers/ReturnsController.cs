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
        public Return GetReturn(int id)
        {
            return iReturnService.Get(id);
        }

        // PUT: api/Returns/5
        

        // POST: api/Returns
        public void inserReturn(ReturnVM returnVM)
        {
            iReturnService.Insert(returnVM);
        }

        // DELETE: api/Returns/5
       

    }
}