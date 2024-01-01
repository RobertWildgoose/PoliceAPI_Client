using PoliceAPI.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Sample.Services
{
	public class CrimeServiceDebugger
	{
        private readonly ICrimeService _crimeService;
        public CrimeServiceDebugger(ICrimeService crimeService)
        {
			_crimeService = crimeService;
		}
    }
}
