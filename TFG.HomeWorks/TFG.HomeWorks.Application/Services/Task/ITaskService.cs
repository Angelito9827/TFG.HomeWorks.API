using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask;

namespace TFG.HomeWorks.Application.Services.Task
{
    public interface ITaskService
    {
        Task<TaskCreateResponse> Create(TaskCreateRequest request);
    }
}
