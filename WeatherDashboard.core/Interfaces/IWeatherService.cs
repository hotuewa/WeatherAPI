using System.Threading.Tasks;
using WeatherDashboard.Core.DTOs;

namespace WeatherDashboard.Core.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherResponseDto> GetCurrentWeatherAsync(string city);
    }
}