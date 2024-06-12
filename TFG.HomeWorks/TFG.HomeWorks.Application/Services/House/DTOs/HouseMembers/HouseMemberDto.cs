using TFG.HomeWorks.Application.Services.User.DTOs;

namespace TFG.HomeWorks.Application.Services.House.DTOs.HouseMembers
{
    public class HouseMemberDto
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public UserDto User { get; set; }
    }
}
