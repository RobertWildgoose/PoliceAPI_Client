using PoliceAPI.Common.Models;
using PoliceAPI.Common.Models.Common;
using PoliceAPI.Common.Models.Neighbourhood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Interfaces
{
	public interface INeighbourhoodService
	{
		public Task<List<Location>> GetNeighbourhoodBoundary(string force, string neighbourhoodId);
		public Task<List<Event>> GetNeighbourhoodEvents(string force, string neighbourhoodId);
		public Task<List<Priority>> GetNeighbourhoodPriorities(string force, string neighbourhoodId);
		public Task<List<Identifier>> GetNeighbourhoods(string force);
		public Task<List<TeamMember>> GetNeighbourhoodTeam(string force, string neighbourhoodId);
		public Task<NeighbourhoodSummary> GetSpecificNeighbourhood(string force, string neighbourhoodId);
		public Task<NeighbourhoodInfo> LocateNeighbourhood(string longitude, string latitude);
	}
}
