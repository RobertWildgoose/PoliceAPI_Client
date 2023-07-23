using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoliceAPI_Client.Common;
using PoliceAPI_Client.Models;
using PoliceAPI_Client.Services.Interfaces;

namespace PoliceAPI_Client.Services.Implementations
{
    public class CrimeService : BaseService, ICrimeService
    {
        public async Task<IEnumerable<StreetLevelCrime>> GetStreetLevelCrimes(SpecificLocation coordinate, string date, string category = Constants.AllCrimes)
        {
            var crimes = await GetList<StreetLevelCrime>($"crimes-street/{category}?{coordinate.ToString()}&date={date}");
            return crimes;
        }

        public async Task<IEnumerable<StreetLevelCrime>> GetStreetLevelCrimes(LocationPolygon polygon, string date, string category = Constants.AllCrimes)
        {
            var crimes = await GetList<StreetLevelCrime>($"crimes-street/{category}?poly={polygon}&date={date}");
            return crimes;
        }

        public async Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, string locationId)
        {
            var outcomes = await GetList<StreetLevelOutcome>($"crimes-street/outcomes-at-location?date={date}&location_id={locationId}");
            return outcomes;
        }

        public async Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, SpecificLocation coordinate)
        {
            var outcomes = await GetList<StreetLevelOutcome>($"crimes-street/outcomes-at-location?date={date}&{coordinate.ToString()}");
            return outcomes;
        }

        public async Task<IEnumerable<StreetLevelOutcome>> GetStreetLevelOutcomes(string date, LocationPolygon polygon)
        {
            var outcomes = await GetList<StreetLevelOutcome>($"crimes-street/outcomes-at-location?date={date}&poly={polygon}");
            return outcomes;
        }
    }
}
