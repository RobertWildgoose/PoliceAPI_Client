using PoliceAPI.Common.Models;
using PoliceAPI.Common.Models.Crime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Interfaces
{
	public interface IStopAndSearchService
	{
		public Task<List<CrimeArea>> GetByForce(string forceId, string date);
		public Task<List<CrimeArea>> GetByArea(string latitude, string longitude, string date);
		public Task<List<CrimeArea>> GetByLocation(string locationId, string date);
	}
}
