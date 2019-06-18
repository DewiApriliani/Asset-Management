using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Location")]
    public class Location
    {
        public int Id { get; set; }
        public string Name_location { get; set; }
        public string floor { get; set; }
    }
}
