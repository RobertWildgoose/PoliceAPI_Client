using ApiUtilities.Common.Models;
using Newtonsoft.Json;
using PoliceAPI.Common.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models
{
	public class StreetLevelOutcomeResponse : BaseResponse
	{
		[JsonProperty(PropertyName = "category")]
		public string Category { get; set; }

		[JsonProperty(PropertyName = "location_type")]
		public string LocationType { get; set; }

		[JsonProperty(PropertyName = "location")]
		public Location Location { get; set; }

		[JsonProperty(PropertyName = "context")]
		public string Context { get; set; }

		[JsonProperty(PropertyName = "outcome_status")]
		public Status OutcomeStatus { get; set; }

		[JsonProperty(PropertyName = "persistent_id")]
		public string PersistentId { get; set; }

		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "location_subtype")]
		public string LocationSubtype { get; set; }

		[JsonProperty(PropertyName = "month")]
		public string Month { get; set; }
	}
}
