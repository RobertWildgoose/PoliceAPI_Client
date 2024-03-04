using ApiUtilities.Common.Interfaces;
using ApiUtilities.Common.Models;
using ApiUtilities.Common.Services;
using PoliceAPI.Common.Interfaces;
using PoliceAPI.Common.Models;
using PoliceAPI.Common.Models.Force;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Services
{
	public class ForceService : BaseService, IForceService
	{
		public ForceService(IApiConfig apiConfig, IRequestHandler requestHandler) : base(apiConfig, requestHandler)
		{

		}

		async Task<ResponseContainer<List<Force>>> IForceService.GetForces()
		{
			var response = await GetEnumerable<Force>("forces");
			return response;
		}

		async Task<ResponseContainer<List<Officer>>> IForceService.GetForceSeniorOfficers(string id)
		{
			var response = await GetEnumerable<Officer>($"forces/{id}/people");
			return response;
		}

		async Task<ResponseContainer<ForceInfo>> IForceService.GetSpecificForce(string id)
		{
			var response = await Get<ForceInfo>($"forces/{id}");
			return response;
		}
	}
}
