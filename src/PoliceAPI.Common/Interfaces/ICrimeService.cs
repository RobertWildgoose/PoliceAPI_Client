using ApiUtilities.Common.Models;
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
		public Task<ResponseContainer<List<StreetLevelCrimeResponse>>> GetStreetLevelCrimes(Location coordinate, string date, string category = "all-crime");
		public Task<ResponseContainer<List<StreetLevelCrimeResponse>>> GetStreetLevelCrimes(Polygon polygon, string date, string category = "all-crime");
		public Task<ResponseContainer<List<StreetLevelOutcomeResponse>>> GetStreetLevelOutcomes(string date, string locationId);
		public Task<ResponseContainer<List<StreetLevelOutcomeResponse>>> GetStreetLevelOutcomes(string date, Location coordinate);
		public Task<ResponseContainer<List<StreetLevelOutcomeResponse>>> GetStreetLevelOutcomes(string date, Polygon polygon);
	}
}
