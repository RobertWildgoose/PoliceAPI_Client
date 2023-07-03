using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Models
{
    public class CrimeLocation : SpecificLocation
    {
        public CrimeStreet street { get; set; }
    }

    public class SpecificLocation
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class CrimeStreet
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}