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
    [Table("TB_M_Location")]
    public class Location : BaseModel
    {
<<<<<<< HEAD
        public string Name_Location { get; set; }
        public string Floor { get; set; }

        public Location(LocationVM locationVM)
        {
            this.Name_Location = locationVM.Name_Location;
            this.Floor = locationVM.Floor;
        }

        public void Update(int id, LocationVM locationVM)
        {
            this.Id = locationVM.Id;
            this.Name_Location = locationVM.Name_Location;
            this.Floor = locationVM.Floor;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
=======
        public string Name_location { get; set; }
        public string floor { get; set; }
>>>>>>> b9d3ac1fecb266c3eb9206a3e8e30528ab485b46
    }
}
