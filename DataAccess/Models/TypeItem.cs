using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_TypeItem")]
    public class TypeItem
    {
        public int Id { get; set; }
        public string Name_TypeItem { get; set; }
    }
}
