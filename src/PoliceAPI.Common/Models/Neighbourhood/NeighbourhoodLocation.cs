using Newtonsoft.Json;
using PoliceAPI.Common.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Neighbourhood
{
	public class NeighbourhoodLocation : Location
	{
		public NeighbourhoodLocation(float lat, float lon) : base(lat, lon)
		{

		}

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }


		[JsonProperty(PropertyName = "postcode")]
		public string Postcode { get; set; }

		[JsonProperty(PropertyName = "address")]
		public string Address { get; set; }

		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }
	}
}
