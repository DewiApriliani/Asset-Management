﻿using System;
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
        private readonly IReturnRepository iReturnRepository;
        bool status = false;
        public ReturnService() { }
        public ReturnService(IReturnRepository _iReturnRepository)
        {
            iReturnRepository = _iReturnRepository;
        }

        public Return Get(int id)
        {
            return iReturnRepository.Get(id);
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
                return iReturnRepository.Insert(returnVM);
            }
        }

        public bool Delete(int id)
        {
            return iReturnRepository.Delete(id);
        }

        public List<Return> Get()
        {
            return iReturnRepository.Get();
        }

        public bool Update(int id, ReturnVM returnVM)
        {
            return iReturnRepository.Update(id, returnVM);
        }
    }
}