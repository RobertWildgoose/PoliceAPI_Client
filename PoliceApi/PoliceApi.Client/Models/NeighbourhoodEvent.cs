using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Models
{
	public class NeighbourhoodEvent
	{
		public string description { get; set; }
		public string title { get; set; }
		public string address { get; set; }
		public string type { get; set; }
		public string start_date { get; set; }
		public string end_date { get; set; }
	}
}
