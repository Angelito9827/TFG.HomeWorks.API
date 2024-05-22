using FluentValidation;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList
{
    public class WeatherForecastRequestValidator : AbstractValidator<WeatherForecastListRequest>
    {
        public WeatherForecastRequestValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(0);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
