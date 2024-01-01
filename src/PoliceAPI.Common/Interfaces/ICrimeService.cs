using PoliceAPI.Common.Models;
using PoliceAPI.Common.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Interfaces
{
	public interface ICrimeService
	{
		public Task<IEnumerable<StreetLevelCrimeResponse>> GetStreetLevelCrimes(Location coordinate, string date, string category = "all-crime");
		public Task<IEnumerable<StreetLevelCrimeResponse>> GetStreetLevelCrimes(Polygon polygon, string date, string category = "all-crime");
		public Task<IEnumerable<StreetLevelOutcomeResponse>> GetStreetLevelOutcomes(string date, string locationId);
		public Task<IEnumerable<StreetLevelOutcomeResponse>> GetStreetLevelOutcomes(string date, Location coordinate);
		public Task<IEnumerable<StreetLevelOutcomeResponse>> GetStreetLevelOutcomes(string date, Polygon polygon);
	}
}
