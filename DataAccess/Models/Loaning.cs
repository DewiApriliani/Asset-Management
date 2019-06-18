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
    [Table("TB_T_Loaning")]
    public class Loaning : BaseModel
    {
<<<<<<< HEAD
        public int User_Id { get; set; }
=======
>>>>>>> b9d3ac1fecb266c3eb9206a3e8e30528ab485b46
        public DateTimeOffset Date_Loaning { get; set; }
        public DateTimeOffset Date_Return { get; set; }
        public string Name_User { get; set; }
        public string Name_Item { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        [ForeignKey("Item")]
        public int Item_Id { get; set; }
        public Item Item { get; set; }

        public Loaning(LoaningVM loaningVM)
        {
            this.Date_Loaning = loaningVM.Date_Loaning;
            this.Date_Return = loaningVM.Date_Return;
            this.Name_User = loaningVM.Name_User;
            this.Name_Item = loaningVM.Name_Item;
            this.Quantity = loaningVM.Quantity;
            this.Status = loaningVM.Status;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, LoaningVM loaningVM)
        {
            this.Id = loaningVM.Id;
            this.Date_Loaning = loaningVM.Date_Loaning;
            this.Date_Return = loaningVM.Date_Return;
            this.Name_User = loaningVM.Name_User;
            this.Name_Item = loaningVM.Name_Item;
            this.Quantity = loaningVM.Quantity;
            this.Status = loaningVM.Status;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
