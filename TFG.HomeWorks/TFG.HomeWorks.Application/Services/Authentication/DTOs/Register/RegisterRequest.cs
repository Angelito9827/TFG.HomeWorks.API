using TFG.HomeWorks.Domain.Entities.UserAggregate;

namespace TFG.HomeWorks.Application.Services.Authentication.DTOs.Register
{
    public record RegisterRequest(string Email, string Username, string FirstName, string? LastName1, string? LastName2, DateTime BirthDate, string? PhoneNumber, string Password, Gender Gender, string ProfileImage, Roles Role);
}
