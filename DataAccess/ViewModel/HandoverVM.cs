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
            this.Descriptioan = description;
            this.Name_User = name_User;
            this.Name_Admin = name_User;
            this.Date_Handover = date_Handover;
            this.Admin_id = admin_Id;
            this.User_Id = user_Id;
            this.Divhead_Id = divhead_Id;
            this.Loaning_Id = loaning_Id;
            this.Return_Id = return_Id;
        }

        public HandoverVM() { }

        public string Id { get; set; }
        public string Descriptioan { get; set; }
        public string Name_User { get; set; }
        public string Name_Admin { get; set; }
        public DateTimeOffset Date_Handover { get; set; }
        public int Admin_id { get; set; }
        public int User_Id { get; set; }
        public int Divhead_Id { get; set; }
        public int Loaning_Id { get; set; }
        public int Return_Id { get; set; }
    }
}
