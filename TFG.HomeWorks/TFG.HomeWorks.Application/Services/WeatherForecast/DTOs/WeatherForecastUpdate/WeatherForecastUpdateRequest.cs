using TFG.HomeWorks.Domain.Entities;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastUpdate
{
    public record WeatherForecastUpdateRequest(Guid Id, int TemperatureC, string Summary, WeatherForecastType Type, DateOnly Date, TimeOnly Time);
}
