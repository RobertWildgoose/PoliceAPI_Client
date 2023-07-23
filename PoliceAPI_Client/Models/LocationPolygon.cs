using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Models
{
    public class LocationPolygon
    {
        public virtual IEnumerable<SpecificLocation> Coordinates { get; set; }
        public LocationPolygon() { }

        public LocationPolygon(IEnumerable<SpecificLocation> coordinates) : this()
        {
            Coordinates = coordinates;
        }

        public override string ToString()
            => string.Join(':', Coordinates.Select(c => string.Format(CultureInfo.InvariantCulture, "{0},{1}", c.latitude, c.longitude)));
    }
}
