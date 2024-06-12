
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.GetHouseById;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.HouseList;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;

namespace TFG.HomeWorks.Application.Repositories
{
    public interface IHouseRepository
    {
        void Add(House entity);
        Task<int> Count(HouseListRequest request);
        Task<House?> GetById(HouseGetByIdRequest request);
        Task<IEnumerable<House>> List(HouseListRequest request);
        void Update(House entity);
    }
}
