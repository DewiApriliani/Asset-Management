using Core.Base;
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
        public string Name_Location { get; set; }
        public string Floor { get; set; }
    }
}
