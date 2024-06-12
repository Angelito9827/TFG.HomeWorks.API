using TFG.HomeWorks.Application.Base;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.HouseList
{
    public class HouseListRequest : PageListRequest<HouseListRequestOrderBy>
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
    }
}
