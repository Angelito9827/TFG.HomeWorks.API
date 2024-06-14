using Microsoft.AspNetCore.Mvc;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.Task;
using TFG.HomeWorks.Application.Services.Task.DTOs.ChangeTaskState;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.DeleteTaskById;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskById;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.UpdateTask;

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



        /// <summary>
        /// Obtiene una casa por el ID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public async Task<TaskGetByIdResponse> GetById([FromRoute] TaskGetByIdRequest request)
        {
            return await _taskService.GetById(request);
        }


        /// <summary>
        /// Borrar una casa por el ID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] TaskDeleteByIdRequest request)
        {
            await _taskService.Delete(request);
            return NoContent();
        }


        /// <summary>
        /// Cambia el estado de una tarea 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPatch]
        public async Task<IActionResult> ChangeState(TaskChangeStateRequest request)
        {
            await _taskService.ChangeState(request);
            return NoContent();
        }

        /// <summary>
        /// Actualiza los datos de una tarea
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(TaskUpdateRequest request)
        {
            await _taskService.Update(request);
            return NoContent();
        }

    }
}
