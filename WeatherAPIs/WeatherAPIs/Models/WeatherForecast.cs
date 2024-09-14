using System.Text.Json.Serialization;

namespace WeatherAPIs.Models
{
    public class WeatherForecast
    {
        [JsonPropertyName("dt_txt")]
        public string Date { get; set; }
        public int TemperatureC { get; set; }
        public string WeatherConditions { get; set; }
        public int Humidity { get; set; }
    }
}
