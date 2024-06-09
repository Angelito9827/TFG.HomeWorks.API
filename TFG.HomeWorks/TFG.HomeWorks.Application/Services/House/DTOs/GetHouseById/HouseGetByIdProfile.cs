
using AutoMapper;

namespace TFG.HomeWorks.Application.Services.House.DTOs.GetHouseById
{
    public class HouseGetByIdProfile : Profile
    {
        public HouseGetByIdProfile()
        {
            CreateMap<Domain.Entities.HouseAggregate.House, HouseGetByIdResponse>();
        }
    }
}
