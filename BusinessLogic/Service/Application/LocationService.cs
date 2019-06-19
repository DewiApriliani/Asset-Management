using Common.Repository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ViewModel;

namespace BusinessLogic.Service.Application
{
   public class LocationService : ILocationService
    {
        public LocationService() { }

        ILocationRepository iLocationRepository;

        public LocationService(ILocationRepository _iLocationRepository)
        {
            this.iLocationRepository = _iLocationRepository;
        }

        private readonly ILocationRepository iLocationService;
        bool status = false;

        public Location Get(int id)
        {
            return iLocationService.Get(id);
        }

        public bool Insert(LocationVM locationVM)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(locationVM.Name_Location)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(locationVM.Floor)))
            {
                return status;
            }
            else
            {
                return iLocationService.Insert(locationVM);
            }
        }

        public bool Update(int id, LocationVM locationVM)
        {
            return iLocationService.Update(id, locationVM);
        }

        public bool Delete(int id)
        {
            return iLocationService.Delete(id);
        }
    }
}
