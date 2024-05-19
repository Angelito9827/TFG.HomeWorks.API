using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TFG.HomeWorks.Application.ExternalServices;
using TFG.HomeWorks.Application.Services.Sample;
using TFG.HomeWorks.Application.Services.Sample.DTOs;

namespace TFG.HomeWorks.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService _templateService;

        public SampleController(ISampleService templateService)
        {
            _templateService = templateService;
        }

        /// <summary>
        /// Obtiene la ip del servidor
        /// </summary>
        [HttpGet("my-ip")]
        public Task<MyIpResponseDto> GetMyIp()
        {
            return _templateService.GetMyIp();
        }

        /// <summary>
        /// Obtiene un valor
        /// </summary>
        [HttpGet("some-value")]
        [AllowAnonymous]
        public Task<ExternalServiceResponseDto> GetSomeValue()
        {
            return _templateService.GetExternalServiceValue();
        }

        /// <summary>
        /// Obtiene un valor
        /// </summary>
        [HttpGet("appsettings-value")]
        [AllowAnonymous]
        public Task<ApplicationSettingsResponseDto> GetAppSettingsValue()
        {
            return _templateService.GetApplicationSettingsValue();
        }
    }
}