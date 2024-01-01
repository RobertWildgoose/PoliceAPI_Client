using ApiUtilities.Common.Interfaces;
using ApiUtilities.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoliceAPI.Common.Interfaces;
using PoliceAPI.Common.Services;

namespace PoliceAPI.Common
{
	public class RegistrationContainer : BaseRegistrationContainer
	{
		public RegistrationContainer(IServiceCollection collection) : base(collection)
		{
			collection.AddSingleton<IApiConfig, ApiConfig>();
		}

		public override void ExtendRegistration(IServiceCollection collection)
		{
			base.ExtendRegistration(collection);
			collection.AddSingleton<ICrimeService, CrimeService>();
			collection.AddSingleton<IForceService, ForceService>();
			collection.AddSingleton<INeighbourhoodService, NeighbourhoodService>();
			collection.AddSingleton<IStopAndSearchService, StopAndSearchService>();
		}
	}
}
