using AutoMapper;
using Microsoft.Extensions.Logging;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Exceptions;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;
using TFG.HomeWorks.Application.Validations;

namespace TFG.HomeWorks.Application.Services.WeatherForecast
{
    internal class WeatherForecastService : IWeatherForecastService
    {
        private readonly ILogger<WeatherForecastService> _logger;
        private readonly IMapper _mapper;
        private readonly IObjectValidator _validator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(
            ILogger<WeatherForecastService> logger,
            IMapper mapper,
            IObjectValidator validator,
            IUnitOfWork unitOfWork,
            IWeatherForecastRepository weatherForecastRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
            _weatherForecastRepository = weatherForecastRepository;
        }

        public async Task Create(WeatherForecastCreateRequest request)
        {
            _validator.EnsureIsValid(request);

            if (!CheckAnyBusinessRule())
                throw CustomApplicationException.Create(CustomApplicationExceptionCode.Test_AnyBusinessRuleViolation);

            var entity = new Domain.Entities.WeatherForecast()
            {
                Summary = request.Summary,
                Type = request.Type,
                TemperatureC = request.TemperatureC,
                Date = request.Date,
                Time = request.Time,
                CreateDate = DateTime.UtcNow
            };

            _weatherForecastRepository.Add(entity);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<PageListResponse<WeatherForecastListItemResponse>> List(WeatherForecastListRequest request)
        {
            _validator.EnsureIsValid(request);

            if (!CheckAnyBusinessRule())
                throw CustomApplicationException.Create(CustomApplicationExceptionCode.Test_AnyBusinessRuleViolation);

            var entities = await _weatherForecastRepository.List(request);

            return new PageListResponse<WeatherForecastListItemResponse>
            {
                Elements = entities.Select(_mapper.Map<WeatherForecastListItemResponse>),
                Page = request.Page,
                PageSize = request.PageSize,
                TotalCount = await _weatherForecastRepository.Count(request)
            };
        }

        private static bool CheckAnyBusinessRule()
        {
            return DateTime.UtcNow.Minute % 2 == 0;
        }

    }
}
