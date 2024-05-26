using TFG.HomeWorks.Application.Base;

namespace TFG.HomeWorks.Application.Services.House.DTOs.HouseList
{
    public class HouseListRequest : PageListRequest<OrderByHouseListRequest>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
    }
    public class HouseListItemResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
    }

}
