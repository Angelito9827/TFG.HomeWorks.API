using Microsoft.AspNetCore.Mvc;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.House;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.CreateHouse;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.DeleteHouse;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.GetHouseById;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.HouseList;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.UpdateHouse;
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
        /// Obtiene una casa por el ID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public async Task<HouseGetByIdResponse> GetById([FromRoute] HouseGetByIdRequest request)
        {
            return await _houseService.GetById(request);
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

        /// <summary>
        /// Modifica los datos de una casa
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut(Name = "UpdateHouse")]
        public async Task<IActionResult> Update([FromForm] HouseUpdateRequestAPI request)
        {
            using var memoryStream = new MemoryStream();
            if (request.Image != null)
                await request.Image.CopyToAsync(memoryStream);

            var applicationRequest = new HouseUpdateRequest()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Address = request.Address,
                ProfileImage = memoryStream.Length > 0 ? memoryStream : null,
                FileName = request.Image?.FileName
            };

            var response = await _houseService.Update(applicationRequest);
            return CreatedAtAction(nameof(Create), new { response });
        }


        /// <summary>
        /// Borrar una casa por el ID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] HouseDeleteByIdRequest request)
        {
            await _houseService.Delete(request);
            return NoContent();
        }

    }
}
