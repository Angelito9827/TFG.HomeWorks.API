using TFG.HomeWorks.Application.Services.House.DTOs.HouseMembers;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.GetHouseById
{
    public class HouseGetByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? ProfileImage { get; set; }
        public List<HouseMemberDto> Members { get; set; }
    }
}
