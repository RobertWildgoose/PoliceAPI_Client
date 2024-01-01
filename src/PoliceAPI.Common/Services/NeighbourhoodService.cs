using ApiUtilities.Common.Interfaces;
using ApiUtilities.Common.Services;
using PoliceAPI.Common.Interfaces;
using PoliceAPI.Common.Models;
using PoliceAPI.Common.Models.Common;
using PoliceAPI.Common.Models.Force;
using PoliceAPI.Common.Models.Neighbourhood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Services
{
	public class NeighbourhoodService : BaseService, INeighbourhoodService
	{
		public NeighbourhoodService(IApiConfig apiConfig, IExceptionHandler exceptionHandler, IRequestHandler requestHandler) : base(apiConfig, exceptionHandler, requestHandler)
		{

		}

		async Task<List<Location>> INeighbourhoodService.GetNeighbourhoodBoundary(string force, string neighbourhoodId)
		{
			var response = await GetDataList<Location>($"{force}/{neighbourhoodId}/boundary");
			return response;
		}

		async Task<List<Event>> INeighbourhoodService.GetNeighbourhoodEvents(string force, string neighbourhoodId)
		{
			var response = await GetDataList<Event>($"{force}/{neighbourhoodId}/events");
			return response;
		}

		async Task<List<Priority>> INeighbourhoodService.GetNeighbourhoodPriorities(string force, string neighbourhoodId)
		{
			var response = await GetDataList<Priority>($"{force}/{neighbourhoodId}/priorities");
			return response;
		}

		async Task<List<Identifier>> INeighbourhoodService.GetNeighbourhoods(string force)
		{
			var response = await GetDataList<Identifier>($"{force}/neighbourhoods");
			return response;
		}

		async Task<List<TeamMember>> INeighbourhoodService.GetNeighbourhoodTeam(string force, string neighbourhoodId)
		{
			var response = await GetDataList<TeamMember>($"{force}/{neighbourhoodId}/people");
			return response;
		}

		async Task<NeighbourhoodSummary> INeighbourhoodService.GetSpecificNeighbourhood(string force, string neighbourhoodId)
		{
			var response = await GetData<NeighbourhoodSummary>($"{force}/{neighbourhoodId}");
			return response;
		}

		async Task<NeighbourhoodInfo> INeighbourhoodService.LocateNeighbourhood(string longitude, string latitude)
		{
			var response = await GetData<NeighbourhoodInfo>($"locate-neighbourhood/{longitude},{latitude}");
			return response;
		}
	}
}
