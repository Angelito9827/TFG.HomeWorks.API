using TFG.HomeWorks.Application.Repositories;

namespace TFG.HomeWorks.Infrastructure.Persistance.Repositories
{
    internal class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TaskRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Domain.Entities.TaskAggregate.Task entity)
        {
            _dbContext.Add(entity);
        }

    }
}
