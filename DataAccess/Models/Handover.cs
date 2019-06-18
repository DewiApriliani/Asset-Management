using Core.Base;
<<<<<<< HEAD
=======
using DataAccess.ViewModel;
>>>>>>> b9d3ac1fecb266c3eb9206a3e8e30528ab485b46
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_Handover")]
    public class Handover : BaseModel
    {
<<<<<<< HEAD
        public string Description { get; set; }
        public string Name_User { get; set; }
        public string Name_Admin { get; set; }
        public DateTimeOffset Date_Handover { get; set; }

        public int Employee_Id { get; set; }
=======
        public string Descriptioan { get; set; }
        public string Name_User { get; set; }
        public string Name_Admin { get; set; }
        public DateTimeOffset Date_Handover { get; set; }
        public int User_Id { get; set; }
        public int Divhead_Id { get; set; }
        public int Admin_Id { get; set; }
>>>>>>> b9d3ac1fecb266c3eb9206a3e8e30528ab485b46

        [ForeignKey("Loaning")]
        public int Loaning_Id { get; set; }
        public Loaning Loaning { get; set; }

        [ForeignKey("Return")]
        public int Return_Id { get; set; }
        public Return Return { get; set; }
        
        public Handover() { }

        public Handover(HandoverVM HandoverVM)
        {
            this.Descriptioan = HandoverVM.Descriptioan;
            this.Name_User = HandoverVM.Name_User;
            this.Name_Admin = HandoverVM.Name_User;
            this.Date_Handover = HandoverVM.Date_Handover;
            this.Admin_Id = HandoverVM.Admin_id;
            this.User_Id = HandoverVM.User_Id;
            this.Divhead_Id = HandoverVM.Divhead_Id;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, HandoverVM HandoverVM)
        {
            this.Id = id;
            this.Descriptioan = HandoverVM.Descriptioan;
            this.Name_User = HandoverVM.Name_User;
            this.Name_Admin = HandoverVM.Name_User;
            this.Date_Handover = HandoverVM.Date_Handover;
            this.Admin_Id = HandoverVM.Admin_id;
            this.User_Id = HandoverVM.User_Id;
            this.Divhead_Id = HandoverVM.Divhead_Id;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }

    }
}
