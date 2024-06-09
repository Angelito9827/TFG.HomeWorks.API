
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.House.DTOs.CreateHouse;
using TFG.HomeWorks.Application.Services.House.DTOs.GetHouseById;
using TFG.HomeWorks.Application.Services.House.DTOs.HouseList;

namespace TFG.HomeWorks.Application.Services.House
{
    public interface IHouseService
    {
        Task<HouseCreateResponse> Create(HouseCreateRequest request);
        Task<HouseGetByIdResponse> GetById(HouseGetByIdRequest request);
        Task<PageListResponse<HouseListItemResponse>> List(HouseListRequest request);
    }
}
