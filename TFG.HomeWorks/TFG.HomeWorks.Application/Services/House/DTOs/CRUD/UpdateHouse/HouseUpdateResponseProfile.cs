using AutoMapper;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.UpdateHouse
{
    public class HouseUpdateResponseProfile : Profile
    {
        public HouseUpdateResponseProfile()
        {
            CreateMap<Domain.Entities.HouseAggregate.House, HouseUpdateResponse>();
        }
    }
}

