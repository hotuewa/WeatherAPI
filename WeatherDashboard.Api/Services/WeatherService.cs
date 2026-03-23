using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherDashboard.Core.DTOs;
using WeatherDashboard.Core.Interfaces;

namespace WeatherDashboard.Api.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "2a8c43697580728ec829981c3156b381";

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherResponseDto> GetCurrentWeatherAsync(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric&lang=pl";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();
            var openWeatherResult = JsonSerializer.Deserialize<OpenWeatherResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (openWeatherResult == null)
            {
                return null;
            }

            return new WeatherResponseDto
            {
                CityName = openWeatherResult.Name,
                Temperature = openWeatherResult.Main.Temp,
                Humidity = openWeatherResult.Main.Humidity,
                Description = openWeatherResult.Weather[0].Description
            };
        }
    }

    public class OpenWeatherResponse
    {
        public string Name { get; set; }
        public MainData Main { get; set; }
        public WeatherData[] Weather { get; set; }
    }

    public class MainData
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class WeatherData
    {
        public string Description { get; set; }
    }
}