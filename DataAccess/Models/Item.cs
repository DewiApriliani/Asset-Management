using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Item")]
    public class Item : BaseModel
    {
        public int Name_Item { get; set; }
        public string Merk { get; set; }
        public string Description { get; set; }
        public string Photo_Item { get; set; }
        public string Condition { get; set; }
        public DateTimeOffset Year_Procurement { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int Typeitem_Id { get; set; }

        [ForeignKey("Location")]
        public int Location_Id { get; set; }
        public Location Location { get; set; }
    }
}
