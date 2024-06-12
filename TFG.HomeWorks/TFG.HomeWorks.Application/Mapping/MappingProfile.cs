using AutoMapper;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.GetHouseById;
using TFG.HomeWorks.Application.Services.House.DTOs.HouseMembers;
using TFG.HomeWorks.Application.Services.User.DTOs;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;
using TFG.HomeWorks.Domain.Entities;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;
using TFG.HomeWorks.Domain.Entities.UserAggregate;

namespace TFG.HomeWorks.Application.Mapping
{
    /// <summary>
    /// Configuración de los mapeos
    /// </summary>
    /// <remarks>
    /// Idealmente, se utilizará para mapear la salida de los métodos de servicio
    /// </remarks>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastListItemResponse>()
                .ForMember(x => x.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(x => x.Time, opt => opt.MapFrom(src => src.Time))
                .ForMember(x => x.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(x => x.TemperatureC, opt => opt.MapFrom(src => src.TemperatureC))
                .ForMember(x => x.TemperatureF, opt => opt.MapFrom(src => src.TemperatureF))
                .ForMember(x => x.Summary, opt => opt.MapFrom(src => src.Summary));

            CreateMap<User, UserDto>();
            CreateMap<HouseMember, HouseMemberDto>();
            CreateMap<House, HouseGetByIdResponse>()
                .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.Members));
        }
    }
}