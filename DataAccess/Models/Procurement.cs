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
    [Table("TB_T_Procurement")]
    public class Procurement : BaseModel
    {
<<<<<<< HEAD
        public int Admin_Id { get; set; }
=======
>>>>>>> b9d3ac1fecb266c3eb9206a3e8e30528ab485b46
        public string Name_Procurement { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Name_Item { get; set; }
        public DateTimeOffset Date_Procurement { get; set; }
        public string Name_Admin { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        
        [ForeignKey("Item")]
        public int Item_Id { get; set; }

        public Procurement(ProcurementVM procurementVM)
        {
            this.Name_Procurement = procurementVM.Name_Procurement;
            this.Description = procurementVM.Description;
            this.Price = procurementVM.Price;
            this.Name_Item = procurementVM.Name_Item;
            this.Date_Procurement = procurementVM.Date_Procurement;
            this.Name_Admin = procurementVM.Name_Admin;
            this.Quantity = procurementVM.Quantity;
            this.Status = procurementVM.Status;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, ProcurementVM procurementVM)
        {
            this.Id = procurementVM.Id;
            this.Name_Procurement = procurementVM.Name_Procurement;
            this.Description = procurementVM.Description;
            this.Price = procurementVM.Price;
            this.Name_Item = procurementVM.Name_Item;
            this.Date_Procurement = procurementVM.Date_Procurement;
            this.Name_Admin = procurementVM.Name_Admin;
            this.Quantity = procurementVM.Quantity;
            this.Status = procurementVM.Status;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
