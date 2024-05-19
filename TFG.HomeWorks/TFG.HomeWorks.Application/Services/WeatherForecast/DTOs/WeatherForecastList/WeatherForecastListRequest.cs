using FluentValidation;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Domain.Entities;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList
{

    /// <summary>
    /// Solicitud de listado de registros de tiempo
    /// </summary>
    public class WeatherForecastListRequest : PageListRequest<WeatherForecastListRequestOrderBy>
    {
        /// <summary>
        /// Filtros de la request
        /// </summary>
        public DateTime? CreateDate { get; set; }
        public DateOnly? Date { get; set; }
        public TimeOnly? Time { get; set; }
        public int? TemperatureC { get; set; }
        public int? TemperatureF { get; set; }
        public string? Summary { get; set; }
        public WeatherForecastType? Type { get; set; }
    }
    public class WeatherForecastRequestValidator : AbstractValidator<WeatherForecastListRequest>
    {
        public WeatherForecastRequestValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(1);
        }
    }
}
