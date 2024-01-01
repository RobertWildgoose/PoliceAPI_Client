using ApiUtilities.Common.Models;
using Newtonsoft.Json;
using PoliceAPI.Common.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Neighbourhood
{
	public class NeighbourhoodSummary : BaseResponse
	{
		[JsonProperty(PropertyName = "url_force")]
		public string UrlForce { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "centre")]
		public Location Centre { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "population")]
		public string Population { get; set; }

		[JsonProperty(PropertyName = "links")]
		public List<Identifier> Links { get; set; }

		[JsonProperty(PropertyName = "locations")]
		public List<NeighbourhoodLocation> Locations { get; set; }

		[JsonProperty(PropertyName = "contact_details")]
		public ContactDetails ContactDetails { get; set; }
	}
}
