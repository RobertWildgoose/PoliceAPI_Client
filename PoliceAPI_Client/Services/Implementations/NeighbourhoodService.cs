using PoliceAPI_Client.Common;
using PoliceAPI_Client.Models;
using PoliceAPI_Client.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Services.Implementations
{
    public class NeighbourhoodService : BaseService, INeighbourhoodService
    {
        public async Task<List<SpecificLocation>> GetNeighbourhoodBoundary(string force, string neighbourhoodId)
        {
            var neighbourhoods = await GetList<SpecificLocation>($"{force}/{neighbourhoodId}/boundary");
            return neighbourhoods;
        }

        public async Task<List<NeighbourhoodEvent>> GetNeighbourhoodEvents(string force, string neighbourhoodId)
        {
            var neighbourhood = await GetList<NeighbourhoodEvent>($"{force}/{neighbourhoodId}/events");
            return neighbourhood;
        }

        public async Task<List<Priority>> GetNeighbourhoodPriorities(string force, string neighbourhoodId)
        {
            var neighbourhood = await GetList<Priority>($"{force}/{neighbourhoodId}/priorities");
            return neighbourhood;
        }

        public async Task<List<IdentifiedObject>> GetNeighbourhoods(string force)
        {
            var neighbourhoods = await GetList<IdentifiedObject>($"{force}/neighbourhoods");
            return neighbourhoods;
        }

        public async Task<List<NeighbourhoodTeamMember>> GetNeighbourhoodTeam(string force, string neighbourhoodId)
        {
            var neighbourhood = await GetList<NeighbourhoodTeamMember>($"{force}/{neighbourhoodId}/people");
            return neighbourhood;
        }

        public async Task<SpecificNeighbourhood> GetSpecificNeighbourhood(string force, string neighbourhoodId)
        {
            var neighbourhood = await GetItem<SpecificNeighbourhood>($"{force}/{neighbourhoodId}");
            return neighbourhood;
        }

        public async Task<IdentifiedNeighbourhood> LocateNeighbourhood(string longitude, string latitude)
        {
            var neighbourhood = await GetItem<IdentifiedNeighbourhood>($"locate-neighbourhood/{longitude},{latitude}");
            return neighbourhood;
        }
    }
}
