using ApiUtilities.Common.Models;
using Newtonsoft.Json;
using PoliceAPI.Common.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAPI.Common.Models.Crime
{
	public class CrimeArea : BaseResponse
	{
		[JsonProperty(PropertyName = "age_range")]
		public string AgeRange { get; set; }

		[JsonProperty(PropertyName = "outcome")]
		public string Outcome { get; set; }

		[JsonProperty(PropertyName = "involved_person")]
		public bool InvolvedPerson { get; set; }

		[JsonProperty(PropertyName = "self_defined_ethnicity")]
		public string SelfDefinedEthnicity { get; set; }

		[JsonProperty(PropertyName = "gender")]
		public string Gender { get; set; }

		[JsonProperty(PropertyName = "legislation")]
		public string Legislation { get; set; }

		[JsonProperty(PropertyName = "outcome_linked_to_object_of_search")]
		public bool OutcomeLinkedToObjectOfSearch { get; set; }

		[JsonProperty(PropertyName = "datetime")]
		public string DateTime { get; set; }

		[JsonProperty(PropertyName = "operation")]
		public bool Operation { get; set; }

		[JsonProperty(PropertyName = "operation_name")]
		public string OperationName { get; set; }

		[JsonProperty(PropertyName = "removal_of_more_than_outer_clothing")]
		public bool RemovalOfMoreThanOuterClothing { get; set; }

		[JsonProperty(PropertyName = "officer_defined_ethnicity")]
		public string OfficerDefinedEthnicity { get; set; }

		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "object_of_search")]
		public string ObjectOfSearch { get; set; }

		[JsonProperty(PropertyName = "outcome_object")]
		public Identifier OutcomeObject { get; set; }

		[JsonProperty(PropertyName = "location")]
		public Location Location { get; set; }
	}
}
