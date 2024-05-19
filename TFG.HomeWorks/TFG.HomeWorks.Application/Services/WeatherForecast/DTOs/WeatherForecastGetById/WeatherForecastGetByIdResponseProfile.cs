using AutoMapper;

namespace TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastGetById
{
    public class WeatherForecastGetByIdResponseProfile : Profile
    {
        public WeatherForecastGetByIdResponseProfile()
        {
            CreateMap<Domain.Entities.WeatherForecast, WeatherForecastGetByIdResponse>();
        }
    }

}
