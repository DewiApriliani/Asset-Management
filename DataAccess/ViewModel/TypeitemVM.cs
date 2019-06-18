using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class TypeitemVM
    {
        public TypeitemVM() { }

        public TypeitemVM(string name_Typeitem)
        {
            this.Name_Typeitem = name_Typeitem;
        }

        public string Name_Typeitem { get; set; }
    }
}
