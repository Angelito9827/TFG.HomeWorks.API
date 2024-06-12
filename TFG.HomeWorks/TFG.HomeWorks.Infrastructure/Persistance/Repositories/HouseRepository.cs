using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.GetHouseById;
using TFG.HomeWorks.Application.Services.House.DTOs.CRUD.HouseList;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;

namespace TFG.HomeWorks.Infrastructure.Persistance.Repositories
{
    internal class HouseRepository : IHouseRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public HouseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(House entity)
        {
            _dbContext.Add(entity);
        }

        public async Task<IEnumerable<House>> List(HouseListRequest request)
        {
            try
            {
                var query = _dbContext.Set<House>().AsQueryable();

                query = ApplyFilters(query, request);
                query = ApplySort(query, request.OrderBy, request.SortDirection);

                return await query
                    .Skip(request.PageSize * request.Page)
                    .Take(request.PageSize)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Enumerable.Empty<House>();

        }

        public async Task<int> Count(HouseListRequest request)
        {
            var query = _dbContext.Set<House>().AsQueryable();
            query = ApplyFilters(query, request);

            return await query.CountAsync();
        }

        private IQueryable<House> ApplySort(IQueryable<House> query, OrderByHouseListRequest orderBy, SortDirection sortDirection)
        {
            Expression<Func<House, object>> keySelector = ParseKeySelector(orderBy);

            return sortDirection switch
            {
                SortDirection.Default => query.OrderByDescending(keySelector),
                SortDirection.Asc => query.OrderBy(keySelector),
                SortDirection.Desc => query.OrderByDescending(keySelector),
                _ => throw new NotImplementedException()
            };


        }

        private Expression<Func<House, object>> ParseKeySelector(OrderByHouseListRequest orderBy)
        {
            return orderBy switch
            {
                OrderByHouseListRequest.Id => entity => entity.Id,
                OrderByHouseListRequest.Name => entity => entity.Name,
                OrderByHouseListRequest.Description => entity => entity.Description,
                OrderByHouseListRequest.Address => entity => entity.Address,
                OrderByHouseListRequest.Default => entity => entity.Id,

                _ => throw new NotImplementedException($"The selected field to order by is not valid")
            };
        }

        private IQueryable<House> ApplyFilters(IQueryable<House> query, HouseListRequest request)
        {
            if (request.Id is not null)
                query = query.Where(x => x.Id.Equals(request.Id));

            if (!request.Name.IsNullOrEmpty())
                query = query.Where(x => EF.Functions.Like(x.Name, $"%{request.Name}%"));

            if (!request.Description.IsNullOrEmpty())
                query = query.Where(x => EF.Functions.Like(x.Description, $"%{request.Description}%"));

            if (!request.Address.IsNullOrEmpty())
                query = query.Where(x => EF.Functions.Like(x.Address, $"%{request.Address}%"));

            return query;
        }

        public void Update(House entity) => _dbContext.Update(entity);

        public Task<House?> GetById(HouseGetByIdRequest request)
        {
            var query = _dbContext.Set<House>().AsQueryable();

            return query
                .Include(x => x.Members)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == request.Id);
        }


    }
}
