using TFG.HomeWorks.Domain.Entities;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate
{
    /// <summary>
    /// Solicitud de creación de registro de tiempo
    /// </summary>
    /// <param name="TemperatureC"> Temperatura en grados C </param>
    /// <param name="Summary"> Texto libre a modo de resumen de registro de temperatura </param>
    /// <param name="Type"> Tipo de medición </param>
    /// <param name="Date"> Campo de solo fecha </param>
    /// <param name="Time"> Campo de solo hora </param>
    public record WeatherForecastCreateRequest(int TemperatureC, string Summary, WeatherForecastType Type, DateOnly Date, TimeOnly Time);
}
