using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoliceAPI_Client.Common;
using PoliceAPI_Client.Services.Interfaces;

namespace PoliceAPI_Client.Services.Implementations
{
    public class CrimeService : BaseService, ICrimeService
    {
        public Task<string> GetCrimeCategories()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetCrimesAtLocation()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetCrimesWithNoLocation()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetLastUpdated()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetOutcomesForSpecificCrime()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetStreetLevelCrimes()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetStreetLevelOutcomes()
        {
            throw new NotImplementedException();
        }
    }
}
