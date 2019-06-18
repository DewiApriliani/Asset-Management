using Core.Base;
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
        public string Description { get; set; }
        public string Name_User { get; set; }
        public string Name_Admin { get; set; }
        public DateTimeOffset Date_Handover { get; set; }
        public int User_id { get; set; }
        public int Admin_Id { get; set; }
        public int Divhead_Id { get; set; }

        [ForeignKey("Loaning")]
        public int Loaning_Id { get; set; }
        public Loaning Loaning { get; set; }

        [ForeignKey("Return")]
        public int Return_Id { get; set; }
        public Return Return { get; set; }
        
    }
}
