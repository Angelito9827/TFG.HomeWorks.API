using Microsoft.AspNetCore.Mvc;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.WeatherForecast;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;

namespace TFG.HomeWorks.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        /// <summary>
        /// Obtiene los últimos <paramref name="amount"/> registros de temperatura
        /// </summary>
        /// <param name="amount">Number of elements to obtain. Must be a value greater than 0</param>
        /// <returns></returns>
        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<PageListResponse<WeatherForecastListItemResponse>> List(WeatherForecastListRequest request)
        {
            return await _weatherForecastService.List(request);
        }

        /// <summary>
        /// Crea un registro de temperatura
        /// </summary>
        /// <param name="request"></param>
        [HttpPost(Name = "CreateWeatherForecast")]
        public Task Create(WeatherForecastCreateRequest request)
        {
            return _weatherForecastService.Create(request);
        }
    }
}