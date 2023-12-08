using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Exceptions
{
	public class MissingParameterException : SystemException
	{
		public string ParameterName { get; set; }
		public MissingParameterException(string parameterName) : base(String.Format("The Following Parameter Is Missing : ", parameterName))
		{

		}
	}
}
