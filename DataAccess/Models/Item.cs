using Core.Base;
<<<<<<< HEAD
using DataAccess.ViewModel;
=======
>>>>>>> b9d3ac1fecb266c3eb9206a3e8e30528ab485b46
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Item")]
    public class Item : BaseModel
    {
        public int Name_Item { get; set; }
        public string Merk { get; set; }
        public string Description { get; set; }
        public string Photo_Item { get; set; }
        public string Condition { get; set; }
        public DateTimeOffset Year_Procurement { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        [ForeignKey("TypeItem")]
        public int Typeitem_Id { get; set; }

        [ForeignKey("Location")]
        public int Location_Id { get; set; }
        public Location Location { get; set; }

        public Item (ItemVM itemVM)
        {
            this.Name_Item = itemVM.Name_Item;
            this.Merk = itemVM.Merk;
            this.Description = itemVM.Description;
            this.Photo_Item = itemVM.Photo_Item;
            this.Condition = itemVM.Condition;
            this.Year_Procurement = itemVM.Year_Procurement;
            this.Stock = itemVM.Stock;
            this.Price = itemVM.Price;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, ItemVM itemVM)
        {
            this.Id = itemVM.Id;
            this.Name_Item = itemVM.Name_Item;
            this.Merk = itemVM.Merk;
            this.Description = itemVM.Description;
            this.Photo_Item = itemVM.Photo_Item;
            this.Condition = itemVM.Condition;
            this.Year_Procurement = itemVM.Year_Procurement;
            this.Stock = itemVM.Stock;
            this.Price = itemVM.Price;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
