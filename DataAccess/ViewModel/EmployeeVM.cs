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


        public EmployeeVM(int Employee_Id, int User_Id, int Admin_Id, int Divhead_Id)
        {
            this.Employee_Id = Employee_Id;
            this.User_Id = User_Id;
            this.Admin_Id = Admin_Id;
            this.Divhead_Id = Divhead_Id;
        }

        public int Employee_Id { get; set; }
        public int User_Id { get; set; }
        public int Admin_Id { get; set; }
        public int Divhead_Id { get; set; }
    }
}
