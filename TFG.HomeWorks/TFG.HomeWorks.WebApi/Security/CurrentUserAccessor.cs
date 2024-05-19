using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using TFG.HomeWorks.Application.Security;

namespace TFG.HomeWorks.WebApi.Services
{
    public class CurrentUserAccessor : ICurrentUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public CurrentUser CurrentUser => new()
        {
            Email = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email)!.Value,
            Roles = _httpContextAccessor.HttpContext.User.FindAll(ClaimTypes.Role).Select(x => x.Value)
        };
    }
}
