﻿using DataAccess.Models;
using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
   public interface IReturnService
    {
        Return Get(int id);
        List<Return> Get();
        bool Insert(ReturnVM ReturnVM);
        bool Update(int id, ReturnVM ReturnVM);
        bool Delete(int id);
    }
}
