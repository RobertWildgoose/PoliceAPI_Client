using ApiUtilities.Common.Interfaces;
using ApiUtilities.Common.Models;
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
		public NeighbourhoodService(IApiConfig apiConfig, IRequestHandler requestHandler) : base(apiConfig, requestHandler)
		{

		}

		async Task<ResponseContainer<List<Location>>> INeighbourhoodService.GetNeighbourhoodBoundary(string force, string neighbourhoodId)
		{
			var response = await GetEnumerable<Location>($"{force}/{neighbourhoodId}/boundary");
			return response;
		}

		async Task<ResponseContainer<List<Event>>> INeighbourhoodService.GetNeighbourhoodEvents(string force, string neighbourhoodId)
		{
			var response = await GetEnumerable<Event>($"{force}/{neighbourhoodId}/events");
			return response;
		}

		async Task<ResponseContainer<List<Priority>>> INeighbourhoodService.GetNeighbourhoodPriorities(string force, string neighbourhoodId)
		{
			var response = await GetEnumerable<Priority>($"{force}/{neighbourhoodId}/priorities");
			return response;
		}

		async Task<ResponseContainer<List<Identifier>>> INeighbourhoodService.GetNeighbourhoods(string force)
		{
			var response = await GetEnumerable<Identifier>($"{force}/neighbourhoods");
			return response;
		}

		async Task<ResponseContainer<List<TeamMember>>> INeighbourhoodService.GetNeighbourhoodTeam(string force, string neighbourhoodId)
		{
			var response = await GetEnumerable<TeamMember>($"{force}/{neighbourhoodId}/people");
			return response;
		}

		async Task<ResponseContainer<NeighbourhoodSummary>> INeighbourhoodService.GetSpecificNeighbourhood(string force, string neighbourhoodId)
		{
			var response = await Get<NeighbourhoodSummary>($"{force}/{neighbourhoodId}");
			return response;
		}

		async Task<ResponseContainer<NeighbourhoodInfo>> INeighbourhoodService.LocateNeighbourhood(string longitude, string latitude)
		{
			var response = await Get<NeighbourhoodInfo>($"locate-neighbourhood/{longitude},{latitude}");
			return response;
		}
	}
}
