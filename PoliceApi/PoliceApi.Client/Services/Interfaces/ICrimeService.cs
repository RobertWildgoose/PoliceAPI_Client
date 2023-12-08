using PoliceApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Services.Interfaces
{
	public interface ICrimeService
	{
		public Task<IEnumerable<StreetLevelCrime>> GetStreetLevelCrimes(SpecificLocation coordinate, string date, string category = "all-crime");
		public Task<IEnumerable<StreetLevelCrime>> GetStreetLevelCrimes(LocationPolygon polygon, string date, string category = "all-crime");
		public Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, string locationId);
		public Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, SpecificLocation coordinate);
		public Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, LocationPolygon polygon);
	}
}
