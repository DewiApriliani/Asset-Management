using Core.Base;
using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_Return")]
    public class Return : BaseModel
    {
        public string Name_User { get; set; }
        public string Name_Item { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string Last_Condition { get; set;}
        public DateTimeOffset Date_Return { get; set; }

        public int Employee_Id { get; set; }

        [ForeignKey("Item")]
        public int Item_Id { get; set; }
        public Item Item { get; set; }

        public Return() { }

        public Return(ReturnVM ReturnVM)
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
    }
}
