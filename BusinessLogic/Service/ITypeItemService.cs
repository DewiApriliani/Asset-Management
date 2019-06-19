using DataAccess.Models;
using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface ITypeItemService
    {
        TypeItem Get(int id);
        bool Insert(TypeItemVM TypeItemVM);
        bool Update(int id, TypeItemVM TypeItemVM);
        bool Delete(int id);
    }
}
