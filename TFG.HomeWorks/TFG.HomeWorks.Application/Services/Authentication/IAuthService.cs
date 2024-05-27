using TFG.HomeWorks.Application.Services.Authentication.DTOs.Register;

namespace TFG.HomeWorks.Application.Services.Authentication
{
    public interface IAuthService
    {
        Task<RegisterResponse> RegisterAsync(RegisterRequest request);
    }
}
