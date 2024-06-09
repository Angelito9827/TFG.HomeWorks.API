using AutoMapper;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CreateHouse
{
    public class HouseCreateResponseProfile : Profile
    {
        public HouseCreateResponseProfile()
        {
            CreateMap<Domain.Entities.HouseAggregate.House, HouseCreateResponse>();
        }
    }
}

