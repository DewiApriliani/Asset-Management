using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_TypeItem")]
    public class TypeItem : BaseModel
    {
        public string Name_TypeItem { get; set; }
    }
}
