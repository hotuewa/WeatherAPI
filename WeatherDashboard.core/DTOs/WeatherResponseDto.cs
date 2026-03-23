namespace WeatherDashboard.Core.DTOs
{
    public class WeatherResponseDto
    {
        public string CityName { get; set; }
        public double Temperature { get; set; }
        public string Description { get; set; }
        public int Humidity { get; set; }
    }
}