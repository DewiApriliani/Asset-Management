using DataAccess.Models;
using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    interface ILocationRepository
    {
        Location Get(int id);
        bool Insert(LocationVM LocationVM);
        bool Update(int id, LocationVM LocationVM);
        bool Delete(int id);
    }
}
