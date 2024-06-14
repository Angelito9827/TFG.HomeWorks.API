using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.Task.DTOs.ChangeTaskState;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.DeleteTaskById;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskById;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList;

namespace TFG.HomeWorks.Application.Services.Task
{
    public interface ITaskService
    {
        System.Threading.Tasks.Task ChangeState(TaskChangeStateRequest request);
        Task<TaskCreateResponse> Create(TaskCreateRequest request);
        System.Threading.Tasks.Task Delete(TaskDeleteByIdRequest request);
        Task<TaskGetByIdResponse> GetById(TaskGetByIdRequest request);
        Task<PageListResponse<TaskListItemResponse>> List(TaskListRequest request);
    }
}
