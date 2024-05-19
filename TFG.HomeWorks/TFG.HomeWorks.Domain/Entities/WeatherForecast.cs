using TFG.HomeWorks.Domain.Entities.Base;

namespace TFG.HomeWorks.Domain.Entities
{
    public enum WeatherForecastType
    {
        Indoor,
        Outdoor
    }

    public class WeatherForecast : BaseEntity<Guid>
    {
        public DateTime CreateDate { get; set; }

        public DateOnly Date { get; set; }

        public TimeOnly Time { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public WeatherForecastType Type { get; set; }
    }
}
