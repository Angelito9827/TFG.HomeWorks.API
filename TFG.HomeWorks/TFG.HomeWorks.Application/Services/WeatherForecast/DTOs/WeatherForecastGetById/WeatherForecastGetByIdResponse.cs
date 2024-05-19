using TFG.HomeWorks.Domain.Entities;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastGetById
{
    public record WeatherForecastGetByIdResponse(Guid Id, int TemperatureC, string Summary, WeatherForecastType Type, DateOnly Date, TimeOnly Time);

}
