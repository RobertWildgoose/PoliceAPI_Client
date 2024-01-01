using ApiUtilities.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common
{
	public class ApiConfig : IApiConfig
	{
		public string BaseUrl { get => "https://data.police.uk/api/"; set => throw new NotImplementedException(); }
	}
}
