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
        public Loaning GetLoaning(int id)
        {
            return iLoaningService.Get(id);
        }

        // PUT: api/Loanings/5
        public HttpResponseMessage UpdateLoaning(int id, LoaningVM loaningVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = iLoaningService.Update(id, loaningVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK);
            }
            return message;
        }

        // POST: api/Loanings
        public HttpResponseMessage InsertLoaning(LoaningVM loaningVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = iLoaningService.Insert(loaningVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.Created);
            }
            return message;
        }

        // DELETE: api/Loanings/5
        public void DeleteLoaning(int id)
        {
            iLoaningService.Delete(id);
        }
    }
}