using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_Procurement")]
    public class Procurement : BaseModel
    {
        public string Name_Procurement { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Name_Item { get; set; }
        public DateTimeOffset Date_Procurement { get; set; }
        public string Name_Admin { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public int Employee_Id { get; set; }
        
        [ForeignKey("Item")]
        public int Item_Id { get; set; }
    }
}
