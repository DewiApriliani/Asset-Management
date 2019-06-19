using Common.Repository;
using Common.Repository.Application;
using DataAccess.Models;
using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service.Application
{
    public class ItemService : IItemService
    {
        public ItemService() { }

        IItemRepository iItemRepository;

        public ItemService(IItemRepository _iItemRepository)
        {
            this.iItemRepository = _iItemRepository;
        }

        private readonly IItemRepository iItemService;
        bool status = false;

        public List<Item> Get()
        {
            return iItemRepository.Get();
        }

        public List<Item> GetSearch(string values)
        {
            return iItemRepository.GetSearch(values);
        }

        public Item Get(int id)
        {
            return iItemRepository.Get(id);
        }

        public bool Insert(ItemVM itemVM)
        {
            if (string.IsNullOrWhiteSpace(itemVM.Name_Item))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(itemVM.Merk))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(itemVM.Description))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(itemVM.Photo_Item))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(itemVM.Condition))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(itemVM.Year_Procurement)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(itemVM.Stock)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(itemVM.Price)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(itemVM.TypeItem_Id)))
            {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(itemVM.Location_Id)))
            {
                return status;
            }
            else
            {
                return iItemRepository.Insert(itemVM);
            }
        }

        public bool Update(int id, ItemVM itemVM)
        {
            return iItemRepository.Update(id, itemVM);
        }

        public bool Delete(int id)
        {
            return iItemRepository.Delete(id);
        }
    }
}
