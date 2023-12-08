using Newtonsoft.Json;
using PoliceApi.Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceApi.Client.Services.Common
{
	public class BaseService
	{
		public required string BaseUrl;

		public async Task<T> GetItem<T>(string url) where T : class
		{
			using (HttpClient client = new HttpClient())
			{
				try
				{
					var fullUrl = $"{BaseUrl}{url}";
					HttpResponseMessage response = await client.GetAsync(fullUrl);
					response.EnsureSuccessStatusCode();
					string json = await response.Content.ReadAsStringAsync();
					return JsonConvert.DeserializeObject<T>(json ?? string.Empty);
				}
				catch (HttpRequestException ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
					return null;
				}
			}
		}

		public async Task<List<T>> GetItems<T>(string url) where T : class
		{
			using (HttpClient client = new HttpClient())
			{
				try
				{
					var fullUrl = $"{BaseUrl}{url}";
					HttpResponseMessage response = await client.GetAsync(fullUrl);
					response.EnsureSuccessStatusCode();
					string json = await response.Content.ReadAsStringAsync();
					return JsonConvert.DeserializeObject<List<T>>(json ?? string.Empty);
				}
				catch (HttpRequestException ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
					return null;
				}
			}
		}

		public void ValidateStringParameter(string value, string key)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new MissingParameterException(key);
			}
		}
	}
}
