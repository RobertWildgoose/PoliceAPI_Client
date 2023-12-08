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
	public class NeighbourhoodService : BaseService, INeighbourhoodService
	{
		public async Task<List<SpecificLocation>> GetNeighbourhoodBoundary(string force, string neighbourhoodId)
		{
			ValidateStringParameter(force, "force");
			ValidateStringParameter(neighbourhoodId, "neighbourhoodId");
			var neighbourhoods = await GetItems<SpecificLocation>($"{force}/{neighbourhoodId}/boundary");
			return neighbourhoods;
		}

		public async Task<List<NeighbourhoodEvent>> GetNeighbourhoodEvents(string force, string neighbourhoodId)
		{
			ValidateStringParameter(force, "force");
			ValidateStringParameter(neighbourhoodId, "neighbourhoodId");
			var neighbourhood = await GetItems<NeighbourhoodEvent>($"{force}/{neighbourhoodId}/events");
			return neighbourhood;
		}

		public async Task<List<Priority>> GetNeighbourhoodPriorities(string force, string neighbourhoodId)
		{
			ValidateStringParameter(force, "force");
			ValidateStringParameter(neighbourhoodId, "neighbourhoodId");
			var neighbourhood = await GetItems<Priority>($"{force}/{neighbourhoodId}/priorities");
			return neighbourhood;
		}

		public async Task<List<IdentifiedObject>> GetNeighbourhoods(string force)
		{
			ValidateStringParameter(force, "force");
			var neighbourhoods = await GetItems<IdentifiedObject>($"{force}/neighbourhoods");
			return neighbourhoods;
		}

		public async Task<List<NeighbourhoodTeamMember>> GetNeighbourhoodTeam(string force, string neighbourhoodId)
		{
			ValidateStringParameter(force, "force");
			ValidateStringParameter(neighbourhoodId, "neighbourhoodId");
			var neighbourhood = await GetItems<NeighbourhoodTeamMember>($"{force}/{neighbourhoodId}/people");
			return neighbourhood;
		}

		public async Task<SpecificNeighbourhood> GetSpecificNeighbourhood(string force, string neighbourhoodId)
		{
			ValidateStringParameter(force, "force");
			ValidateStringParameter(neighbourhoodId, "neighbourhoodId");
			var neighbourhood = await GetItem<SpecificNeighbourhood>($"{force}/{neighbourhoodId}");
			return neighbourhood;
		}

		public async Task<IdentifiedNeighbourhood> LocateNeighbourhood(string longitude, string latitude)
		{
			ValidateStringParameter(longitude, "longitude");
			ValidateStringParameter(latitude, "latitude");
			var neighbourhood = await GetItem<IdentifiedNeighbourhood>($"locate-neighbourhood/{longitude},{latitude}");
			return neighbourhood;
		}
	}
}
