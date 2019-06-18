using Core.Base;
using DataAccess.ViewModel;
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

        public Parameter() { }

        public Parameter(ParameterVM parameterVM)
        {
            this.Name_Validation = Name_Validation;
            this.Punishment = Punishment;
        }
    }
}
