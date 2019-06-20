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
    public class ParametersController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly IParameterService iParameterService;
        public ParametersController() { }
        public ParametersController(IParameterService _iParameterService)
        {
            iParameterService = _iParameterService;
        }

        // GET: api/Items
        public List<Parameter> GetParameters()
        {
            return iParameterService.Get();
        }

        // GET: api/Parameters/5
        public Parameter GetParameter(int id)
        {
            return iParameterService.Get(id);
        }

        // PUT: api/Parameters/5
        public void UpdateParameter(int id, ParameterVM parameterVM)
        {
            iParameterService.Update(id, parameterVM);
        }

        // POST: api/Parameters
        public void InsertParameter(ParameterVM parameterVM)
        {
            iParameterService.Insert(parameterVM);
        }

        // DELETE: api/Parameters/5
        public void DeleteParameter(int id)
        {
            iParameterService.Delete(id);
        }
    }
}