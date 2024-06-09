using Microsoft.AspNetCore.Mvc;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.House;
using TFG.HomeWorks.Application.Services.House.DTOs.CreateHouse;
using TFG.HomeWorks.Application.Services.House.DTOs.HouseList;
using TFG.HomeWorks.WebApi.DTOs.House;

namespace TFG.HomeWorks.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;

        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        /// <summary>
        /// Obtiene un listado páginado, filtrado y ordenado de casas
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetHouses")]
        public async Task<PageListResponse<HouseListItemResponse>> List([FromQuery] HouseListRequest request)
        {
            return await _houseService.List(request);
        }

        /// <summary>
        /// Crea una casa
        /// </summary>
        /// <param name="request"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        [HttpPost(Name = "CreateHouse")]
        public async Task<IActionResult> Create([FromForm] HouseCreateRequestAPI request)
        {
            using var memoryStream = new MemoryStream();
            if (request.Image != null)
                await request.Image.CopyToAsync(memoryStream);

            var applicationRequest = new HouseCreateRequest(
                request.Name,
                request.Description,
                request.Address,
                memoryStream.Length > 0 ? memoryStream : null,
                request.Image?.FileName
            );

            var response = await _houseService.Create(applicationRequest);
            return CreatedAtAction(nameof(Create), new { response });
        }
    }
}
