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
    [Table("TB_T_Handover")]
    public class Handover : BaseModel
    {
        public string Descriptioan { get; set; }
        public string Name_User { get; set; }
        public string Name_Admin { get; set; }
        public DateTimeOffset Date_Handover { get; set; }

        public int Employee_Id { get; set; }

        [ForeignKey("Loaning")]
        public int Loaning_Id { get; set; }
        public Loaning Loaning { get; set; }

        [ForeignKey("Return")]
        public int Return_Id { get; set; }
        public Return Return { get; set; }
        
        public Handover() { }

        public Handover(HandoverVM HandoverVM)
        {
            this.Id = Id;
            this.Descriptioan = Descriptioan;
            this.Name_User = Name_User;
            this.Name_Admin = Name_Admin;
            this.Date_Handover = Date_Handover;
            this.Employee_Id = Employee_Id;
            this.Loaning_Id = Loaning_Id;
            this.Return_Id = Return_Id;
        }
    }
}
