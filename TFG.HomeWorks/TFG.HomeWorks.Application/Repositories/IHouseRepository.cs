
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.GetHouseById;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.HouseList;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;

namespace TFG.HomeWorks.Application.Repositories
{
    public interface IHouseRepository
    {
        void Add(House entity);
        Task<IEnumerable<House>> List(HouseListRequest request);
        void Delete(House entity);
        void Update(House entity);
        Task<House?> GetById(HouseGetByIdRequest request);
        Task<int> Count(HouseListRequest request);
    }
}
