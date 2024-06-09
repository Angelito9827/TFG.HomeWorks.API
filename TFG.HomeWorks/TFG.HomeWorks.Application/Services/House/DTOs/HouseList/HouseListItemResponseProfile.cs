using AutoMapper;

namespace TFG.HomeWorks.Application.Services.House.DTOs.HouseList
{
    public class HouseListItemResponseProfile : Profile
    {
        public HouseListItemResponseProfile()
        {
            CreateMap<Domain.Entities.HouseAggregate.House, HouseListItemResponse>();
        }
    }
}
