using AutoMapper;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.HouseList
{
    public class HouseListItemResponseProfile : Profile
    {
        public HouseListItemResponseProfile()
        {
            CreateMap<Domain.Entities.HouseAggregate.House, HouseListItemResponse>();
        }
    }
}
