
namespace TFG.HomeWorks.Application.Repositories
{
    public interface ITaskRepository
    {
        void Add(Domain.Entities.TaskAggregate.Task entity);
    }
}
