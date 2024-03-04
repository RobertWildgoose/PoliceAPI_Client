using ApiUtilities.Common.Interfaces;
using ApiUtilities.Common.Models;
using ApiUtilities.Common.Services;
using PoliceAPI.Common.Interfaces;
using PoliceAPI.Common.Models;
using PoliceAPI.Common.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Services
{
	public class CrimeService : BaseService, ICrimeService
	{
		public CrimeService(IApiConfig apiConfig, IRequestHandler requestHandler) : base(apiConfig, requestHandler)
		{

		}

		async Task<ResponseContainer<List<StreetLevelCrimeResponse>>> ICrimeService.GetStreetLevelCrimes(Location coordinate, string date, string category)
		{
			var response = await GetEnumerable<StreetLevelCrimeResponse>($"crimes-street/{category}?{coordinate.ToString()}&date={date}");
			return response;
		}

		async Task<ResponseContainer<List<StreetLevelCrimeResponse>>> ICrimeService.GetStreetLevelCrimes(Polygon polygon, string date, string category)
		{
			var response = await GetEnumerable<StreetLevelCrimeResponse>($"crimes-street/{category}?poly={polygon}&date={date}");
			return response;
		}

		async Task<ResponseContainer<List<StreetLevelOutcomeResponse>>> ICrimeService.GetStreetLevelOutcomes(string date, string locationId)
		{
			var response = await GetEnumerable<StreetLevelOutcomeResponse>($"crimes-street/outcomes-at-location?date={date}&location_id={locationId}");
			return response;
		}

		async Task<ResponseContainer<List<StreetLevelOutcomeResponse>>> ICrimeService.GetStreetLevelOutcomes(string date, Location coordinate)
		{
			var response = await GetEnumerable<StreetLevelOutcomeResponse>($"crimes-street/outcomes-at-location?date={date}&{coordinate.ToString()}");
			return response;
		}

		async Task<ResponseContainer<List<StreetLevelOutcomeResponse>>> ICrimeService.GetStreetLevelOutcomes(string date, Polygon polygon)
		{
			var response = await GetEnumerable<StreetLevelOutcomeResponse>($"crimes-street/outcomes-at-location?date={date}&poly={polygon}");
			return response;
		}
	}
}
