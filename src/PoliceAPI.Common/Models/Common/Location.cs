using ApiUtilities.Common.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Common
{
	public class Location : BaseResponse
	{
		[JsonProperty(PropertyName = "latitude")]
		public string Latitude { get; set; }

		[JsonProperty(PropertyName = "longitude")]
		public string Longitude { get; set; }

		[JsonProperty(PropertyName = "street")]
		public Identifier Street { get; set; }

		public Location(float lat, float lon)
		{
			Latitude = lat.ToString();
			Longitude = lon.ToString();
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "lat={0}&lng={1}", Latitude, Longitude);
		}
	}
}
