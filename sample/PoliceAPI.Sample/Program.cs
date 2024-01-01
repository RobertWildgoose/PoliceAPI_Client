using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PoliceAPI.Common;
using PoliceAPI.Common.Interfaces;
using PoliceAPI.Sample.Services;
using static System.Net.Mime.MediaTypeNames;

namespace PoliceAPI.Sample
{
	public class Program
	{
		private static ICrimeService _crimeService { get; set; }
		public static void Main(string[] args)
		{
			var services = new ServiceCollection();
			ConfigureServices(services);
			_crimeService = services.BuildServiceProvider().GetService<ICrimeService>();
			CreateHostBuilder(args).Build().Run();
		}

		private static void ConfigureServices(IServiceCollection services)
		{
			services.AddTransient<RegistrationContainer>();
		}

	}
}
