using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Models
{
	public class CrimeLocation : SpecificLocation
	{
		public CrimeLocation(float lat, float lon) : base(lat, lon)
		{

		}

		public CrimeStreet street { get; set; }
	}
}
