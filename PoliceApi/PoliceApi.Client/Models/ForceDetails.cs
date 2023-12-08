using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Models
{
	public class ForceDetails
	{
		public string description { get; set; }
		public string name { get; set; }
		public string id { get; set; }
		public string telephone { get; set; }
		public string url { get; set; }
		public List<EngagementMethod> engagement_methods { get; set; }
	}
}
