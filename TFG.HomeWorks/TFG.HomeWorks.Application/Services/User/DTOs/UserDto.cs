using TFG.HomeWorks.Domain.Entities.UserAggregate;

namespace TFG.HomeWorks.Application.Services.User.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string? LastName1 { get; set; }
        public string? LastName2 { get; set; }
        public DateTime BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string ProfileImage { get; set; }
    }
}
