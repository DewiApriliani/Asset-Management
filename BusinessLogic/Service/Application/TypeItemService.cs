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
        private readonly ITypeItemRepository iTypeItemRepository;
        bool status = false;
        public TypeItemService() { }
        public TypeItemService(ITypeItemRepository _iTypeItemRepository)
        {
            iTypeItemRepository = _iTypeItemRepository;
        }

        public TypeItem Get(int id)
        {
            return iTypeItemRepository.Get(id);
        }

        public bool Insert(TypeItemVM typeItemVM)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(typeItemVM.Name_TypeItem)))
            {
                return status;
            }
            else
            {
                return iTypeItemRepository.Insert(typeItemVM);
            }
        }

        public bool Delete(int id)
        {
            return iTypeItemRepository.Delete(id);
        }


        public bool Update(int id, TypeItemVM typeItemVM)
        {
            return iTypeItemRepository.Update(id, typeItemVM);
        }

        public List<TypeItem> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public List<TypeItem> Get()
        {
            return iTypeItemRepository.Get();
        }
    }
}
