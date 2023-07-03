using PoliceAPI_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Services.Interfaces
{
    public interface INeighbourhoodService
    {
        public Task<List<SpecificLocation>> GetNeighbourhoodBoundary(string force, string neighbourhoodId);
        public Task<List<NeighbourhoodEvent>> GetNeighbourhoodEvents(string force, string neighbourhoodId);
        public Task<List<Priority>> GetNeighbourhoodPriorities(string force, string neighbourhoodId);
        public Task<List<IdentifiedObject>> GetNeighbourhoods(string force);
        public Task<List<NeighbourhoodTeamMember>> GetNeighbourhoodTeam(string force, string neighbourhoodId);
        public Task<SpecificNeighbourhood> GetSpecificNeighbourhood(string force, string neighbourhoodId);
        public Task<IdentifiedNeighbourhood> LocateNeighbourhood(string longitude, string latitude);
    }
}