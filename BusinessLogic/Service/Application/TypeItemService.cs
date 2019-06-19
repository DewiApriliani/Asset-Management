using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ViewModel;
using Common.Repository;

namespace BusinessLogic.Service.Application
{
    public class TypeItemService : ITypeItemService
    {
        public TypeItemService() { }

        ITypeItemRepository iTypeItemRepository;

        public TypeItemService(ITypeItemRepository _iTypeItemRepository)
        {
            this.iTypeItemRepository = _iTypeItemRepository;
        }

        private readonly ITypeItemRepository iTypeItemService;
        bool status = false;

        public TypeItem Get(int id)
        {
            return iTypeItemService.Get(id);
        }

        public bool Insert(TypeItemVM typeItemVM)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(typeItemVM.Name_TypeItem)))
            {
                return status;
            }
            else
            {
                return iTypeItemService.Insert(typeItemVM);
            }
        }

        public bool Delete(int id)
        {
            return iTypeItemService.Delete(id);
        }


        public bool Update(int id, TypeItemVM typeItemVM)
        {
            return iTypeItemService.Update(id, typeItemVM);
        }

        public List<TypeItem> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public List<TypeItem> Get()
        {
            return iTypeItemService.Get();
        }
    }
}
