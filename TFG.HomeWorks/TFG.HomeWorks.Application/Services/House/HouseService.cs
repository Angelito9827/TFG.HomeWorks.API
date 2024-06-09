
using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.ExternalServices.Files;
using TFG.HomeWorks.Application.ExternalServices.Files.SaveImage;
using TFG.HomeWorks.Application.Options;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.House.DTOs.CreateHouse;
using TFG.HomeWorks.Application.Services.House.DTOs.GetHouseById;
using TFG.HomeWorks.Application.Services.House.DTOs.HouseList;
using TFG.HomeWorks.Application.Validations;

namespace TFG.HomeWorks.Application.Services.House
{
    internal class HouseService : IHouseService
    {
        private readonly ILogger<HouseService> _logger;
        private readonly IMapper _mapper;
        private readonly IObjectValidator _validator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHouseRepository _houseRepository;
        private readonly IFileStorageService _fileStorageService;
        private readonly ApiUrls _apisUrlsSettings;

        public HouseService(
            ILogger<HouseService> logger,
            IMapper mapper,
            IObjectValidator validator,
            IUnitOfWork unitOfWork,
            IHouseRepository houseRepository,
            IFileStorageService fileStorageService,
            IOptions<ApiUrls> apisUrlsSettings
            )
        {
            _logger = logger;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
            _houseRepository = houseRepository;
            _fileStorageService = fileStorageService;
            _apisUrlsSettings = apisUrlsSettings.Value;
        }

        public async Task<PageListResponse<HouseListItemResponse>> List(HouseListRequest request)
        {
            _validator.EnsureIsValid(request);

            var entities = await _houseRepository.List(request);

            var responses = entities.Select(entity =>
            {
                var response = _mapper.Map<HouseListItemResponse>(entity);
                response.ProfileImage = $"{_apisUrlsSettings.BaseUrl}/{entity.ProfileImage.Replace("\\", "/")}";
                return response;
            }).ToList();

            return new PageListResponse<HouseListItemResponse>
            {
                Elements = responses,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalCount = await _houseRepository.Count(request)
            };
        }
        public async Task<HouseGetByIdResponse> GetById(HouseGetByIdRequest request)
        {
            _validator.EnsureIsValid(request);
            var entity = await _houseRepository.GetById(request);

            if (entity is null)
                throw new KeyNotFoundException(nameof(Domain.Entities.HouseAggregate.House));

            return _mapper.Map<HouseGetByIdResponse>(entity);
        }


        public async Task<HouseCreateResponse> Create(HouseCreateRequest request)
        {
            _validator.EnsureIsValid(request);

            var saveImageRequest = new SaveImageRequest
            {
                FileName = request.FileName,
                File = request.ProfileImage
            };

            string profileImagePath = await _fileStorageService.SaveImageAsync(saveImageRequest);

            var entity = new Domain.Entities.HouseAggregate.House(
                request.Name,
                request.Description,
                request.Address,
                profileImagePath
            );

            _houseRepository.Add(entity);

            await _unitOfWork.SaveChangesAsync();
            return new HouseCreateResponse(entity.Id);
        }


        //public async Task Update(HouseUpdateRequest request)
        //{
        //    _validator.EnsureIsValid(request);


        //    var entity = await _houseRepository.GetById(new HouseGetByIdRequest(request.Id));

        //    if (entity is null)
        //        throw new KeyNotFoundException(nameof(Domain.Entities.HouseAggregate.House));

        //    entity.Name = request.Name;
        //    entity.Description = request.Description;
        //    entity.Address = request.Address;
        //    entity.ProfileImage =


        //    _houseRepository.Update(entity);
        //    await _unitOfWork.SaveChangesAsync();
        //}

    }
}
