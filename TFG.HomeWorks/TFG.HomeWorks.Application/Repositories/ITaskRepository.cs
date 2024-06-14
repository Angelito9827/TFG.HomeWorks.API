

using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskById;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList;

namespace TFG.HomeWorks.Application.Repositories
{
    public interface ITaskRepository
    {
        void Add(Domain.Entities.TaskAggregate.Task entity);
        Task<int> Count(TaskListRequest request);
        void Delete(Domain.Entities.TaskAggregate.Task entity);
        Task<Domain.Entities.TaskAggregate.Task?> GetById(TaskGetByIdRequest request);
        Task<IEnumerable<Domain.Entities.TaskAggregate.Task>> List(TaskListRequest request);

        void Update(Domain.Entities.TaskAggregate.Task entity);
    }

}
