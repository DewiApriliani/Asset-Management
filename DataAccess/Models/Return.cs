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
        public int User_Id { get; set; }

        [ForeignKey("Item")]
        public int Item_Id { get; set; }
        public Item Item { get; set; }

        public Return() { }

        public Return(ReturnVM ReturnVM)
        {
            this.Name_User = ReturnVM.Name_User;
            this.Name_Item = ReturnVM.Name_Item;
            this.Quantity = ReturnVM.Quantity;
            this.Status = ReturnVM.Status;
            this.Last_Condition = ReturnVM.Last_Condition;
            this.Date_Return = ReturnVM.Date_Return;
            this.User_Id = ReturnVM.User_Id;
            this.Item_Id = ReturnVM.Item_Id;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, ReturnVM ReturnVM)
        {
            this.Id = id;
            this.Name_User = ReturnVM.Name_User;
            this.Name_Item = ReturnVM.Name_Item;
            this.Quantity = ReturnVM.Quantity;
            this.Status = ReturnVM.Status;
            this.Last_Condition = ReturnVM.Last_Condition;
            this.Date_Return = ReturnVM.Date_Return;
            this.User_Id = ReturnVM.User_Id;
            this.Item_Id = ReturnVM.Item_Id;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
}
