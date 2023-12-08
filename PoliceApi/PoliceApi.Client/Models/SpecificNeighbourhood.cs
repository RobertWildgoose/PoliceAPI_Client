using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Models
{
	public class SpecificNeighbourhood
	{
		public string url_force { get; set; }
		public string name { get; set; }
		public SpecificLocation centre { get; set; }
		public string description { get; set; }
		public string id { get; set; }
		public string population { get; set; }
		public List<LinkIdentifier> links { get; set; }
		public List<SpecificNeighbourhoodLocation> locations { get; set; }
		public ContactDetails contact_details { get; set; }
	}
}
