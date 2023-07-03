using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Models
{
    public class CrimeByArea
    {
        public string age_range { get; set; }
        public string outcome { get; set; }
        public bool involved_person { get; set; }
        public string self_defined_ethnicity { get; set; }
        public string gender { get; set; }
        public string legislation { get; set; }
        public bool outcome_linked_to_object_of_search { get; set; }
        public string datetime { get; set; }
        public bool operation { get; set; }
        public string operation_name { get; set; }
        public bool removal_of_more_than_outer_clothing { get; set; }
        public string officer_defined_ethnicity { get; set; }
        public string type { get; set; }
        public string object_of_search { get; set; }
        public IdentifiedObject outcome_object { get; set; }
        public CrimeLocation location { get; set; }
    }
}