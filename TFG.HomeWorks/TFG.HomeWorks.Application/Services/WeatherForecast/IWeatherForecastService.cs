using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;

namespace TFG.HomeWorks.Application.Services.WeatherForecast
{
    public interface IWeatherForecastService
    {
        Task Create(WeatherForecastCreateRequest request);
        Task<PageListResponse<WeatherForecastListItemResponse>> List(WeatherForecastListRequest request);
    }
}