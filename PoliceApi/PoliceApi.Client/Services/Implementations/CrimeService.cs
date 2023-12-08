using Microsoft.VisualBasic;
using PoliceApi.Client.Models;
using PoliceApi.Client.Services.Common;
using PoliceApi.Client.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Services.Implementations
{
	public class CrimeService : BaseService, ICrimeService
	{
		public async Task<IEnumerable<StreetLevelCrime>> GetStreetLevelCrimes(SpecificLocation coordinate, string date, string category = "all-crimes")
		{
			var crimes = await GetItems<StreetLevelCrime>($"crimes-street/{category}?{coordinate.ToString()}&date={date}");
			return crimes;
		}

		public async Task<IEnumerable<StreetLevelCrime>> GetStreetLevelCrimes(LocationPolygon polygon, string date, string category = "all-crimes")
		{
			var crimes = await GetItems<StreetLevelCrime>($"crimes-street/{category}?poly={polygon}&date={date}");
			return crimes;
		}

		public async Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, string locationId)
		{
			var outcomes = await GetItems<StreetLevelOutcome>($"crimes-street/outcomes-at-location?date={date}&location_id={locationId}");
			return outcomes;
		}

		public async Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, SpecificLocation coordinate)
		{
			var outcomes = await GetItems<StreetLevelOutcome>($"crimes-street/outcomes-at-location?date={date}&{coordinate.ToString()}");
			return outcomes;
		}

		public async Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, LocationPolygon polygon)
		{
			var outcomes = await GetItems<StreetLevelOutcome>($"crimes-street/outcomes-at-location?date={date}&poly={polygon}");
			return outcomes;
		}
	}
}
