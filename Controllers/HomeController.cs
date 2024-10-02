using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Keather.Api;

namespace Keather.Controllers;

public class HomeController : Controller
{
	private readonly HttpClient _client = new();
	private static readonly string api = "49f84e8e42c52190d6e6449edf12fa63"; 
	private static readonly string city = "Kyiv"; 

    public IActionResult Index()
    {
		var response = _client.GetStringAsync($"http://api.openweathermap.org/data/2.5/forecast?q={city}&appid={api}&units=metric");
		response.Wait();

		if (!response.IsCompletedSuccessfully)
		{
			return View(null);
		}

		return View(JsonConvert.DeserializeObject<Root>(response.Result));
    }

	public IActionResult Hourly()
	{
		return View();
	}

	public IActionResult Daily()
	{
		return View();
	}

	public IActionResult Air()
	{
		return View();
	}
}
