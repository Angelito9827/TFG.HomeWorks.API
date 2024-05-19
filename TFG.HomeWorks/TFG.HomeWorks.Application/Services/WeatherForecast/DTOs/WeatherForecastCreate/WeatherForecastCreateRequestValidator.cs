using FluentValidation;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate
{
    public class WeatherForecastCreateRequestValidator : AbstractValidator<WeatherForecastCreateRequest>
    {
        public WeatherForecastCreateRequestValidator()
        {
            RuleFor(x => x.Type).NotNull();
        }
    }
}
