using Microsoft.AspNetCore.Mvc;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.Task;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList;

namespace TFG.HomeWorks.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        /// <summary>
        /// Obtiene un listado páginado, filtrado y ordenado de tareas
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PageListResponse<TaskListItemResponse>> List([FromQuery] TaskListRequest request)
        {
            return await _taskService.List(request);
        }

        /// <summary>
        /// Crea una nueva tarea
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TaskCreateRequest request)
        {
            var response = await _taskService.Create(request);
            return CreatedAtAction(nameof(Create), new { response });
        }
    }
}
