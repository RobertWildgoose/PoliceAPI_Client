using PoliceAPI.Common.Models;
using PoliceAPI.Common.Models.Force;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Interfaces
{
	public interface IForceService
	{
		public Task<List<Force>> GetForces();
		public Task<ForceInfo> GetSpecificForce(string id);
		public Task<List<Officer>> GetForceSeniorOfficers(string id);
	}
}
