using Microsoft.AspNetCore.Mvc;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.WeatherForecast;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastGetById;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastUpdate;

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
        /// Obtiene un listado páginado, filtrado y ordenado de prónosticos del tiempo
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<PageListResponse<WeatherForecastListItemResponse>> List([FromQuery] WeatherForecastListRequest request)
        {
            return await _weatherForecastService.List(request);
        }

        /// <summary>
        /// Obtiene una previsión del tiempo por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<WeatherForecastGetByIdResponse> GetById(Guid id)
        {
            var request = new WeatherForecastGetByIdRequest(id);
            return await _weatherForecastService.GetById(request);
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
        /// <summary>
        /// Modifica un registro de temperatura
        /// </summary>
        /// <param name="request"></param>
        [HttpPut(Name = "UpdateWeatherForecast")]
        public Task Update(WeatherForecastUpdateRequest request)
        {
            return _weatherForecastService.Update(request);
        }
    }
}