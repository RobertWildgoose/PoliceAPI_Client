using PoliceApi.Client.Models;
using PoliceApi.Client.Services.Common;
using PoliceApi.Client.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Services.Implementations
{
	public class ForceService : BaseService, IForceService
	{
		public async Task<List<Force>> GetForces()
		{
			var forces = await GetItems<Force>("forces");
			return forces;
		}

		public async Task<ForceDetails> GetSpecificForce(string id)
		{
			ValidateStringParameter(id, "id");
			var forcedetails = await GetItem<ForceDetails>($"forces/{id}");
			return forcedetails;
		}

		public async Task<List<ForceSeniorOfficer>> GetForceSeniorOfficers(string id)
		{
			ValidateStringParameter(id, "id");
			var forceSeniorOfficer = await GetItems<ForceSeniorOfficer>($"forces/{id}/people");
			return forceSeniorOfficer;
		}
	}
}
