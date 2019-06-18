using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class LoaningVM
    {
        public LoaningVM() { }

        public LoaningVM(int user_Id, DateTimeOffset date_Loaning, DateTimeOffset date_Return, string name_User, string name_Item, int quantity, string status, int item_Id)
        {
            this.User_Id = user_Id;
            this.Date_Loaning = date_Loaning;
            this.Date_Return = date_Return;
            this.Name_User = name_User;
            this.Name_Item = name_Item;
            this.Quantity = quantity;
            this.Status = status;
            this.Item_Id = item_Id;
        }

        public int Id { get; set; }
        public int User_Id { get; set; }
        public DateTimeOffset Date_Loaning { get; set; }
        public DateTimeOffset Date_Return { get; set; }
        public string Name_User { get; set; }
        public string Name_Item { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public int Item_Id { get; set; }
    }
}
