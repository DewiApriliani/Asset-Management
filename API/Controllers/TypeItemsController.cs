using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DataAccess.Context;
using DataAccess.Models;
using BusinessLogic.Service;
using DataAccess.ViewModel;

namespace API.Controllers
{
    public class TypeItemsController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly ITypeItemService iTypeItemService;
        public TypeItemsController() { }
        public TypeItemsController(ITypeItemService _iTypeItemService)
        {
            iTypeItemService = _iTypeItemService;
        }

        // GET: api/TypeItem
        public List<TypeItem> GetTypeItem()
        {
            return iTypeItemService.Get();
        }


        // GET: api/TypeItems/5
        public TypeItem GetTypeItem(int id)
        {
            return iTypeItemService.Get(id);
        }

        // PUT: api/TypeItems/5


        // POST: api/TypeItems
        public void insertTypeItem(TypeItemVM typeItem)
        {
            iTypeItemService.Insert(typeItem);
        }

        // DELETE: api/TypeItems/5
    }

    
}