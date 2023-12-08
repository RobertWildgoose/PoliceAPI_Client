using Microsoft.Extensions.DependencyInjection;
using PoliceApi.Client.Services.Implementations;
using PoliceApi.Client.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client
{
	public class ContainerRegistry
	{
        public ContainerRegistry(IServiceCollection services)
        {
			services.AddSingleton<ICrimeService, CrimeService>();
			services.AddSingleton<IForceService, ForceService>();
			services.AddSingleton<INeighbourhoodService, NeighbourhoodService>();
			services.AddSingleton<IStopAndSearchService, StopAndSearchService>();
		}
    }
}
