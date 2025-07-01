namespace Avalonia.Models
{
    public class WeatherData
    {
        public required string CountryCityName { get; set; }
        public double Temperature { get; set; }
        public required string Description {  get; set; }
        public DateTime DateTime { get; set; }
        public required string Country { get; set; }

    }
}
