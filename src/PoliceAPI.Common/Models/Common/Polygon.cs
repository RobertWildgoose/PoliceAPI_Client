using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Common
{
	public class Polygon
	{
		public IEnumerable<Location> Coordinates { get; set; }

		public Polygon(IEnumerable<Location> coordinates)
		{
			Coordinates = coordinates;
		}

		public override string ToString() => string.Join(':', Coordinates.Select(c => string.Format(CultureInfo.InvariantCulture, "{0},{1}", c.Latitude, c.Longitude)));
	}
}
