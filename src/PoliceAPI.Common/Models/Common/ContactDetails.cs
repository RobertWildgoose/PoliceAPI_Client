using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Common
{
	public class ContactDetails
	{
		[JsonProperty(PropertyName = "twitter")]
		public string Twitter { get; set; }

		[JsonProperty(PropertyName = "facebook")]
		public string Facebook { get; set; }

		[JsonProperty(PropertyName = "telephone")]
		public string Telephone { get; set; }

		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }
	}
}
