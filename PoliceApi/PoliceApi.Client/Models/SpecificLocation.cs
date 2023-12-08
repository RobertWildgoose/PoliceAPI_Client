using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Models
{
	public class SpecificLocation
	{
		public string latitude { get; set; }
		public string longitude { get; set; }

		public SpecificLocation(float lat, float lon)
		{
			latitude = lat.ToString();
			longitude = lon.ToString();
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "lat={0}&lng={1}", latitude, longitude);
		}
	}
}
