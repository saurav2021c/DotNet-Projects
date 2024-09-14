using System.Linq;
using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using WeatherAPIs.Models;
using WeatherAPIs.Services;

namespace WeatherAPIs.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;
        private string ApiKey;

        public WeatherForecastService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
             ApiKey = configuration["OpenWeatherMapApiKey"];
        }

        public async Task<WeatherForecast> GetWeatherForecastAsync(string location, string date)
        {
            var apiKey = ApiKey;
            var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/forecast?q={location}&appid={apiKey}");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var data = await response.Content.ReadFromJsonAsync<OpenWeatherMapResponse>();
            var forecast = data.List.FirstOrDefault(x => x.DtTxt == date);

            if (forecast == null)
            {
                return null;
            }

            return new WeatherForecast
            {
                Date = forecast.DtTxt,
                TemperatureC = (int)(forecast.Main.Temp - 273.15), // Kelvin to Celsius
                WeatherConditions = forecast.Weather.FirstOrDefault()?.Description ?? "No description available",
                Humidity = forecast.Main.Humidity
            };
        }
    }

    public class OpenWeatherMapResponse
    {
        [JsonPropertyName("list")]
        public List<WeatherForecastData> List { get; set; }
    }

    public class WeatherForecastData
    {
        [JsonPropertyName("main")]
        public Main Main { get; set; }

        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; }

        [JsonPropertyName("dt_txt")]
        public string DtTxt { get; set; }
    }

    public class Main
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
