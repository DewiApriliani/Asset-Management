using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModel;
using Common.Repository;
using BusinessLogic.Service;

namespace BusinessLogic.Service.Application
{
    public class HandoverService : IHandoverService
    {
        private readonly IHandoverRepository iHandoverRepository;
        bool status = false;
        public HandoverService() { }
        public HandoverService(IHandoverRepository _iHandoverRepository)
        {
            iHandoverRepository = _iHandoverRepository;
        }

        public Handover Get(int id)
        {
            return iHandoverRepository.Get(id);
        }

        public bool Insert(HandoverVM handoverVM)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.Descriptioan)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.Name_User)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.Name_Admin)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.Date_Handover)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.Admin_id)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.User_Id)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.Divhead_Id)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.Loaning_Id)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(handoverVM.Return_Id)))
            {
                return status;
            }
            else
            {
                return iHandoverRepository.Insert(handoverVM);
            }
        }

        public bool Delete(int id)
        {
            return iHandoverRepository.Delete(id);
        }

        public List<Handover> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public List<Handover> Get()
        {
            return iHandoverRepository.Get();
        }
    }
}
