using PoliceAPI_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Services.Interfaces
{
    public interface IForceService
    {
        public Task<List<Force>> GetForces();
        public Task<ForceDetails> GetSpecificForce(string id);
        public Task<List<ForceSeniorOfficer>> GetForceSeniorOfficers(string id);
    }
}
