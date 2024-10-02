using Newtonsoft.Json;

namespace Keather.Api;

public static class ApiService
{
	private static readonly string api = "49f84e8e42c52190d6e6449edf12fa63"; 

	public static async Task<Root> GetWeather(string city)
	{
		using (var handler = new HttpClientHandler())
		using (var client = new HttpClient(handler))
		{
			client.BaseAddress = new Uri("api.openweathermap.org/data/2.5/");
			var response = await client.GetStringAsync($"forecast?q={city}&appid={api}");
			return JsonConvert.DeserializeObject<Root>(response);
		}
	}
}
