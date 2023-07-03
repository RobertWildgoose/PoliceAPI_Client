using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Models
{
    public class SpecificNeighbourhoodLocation : SpecificLocation
    {
        public string name { get; set; }
        public string postcode { get; set; }
        public string address { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }
}