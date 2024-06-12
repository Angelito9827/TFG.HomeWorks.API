using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList;

namespace TFG.HomeWorks.Application.Services.Task
{
    public interface ITaskService
    {
        Task<TaskCreateResponse> Create(TaskCreateRequest request);
        Task<PageListResponse<TaskListItemResponse>> List(TaskListRequest request);
    }
}
