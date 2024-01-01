using ApiUtilities.Common.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Neighbourhood
{
	public class Priority : BaseResponse
	{
		[JsonProperty(PropertyName = "action")]
		public string Action { get; set; }

		[JsonProperty(PropertyName = "issue-date")]
		public string IssueDate { get; set; }

		[JsonProperty(PropertyName = "action-date")]
		public string ActionDate { get; set; }

		[JsonProperty(PropertyName = "issue")]
		public string Issue { get; set; }
	}
}
