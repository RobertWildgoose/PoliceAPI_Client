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
	public class StopAndSearchService : BaseService, IStopAndSearchService
	{
		public async Task<List<CrimeByArea>> GetByArea(string latitude, string longitude, string date)
		{
			ValidateStringParameter(latitude, "latitude");
			ValidateStringParameter(longitude, "longitude");
			ValidateStringParameter(date, "date");
			var stopAndSearch = await GetItems<CrimeByArea>($"stops-street?lat={latitude}&lng={longitude}&date={date}");
			return stopAndSearch;
		}

		public async Task<List<CrimeByArea>> GetByForce(string forceId, string date)
		{
			ValidateStringParameter(forceId, "forceId");
			ValidateStringParameter(date, "date");
			var stopAndSearch = await GetItems<CrimeByArea>($"stops-street?force={forceId}&date={date}");
			return stopAndSearch;
		}

		public async Task<List<CrimeByArea>> GetByLocation(string locationId, string date)
		{
			ValidateStringParameter(locationId, "locationId");
			ValidateStringParameter(date, "date");
			var stopsAtLocation = await GetItems<CrimeByArea>($"stops-at-location?location_id={locationId}&date={date}");
			return stopsAtLocation;
		}
	}
}
