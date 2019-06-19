using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class EmployeeVM
    {
        public EmployeeVM() { }


        public EmployeeVM(int employee_Id, int user_Id, int admin_Id, int divhead_Id, string name_Admin, string name_User)
        {
            this.Employee_Id = employee_Id;
            this.User_Id = user_Id;
            this.Admin_Id = admin_Id;
            this.Divhead_Id = divhead_Id;
            this.Name_Admin = name_Admin;
            this.Name_User = name_User;
        }

        public int Employee_Id { get; set; }
        public int User_Id { get; set; }
        public int Admin_Id { get; set; }
        public int Divhead_Id { get; set; }
        public string Name_Admin { get; set; }
        public string Name_User { get; set; }
    }
}
