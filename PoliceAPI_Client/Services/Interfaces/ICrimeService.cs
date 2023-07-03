using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Services.Interfaces
{
    public interface ICrimeService
    {
        public Task<string> GetStreetLevelCrimes();
        public Task<string> GetStreetLevelOutcomes();
        public Task<string> GetCrimesAtLocation();
        public Task<string> GetCrimesWithNoLocation();
        public Task<string> GetCrimeCategories();
        public Task<string> GetLastUpdated();
        public Task<string> GetOutcomesForSpecificCrime();
    }
}
