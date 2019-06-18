using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class HandoverVM
    {
        public HandoverVM(string description, string name_User, string name_Admin, DateTimeOffset date_Handover, int user_Id, int admin_Id, int divhead_Id, int loaning_Id, int return_Id)
        {
            this.Descriptioan = Descriptioan;
            this.Name_User = Name_User;
            this.Name_Admin = Name_Admin;
            this.Date_Handover = Date_Handover;
            this.Employee_id = Employee_id;
            this.Loaning_Id = Loaning_Id;
            this.Return_Id = Return_Id;
        }

        public HandoverVM() { }

        public string Descriptioan { get; set; }
        public string Name_User { get; set; }
        public string Name_Admin { get; set; }
        public DateTimeOffset Date_Handover { get; set; }
        public int Employee_id { get; set; }
        public int Loaning_Id { get; set; }
        public int Return_Id { get; set; }
    }
}
