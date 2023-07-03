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
    public class ForceService : BaseService, IForceService
    {
        public async Task<List<Force>> GetForces()
        {
            var forces = await GetList<Force>("forces");
            return forces;
        }

        public async Task<ForceDetails> GetSpecificForce(string id)
        {
            var forcedetails = await GetItem<ForceDetails>($"forces/{id}");
            return forcedetails;
        }

        public async Task<List<ForceSeniorOfficer>> GetForceSeniorOfficers(string id)
        {
            var forceSeniorOfficer = await GetList<ForceSeniorOfficer>($"forces/{id}/people");
            return forceSeniorOfficer;
        }

    }
}
