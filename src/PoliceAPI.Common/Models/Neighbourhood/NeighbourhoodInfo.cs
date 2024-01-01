using ApiUtilities.Common.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Neighbourhood
{
	public class NeighbourhoodInfo : BaseResponse
	{
		[JsonProperty(PropertyName = "force")]
		public string Force { get; set; }

		[JsonProperty(PropertyName = "neighbourhood")]
		public string Neighbourhood { get; set; }
	}
}
