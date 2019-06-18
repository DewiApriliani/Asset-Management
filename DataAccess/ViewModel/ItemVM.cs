﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class ItemVM
    {
        public ItemVM() { }

        public ItemVM(int name_Item, string merk, string description, string photo_Item, string condition, DateTimeOffset year_Procurement, int stock, double price)
        {
            this.Name_Item = name_Item;
            this.Merk = merk;
            this.Description = description;
            this.Photo_Item = photo_Item;
            this.Condition = condition;
            this.Year_Procurement = year_Procurement;
            this.Stock = stock;
            this.Price = price;
        }

        public int Id { get; set; }
        public int Name_Item { get; set; }
        public string Merk { get; set; }
        public string Description { get; set; }
        public string Photo_Item { get; set; }
        public string Condition { get; set; }
        public DateTimeOffset Year_Procurement { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public int Typeitem_Id { get; set; }
        public int Location_Id { get; set; }
    }
}