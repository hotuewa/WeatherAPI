using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherDashboard.Core.Interfaces;

namespace WeatherDashboard.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetWeather(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                return BadRequest();
            }

            var weather = await _weatherService.GetCurrentWeatherAsync(city);

            if (weather == null)
            {
                return NotFound();
            }

            return Ok(weather);
        }
    }
}