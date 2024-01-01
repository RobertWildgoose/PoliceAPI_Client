using ApiUtilities.Common.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Force
{
	public class Officer : BaseResponse
	{
		[JsonProperty(PropertyName = "bio")]
		public string Bio { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "rank")]
		public string Rank { get; set; }

		[JsonProperty(PropertyName = "contact_details")]
		public IDictionary<string, string> ContactDetails { get; set; }
	}
}
