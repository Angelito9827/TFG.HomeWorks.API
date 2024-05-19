using TFG.HomeWorks.Application.ExternalServices;
using TFG.HomeWorks.Application.Services.Sample.DTOs;

namespace TFG.HomeWorks.Application.Services.Sample
{
    public interface ISampleService
    {
        Task<MyIpResponseDto> GetMyIp();
        Task<ExternalServiceResponseDto> GetExternalServiceValue();
        Task<ApplicationSettingsResponseDto> GetApplicationSettingsValue();
    }
}