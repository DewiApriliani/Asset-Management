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
    public class ReturnService : IReturnService
    {
        public ReturnService() { }

        IReturnRepository iReturnRepository;

        public ReturnService(IReturnRepository _iReturnRepository)
        {
            this.iReturnRepository = _iReturnRepository;
        }

        private readonly IReturnRepository iReturnService;
        bool status = false;

        public Return Get(int id)
        {
            return iReturnService.Get(id);
        }

        public bool Insert(ReturnVM returnVM)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(returnVM.Name_User)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(returnVM.Name_Item)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(returnVM.Quantity)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(returnVM.Status)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(returnVM.Last_Condition)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(returnVM.Date_Return)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(returnVM.User_Id)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(returnVM.Item_Id)))
            {
                return status;
            }
            else
            {
                return iReturnService.Insert(returnVM);
            }
        }

        public bool Delete(int id)
        {
            return iReturnService.Delete(id);
        }

        public List<Return> Get()
        {
            return iReturnService.Get();
        }

        public bool Update(int id, ReturnVM returnVM)
        {
            return iReturnService.Update(id, returnVM);
        }
    }
}
