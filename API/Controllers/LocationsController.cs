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
using BusinessLogic.Service.Application;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModel;

namespace API.Controllers
{
    public class LocationsController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly ILocationService iLocationService;
        public LocationsController() { }
        public LocationsController(ILocationService _iLocationService)
        {
            iLocationService = _iLocationService;
        }

        // GET: api/Location
        public List<Location> GetLocations()
        {
            return iLocationService.Get();
        }

        // GET: api/Locations/5
        public Location GetLocation(int id)
        {
            return iLocationService.Get(id);
        }

        // PUT: api/Locations/5
        public HttpResponseMessage UpdateLocation(int id, LocationVM locationVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = iLocationService.Update(id, locationVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK);
            }
            return message;
        }

        // POST: api/Locations
        public HttpResponseMessage InsertLocation(LocationVM locationVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = iLocationService.Insert(locationVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.Created);
            }
            return message;
        }

        // DELETE: api/Locations/5
        public void DeleteLocation(int id)
        {
            iLocationService.Delete(id);
        }
    }
}