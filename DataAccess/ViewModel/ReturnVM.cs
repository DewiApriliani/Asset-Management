using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class ReturnVM
    {
        public ReturnVM(string name_User, string name_Item, int quantity, string status, string last_Condition, DateTimeOffset date_Return, int user_Id, int item_Id, int typeItem_Id)
        {
            this.Name_User = name_User;
            this.Name_Item = name_Item;
            this.Quantity = quantity;
            this.Status = status;
            this.Last_Condition = last_Condition;
            this.Date_Return = date_Return;
            this.User_Id = user_Id;
            this.Item_Id = item_Id;
            this.TypeItem_Id = typeItem_Id;

            
        }

        public ReturnVM() { }

        public int Id { get; set; }
        public string Name_User { get; set; }
        public string Name_Item { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string Last_Condition { get; set; }
        public DateTimeOffset Date_Return { get; set; }
        public int User_Id { get; set; }
        public int Item_Id { get; set; }
        public int TypeItem_Id { get; set; }

    }
}
