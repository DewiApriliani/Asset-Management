using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public class Location
    {
        public Location() { }

        public Location(string name_Location, string floor)
        {
            this.Name_Location = name_Location;
            this.Floor = floor;
        }

        public int Id { get; set; }
        public string Name_Location { get; set; }
        public string Floor { get; set; }

    }
}
