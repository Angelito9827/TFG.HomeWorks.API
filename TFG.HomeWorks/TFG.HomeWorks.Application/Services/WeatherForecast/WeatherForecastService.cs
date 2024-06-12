using AutoMapper;
using Microsoft.Extensions.Logging;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastGetById;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastUpdate;
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

        public async Task<WeatherForecastCreateResponse> Create(WeatherForecastCreateRequest request)
        {
            _validator.EnsureIsValid(request);

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
            return new WeatherForecastCreateResponse(entity.Id);
        }

        public async Task<PageListResponse<WeatherForecastListItemResponse>> List(WeatherForecastListRequest request)
        {
            _validator.EnsureIsValid(request);

            var entities = await _weatherForecastRepository.List(request);

            return new PageListResponse<WeatherForecastListItemResponse>
            {
                Elements = entities.Select(_mapper.Map<WeatherForecastListItemResponse>),
                Page = request.Page,
                PageSize = request.PageSize,
                TotalCount = await _weatherForecastRepository.Count(request)
            };
        }

        public async System.Threading.Tasks.Task Update(WeatherForecastUpdateRequest request)
        {
            _validator.EnsureIsValid(request);

            var entity = await _weatherForecastRepository.GetById(new WeatherForecastGetByIdRequest(request.Id));

            if (entity is null)
                throw new KeyNotFoundException(nameof(Domain.Entities.WeatherForecast));

            entity.Date = request.Date;
            entity.Time = request.Time;
            entity.TemperatureC = request.TemperatureC;
            entity.Summary = request.Summary;
            entity.Type = request.Type;

            _weatherForecastRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task<WeatherForecastGetByIdResponse> GetById(WeatherForecastGetByIdRequest request)
        {
            _validator.EnsureIsValid(request);
            var entity = await _weatherForecastRepository.GetById(request);

            if (entity is null)
                throw new KeyNotFoundException(nameof(Domain.Entities.WeatherForecast));

            return _mapper.Map<WeatherForecastGetByIdResponse>(entity);
        }
    }
}
