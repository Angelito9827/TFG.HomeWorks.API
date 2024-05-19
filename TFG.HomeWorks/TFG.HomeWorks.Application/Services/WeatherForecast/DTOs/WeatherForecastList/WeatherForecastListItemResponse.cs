using TFG.HomeWorks.Domain.Entities;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList
{
    /// <summary>
    /// Respuesta de listado de registros de tiempo
    /// </summary>
    public class WeatherForecastListItemResponse
    {
        /// <summary>
        /// Identificador de la entidad
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Temperatura en grados C
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperatura en grados F
        /// </summary>
        public int TemperatureF { get; set; }

        /// <summary>
        /// Texto libre a modo de resumen de registro de temperatura
        /// </summary>
        /// <example>Texto de ejemplo</example>
        public string? Summary { get; set; }

        /// <summary>
        /// Tipo de medición
        /// </summary>
        public WeatherForecastType Type { get; set; }

        /// <summary>
        /// Campo de solo fecha
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Campo de solo hora
        /// </summary>
        public TimeOnly Time { get; set; }
    }
}
