using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskById;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList;

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
        public async Task<IEnumerable<Domain.Entities.TaskAggregate.Task>> List(TaskListRequest request)
        {
            var query = _dbContext.Set<Domain.Entities.TaskAggregate.Task>().AsQueryable();

            query = ApplyFilters(query, request);
            query = ApplySort(query, request.OrderBy, request.SortDirection);

            return await query
                .Include(x => x.House)
                .Include(x => x.Category)
                .Skip(request.PageSize * request.Page)
                .Take(request.PageSize)
                .ToListAsync();

        }
        public async Task<int> Count(TaskListRequest request)
        {
            var query = _dbContext.Set<Domain.Entities.TaskAggregate.Task>().AsQueryable();
            query = ApplyFilters(query, request);

            return await query.CountAsync();
        }

        private IQueryable<Domain.Entities.TaskAggregate.Task> ApplySort(IQueryable<Domain.Entities.TaskAggregate.Task> query, TaskListRequestOrderBy orderBy, SortDirection sortDirection)
        {

            Expression<Func<Domain.Entities.TaskAggregate.Task, object>> keySelector = ParseKeySelector(orderBy);

            return sortDirection switch
            {
                SortDirection.Default => query.OrderByDescending(keySelector),
                SortDirection.Asc => query.OrderBy(keySelector),
                SortDirection.Desc => query.OrderByDescending(keySelector),
                _ => throw new NotImplementedException()
            };


        }
        private Expression<Func<Domain.Entities.TaskAggregate.Task, object>> ParseKeySelector(TaskListRequestOrderBy orderBy)
        {
            return orderBy switch
            {
                TaskListRequestOrderBy.Id => entity => entity.Id,
                TaskListRequestOrderBy.Name => entity => entity.Name,
                TaskListRequestOrderBy.Description => entity => entity.Description,
                TaskListRequestOrderBy.State => entity => entity.State,
                TaskListRequestOrderBy.CreationDate => entity => entity.CreationDate,
                TaskListRequestOrderBy.DeadlineDate => entity => entity.DeadlineDate,
                TaskListRequestOrderBy.AssignedTo => entity => entity.AssignedTo,
                TaskListRequestOrderBy.AssignedBy => entity => entity.AssignedBy,
                TaskListRequestOrderBy.CategoryId => entity => entity.CategoryId,
                TaskListRequestOrderBy.HouseId => entity => entity.HouseId,
                _ => throw new NotImplementedException($"The selected field to order by is not valid")
            };
        }
        private IQueryable<Domain.Entities.TaskAggregate.Task> ApplyFilters(IQueryable<Domain.Entities.TaskAggregate.Task> query, TaskListRequest request)
        {
            if (request.Id is not null)
                query = query.Where(x => x.Id.Equals(request.Id));

            if (!request.Name.IsNullOrEmpty())
                query = query.Where(x => EF.Functions.Like(x.Name, $"%{request.Name}%"));

            if (!request.Description.IsNullOrEmpty())
                query = query.Where(x => EF.Functions.Like(x.Description, $"%{request.Description}%"));

            if (request.State is not null)
                query = query.Where(x => x.State.Equals(request.State));

            if (request.CreationDate is not null)
                query = query.Where(x => x.CreationDate.Equals(request.CreationDate));

            if (request.DeadlineDate is not null)
                query = query.Where(x => x.DeadlineDate.Equals(request.DeadlineDate));

            if (!request.AssignedBy.IsNullOrEmpty())
                query = query.Where(x => EF.Functions.Like(x.AssignedBy, $"%{request.AssignedBy}%"));

            if (!request.AssignedTo.IsNullOrEmpty())
                query = query.Where(x => EF.Functions.Like(x.AssignedTo, $"%{request.AssignedTo}%"));

            if (request.CategoryId is not null)
                query = query.Where(x => x.CategoryId.Equals(request.CategoryId));

            if (request.HouseId is not null)
                query = query.Where(x => x.HouseId.Equals(request.HouseId));

            return query;
        }

        public Task<Domain.Entities.TaskAggregate.Task?> GetById(TaskGetByIdRequest request)
        {
            var query = _dbContext.Set<Domain.Entities.TaskAggregate.Task>().AsQueryable();

            return query
                .FirstOrDefaultAsync(x => x.Id == request.Id);
        }

        public void Delete(Domain.Entities.TaskAggregate.Task entity)
        {
            _dbContext.Remove(entity);
        }

        public void Update(Domain.Entities.TaskAggregate.Task entity)
        {
            _dbContext.Update(entity);
        }
    }
}
