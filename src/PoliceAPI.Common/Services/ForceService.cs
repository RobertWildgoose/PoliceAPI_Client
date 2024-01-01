using ApiUtilities.Common.Interfaces;
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
		public ForceService(IApiConfig apiConfig, IExceptionHandler exceptionHandler, IRequestHandler requestHandler) : base(apiConfig, exceptionHandler, requestHandler)
		{

		}

		async Task<List<Force>> IForceService.GetForces()
		{
			var response = await GetDataList<Force>("forces");
			return response;
		}

		async Task<List<Officer>> IForceService.GetForceSeniorOfficers(string id)
		{
			var response = await GetDataList<Officer>($"forces/{id}/people");
			return response;
		}

		async Task<ForceInfo> IForceService.GetSpecificForce(string id)
		{
			var response = await GetData<ForceInfo>($"forces/{id}");
			return response;
		}
	}
}
