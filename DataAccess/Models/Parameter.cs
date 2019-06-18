using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Parameter")]
    public class Parameter : BaseModel
    {
        public string Name_Validation { get; set; }
        public string Punishment { get; set; }
    }
}
