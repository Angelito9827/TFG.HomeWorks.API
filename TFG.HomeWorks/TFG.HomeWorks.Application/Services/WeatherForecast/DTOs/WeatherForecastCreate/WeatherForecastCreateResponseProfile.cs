using AutoMapper;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate
{
    public class WeatherForecastCreateResponseProfile : Profile
    {
        public WeatherForecastCreateResponseProfile()
        {
            CreateMap<Domain.Entities.WeatherForecast, WeatherForecastCreateResponse>();
        }
    }
}
