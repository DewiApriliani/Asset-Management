using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class ProcurementVM
    {
        public ProcurementVM() { }

        public ProcurementVM(string name_Procurement, string description, double price, string name_Item, DateTimeOffset date_procurement, string name_Admin, int quantity, string status, int employee_Id, int item_Id )
        {
            this.Name_Procurement = name_Procurement;
            this.Description = description;
            this.Price = price;
            this.Name_Item = name_Item;
            this.Date_Procurement = date_procurement;
            this.Name_Admin = name_Admin;
            this.Quantity = quantity;
            this.Status = status;
            this.Employee_Id = employee_Id;
            this.Item_Id = item_Id;
        }

        public int Id { get; set; }
        public string Name_Procurement { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Name_Item { get; set; }
        public DateTimeOffset Date_Procurement { get; set; }
        public string Name_Admin { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public int Employee_Id { get; set; }
        public int Item_Id { get; set; }
    }
}
