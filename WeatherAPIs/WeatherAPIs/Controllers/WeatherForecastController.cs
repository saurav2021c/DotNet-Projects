using Microsoft.AspNetCore.Mvc;
using WeatherAPIs.Models;
using WeatherAPIs.Services;

namespace WeatherAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet("{location}/{date}")]
        public async Task<ActionResult<WeatherForecast>> Get(string location, string date)
        {
            var forecast = await _weatherForecastService.GetWeatherForecastAsync(location, date);

            if (forecast == null)
            {
                return NotFound();
            }

            return Ok(forecast);
        }
    }
}
