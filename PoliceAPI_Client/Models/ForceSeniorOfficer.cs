using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Models
{
    public class ForceSeniorOfficer
    {
        public string bio { get; set; }
        public string name { get; set; }
        public string rank { get; set; }
        public IDictionary<string, string> contact_details { get; set; }
    }
}
