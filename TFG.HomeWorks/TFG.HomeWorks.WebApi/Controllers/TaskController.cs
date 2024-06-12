using Microsoft.AspNetCore.Mvc;
using TFG.HomeWorks.Application.Services.Task;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask;

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
