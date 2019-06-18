using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class ReturnVM
    {
        public ReturnVM(string name_User, string name_Item, int quantity, string status, string last_Condition, DateTimeOffset date_Return, int user_Id, int item_Id)
        {
            this.Name_User = Name_User;
            this.Name_Item = Name_Item;
            this.Quantity = Quantity;
            this.Status = Status;
            this.Last_Condition = Last_Condition;
            this.Date_Return = Date_Return;
            this.Employee_Id = Employee_Id;
            this.Item_Id = Item_Id;
        }

        public ReturnVM() { }

        public int Id { get; set; }
        public string Name_User { get; set; }
        public string Name_Item { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string Last_Condition { get; set; }
        public DateTimeOffset Date_Return { get; set; }
        public int Employee_Id { get; set; }
        public int Item_Id { get; set; }

    }
}
