

using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList;

namespace TFG.HomeWorks.Application.Repositories
{
    public interface ITaskRepository
    {
        void Add(Domain.Entities.TaskAggregate.Task entity);
        Task<int> Count(TaskListRequest request);
        Task<IEnumerable<Domain.Entities.TaskAggregate.Task>> List(TaskListRequest request);
    }
}
