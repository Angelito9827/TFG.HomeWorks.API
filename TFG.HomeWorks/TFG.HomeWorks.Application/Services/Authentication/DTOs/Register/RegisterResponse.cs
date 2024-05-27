using AutoMapper;
using TFG.HomeWorks.Domain.Entities.UserAggregate;

namespace TFG.HomeWorks.Application.Services.Authentication.DTOs.Register
{
    public record RegisterResponse(string Email, string Username, string FirstName, string? LastName1, string? LastName2, DateTime BirthDate, string? PhoneNumber, Gender Gender, string ProfileImage);

    public class RegisterResponseProfile : Profile
    {
        public RegisterResponseProfile()
        {
            CreateMap<User, RegisterResponse>();
        }
    }
}
