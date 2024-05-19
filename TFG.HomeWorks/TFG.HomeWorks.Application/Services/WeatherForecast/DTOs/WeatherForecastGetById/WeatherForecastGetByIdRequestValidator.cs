using FluentValidation;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastGetById
{
    public class WeatherForecastGetByIdRequestValidator : AbstractValidator<WeatherForecastGetByIdRequest>
    {
        public WeatherForecastGetByIdRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
