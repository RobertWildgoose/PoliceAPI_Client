using ApiUtilities.Common.Models;
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
		public Task<ResponseContainer<List<Location>>> GetNeighbourhoodBoundary(string force, string neighbourhoodId);
		public Task<ResponseContainer<List<Event>>> GetNeighbourhoodEvents(string force, string neighbourhoodId);
		public Task<ResponseContainer<List<Priority>>> GetNeighbourhoodPriorities(string force, string neighbourhoodId);
		public Task<ResponseContainer<List<Identifier>>> GetNeighbourhoods(string force);
		public Task<ResponseContainer<List<TeamMember>>> GetNeighbourhoodTeam(string force, string neighbourhoodId);
		public Task<ResponseContainer<NeighbourhoodSummary>> GetSpecificNeighbourhood(string force, string neighbourhoodId);
		public Task<ResponseContainer<NeighbourhoodInfo>> LocateNeighbourhood(string longitude, string latitude);
	}
}
