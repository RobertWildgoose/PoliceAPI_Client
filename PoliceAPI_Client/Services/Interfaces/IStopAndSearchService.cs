using PoliceAPI_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI_Client.Services.Interfaces
{
    public interface IStopAndSearchService
    {
        public Task<List<CrimeByArea>> GetByForce(string forceId, string date);
        public Task<List<CrimeByArea>> GetByArea(string latitude, string longitude, string date);
        public Task<List<CrimeByArea>> GetByLocation(string locationId, string date);
    }
}
