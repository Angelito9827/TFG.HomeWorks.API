
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.CreateHouse;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.DeleteHouse;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.GetHouseById;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.HouseList;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.UpdateHouse;

namespace TFG.HomeWorks.Application.Services.House
{
    public interface IHouseService
    {
        Task<HouseCreateResponse> Create(HouseCreateRequest request);
        System.Threading.Tasks.Task Delete(HouseDeleteByIdRequest request);
        Task<HouseGetByIdResponse> GetById(HouseGetByIdRequest request);
        Task<PageListResponse<HouseListItemResponse>> List(HouseListRequest request);
        Task<HouseUpdateResponse> Update(HouseUpdateRequest request);
    }
}
