using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModel;
using Common.Repository;

namespace BusinessLogic.Service.Application
{
    public class ParameterService : IParameterService
    {
        public ParameterService() { }

        IParameterRepository iParameterRepository;

        public ParameterService(IParameterRepository _iParameterRepository)
        {
            this.iParameterRepository = _iParameterRepository;
        }

        private readonly IParameterRepository iParameterService;
        bool status = false;

        public Parameter Get(int id)
        {
            return iParameterService.Get(id);
        }

        public bool Insert(ParameterVM parameterVM)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(parameterVM.Name_Validation)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(parameterVM.Punishment)))
            {
                return status;
            }
            else
            {
                return iParameterService.Insert(parameterVM);
            }
        }

        public bool Update(int id, ParameterVM parameterVM)
        {
            return iParameterService.Update(id, parameterVM);
        }

        public bool Delete(int id)
        {
            return iParameterService.Delete(id);
        }
    
    }
}
