using WeatherAPIs.Models;

namespace WeatherAPIs.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast> GetWeatherForecastAsync(string location, string date);

    }
}
