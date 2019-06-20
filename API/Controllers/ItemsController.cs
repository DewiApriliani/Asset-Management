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
using BusinessLogic.Service;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModel;

namespace API.Controllers
{
    public class ItemsController : ApiController
    {
        private MyContext db = new MyContext();
        private readonly IItemService iItemService;
        public ItemsController() { }
        public ItemsController(IItemService _iItemService)
        {
            iItemService = _iItemService;
        }

        // GET: api/Items
        public List<Item> GetItems()
        {
            return iItemService.Get();
        }

        // GET: api/Items/5
        public Item GetItem(int id)
        {
            return iItemService.Get(id);
        }


        // PUT: api/Items/5



        // POST: api/Items
        public void insertItem(ItemVM Item)
        {
            iItemService.Insert(Item);
        }


        // DELETE: api/Items/5




    }
}