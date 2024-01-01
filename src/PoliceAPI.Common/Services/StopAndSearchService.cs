using ApiUtilities.Common.Interfaces;
using ApiUtilities.Common.Services;
using PoliceAPI.Common.Interfaces;
using PoliceAPI.Common.Models;
using PoliceAPI.Common.Models.Crime;
using PoliceAPI.Common.Models.Neighbourhood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Services
{
	public class StopAndSearchService : BaseService, IStopAndSearchService
	{
		public StopAndSearchService(IApiConfig apiConfig, IExceptionHandler exceptionHandler, IRequestHandler requestHandler) : base(apiConfig, exceptionHandler, requestHandler)
		{

		}

		async Task<List<CrimeArea>> IStopAndSearchService.GetByArea(string latitude, string longitude, string date)
		{
			var response = await GetDataList<CrimeArea>($"stops-street?lat={latitude}&lng={longitude}&date={date}");
			return response;
		}

		async Task<List<CrimeArea>> IStopAndSearchService.GetByForce(string forceId, string date)
		{
			var response = await GetDataList<CrimeArea>($"stops-street?force={forceId}&date={date}");
			return response;
		}

		async Task<List<CrimeArea>> IStopAndSearchService.GetByLocation(string locationId, string date)
		{
			var response = await GetDataList<CrimeArea>($"stops-at-location?location_id={locationId}&date={date}");
			return response;
		}
	}
}
