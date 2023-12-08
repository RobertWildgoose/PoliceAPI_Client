using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Models
{
	public class Priority
	{
		public string action { get; set; }
		[JsonProperty(PropertyName = " issue-date")]
		public string issuedate { get; set; }
		[JsonProperty(PropertyName = " action-date")]
		public string actiondate { get; set; }
		public string issue { get; set; }
	}
}
