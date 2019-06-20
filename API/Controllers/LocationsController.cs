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
        public void UpdateLocation(int id, LocationVM locationVM)
        {
            iLocationService.Update(id, locationVM);
        }

        // POST: api/Locations
        public void InsertLocation(LocationVM locationVM)
        {
            iLocationService.Insert(locationVM);
        }

        // DELETE: api/Locations/5
        public void DeleteLocation(int id)
        {
            iLocationService.Delete(id);
        }
    }
}