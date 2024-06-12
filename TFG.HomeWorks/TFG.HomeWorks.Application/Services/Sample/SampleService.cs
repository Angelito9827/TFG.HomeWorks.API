using Microsoft.Extensions.Options;
using TFG.HomeWorks.Application.ExternalServices;
using TFG.HomeWorks.Application.Options;
using TFG.HomeWorks.Application.Services.Sample.DTOs;

namespace TFG.HomeWorks.Application.Services.Sample
{
    internal class SampleService : ISampleService
    {
        private readonly ApplicationSettings _applicationSettings;
        private readonly IMyIpService _myIpService;
        private readonly IExternalService _externalService;

        public SampleService(
            IOptions<ApplicationSettings> applicationSettingsOptions,
            IMyIpService myIpService,
            IExternalService externalService)
        {
            _applicationSettings = applicationSettingsOptions.Value;
            _myIpService = myIpService;
            _externalService = externalService;
        }

        public async Task<MyIpResponseDto> GetMyIp()
        {
            string ip = await _myIpService.GetIPAsync();
            return new MyIpResponseDto() { Ip = ip };
        }

        public async Task<ExternalServiceResponseDto> GetExternalServiceValue()
        {
            return await _externalService.Test();
        }

        public Task<ApplicationSettingsResponseDto> GetApplicationSettingsValue()
        {
            return System.Threading.Tasks.Task.FromResult(new ApplicationSettingsResponseDto() { ExampleConfigValue = _applicationSettings.ExampleConfigValue });
        }
    }
}
