﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Models
{
	public class StreetLevelOutcome
	{
		public string category { get; set; }
		public string location_type { get; set; }
		public CrimeLocation location { get; set; }
		public string context { get; set; }
		public OutcomeStatus outcome_status { get; set; }
		public string persistent_id { get; set; }
		public string id { get; set; }
		public string location_subtype { get; set; }
		public string month { get; set; }
	}
}
