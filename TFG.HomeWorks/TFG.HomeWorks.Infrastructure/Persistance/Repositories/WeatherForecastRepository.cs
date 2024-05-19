using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;
using TFG.HomeWorks.Domain.Entities;

namespace TFG.HomeWorks.Infrastructure.Persistance.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public WeatherForecastRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(WeatherForecast entity)
        {
            _dbContext.Add(entity);
        }

        public async Task<IEnumerable<WeatherForecast>> List(WeatherForecastListRequest request)
        {
            var query = _dbContext.Set<WeatherForecast>().AsQueryable();

            query = ApplyFilters(query, request);
            query = ApplySort(query, request.OrderBy, request.SortDirection);

            return await query
                .Skip(request.PageSize * request.Page)
                .Take(request.Page)
                .ToListAsync();
        }

        public async Task<int> Count(WeatherForecastListRequest request)
        {
            var query = _dbContext.Set<WeatherForecast>().AsQueryable();
            query = ApplyFilters(query, request);

            return await query.CountAsync();
        }

        private IQueryable<WeatherForecast> ApplySort(IQueryable<WeatherForecast> query, WeatherForecastListRequestOrderBy orderBy, SortDirection sortDirection)
        {
            Expression<Func<WeatherForecast, object>> keySelector = ParseKeySelector(orderBy);

            return sortDirection.Equals(SortDirection.Asc)
                ? query.OrderBy(keySelector)
                : query.OrderByDescending(keySelector);

        }

        private Expression<Func<WeatherForecast, object>> ParseKeySelector(WeatherForecastListRequestOrderBy orderBy)
        {
            return orderBy switch
            {
                WeatherForecastListRequestOrderBy.None => entity => entity.CreateDate,
                WeatherForecastListRequestOrderBy.CreateDate => entity => entity.CreateDate,
                WeatherForecastListRequestOrderBy.Date => entity => entity.Date,
                WeatherForecastListRequestOrderBy.Time => entity => entity.Time,
                WeatherForecastListRequestOrderBy.TemperatureC => entity => entity.TemperatureC,
                WeatherForecastListRequestOrderBy.TemperatureF => entity => entity.TemperatureF,
                WeatherForecastListRequestOrderBy.Summary => entity => entity.Summary,
                WeatherForecastListRequestOrderBy.Type => entity => entity.Type,
                _ => throw new NotImplementedException($"The selected field to order by is not valid")
            };
        }

        private IQueryable<WeatherForecast> ApplyFilters(IQueryable<WeatherForecast> query, WeatherForecastListRequest request)
        {
            if (request.CreateDate is not null)
                query = query.Where(x => x.CreateDate.Equals(request.CreateDate));

            if (request.Date is not null)
                query = query.Where(x => x.Date.Equals(request.Date));

            if (request.Time is not null)
                query = query.Where(x => x.Time.Equals(request.Time));

            if (request.TemperatureC is not null)
                query = query.Where(x => x.TemperatureC.Equals(request.TemperatureC));

            if (request.TemperatureF is not null)
                query = query.Where(x => x.TemperatureF.Equals(request.TemperatureF));

            if (!string.IsNullOrEmpty(request.Summary))
                query = query.Where(x => x.Summary.ToLower().Contains(request.Summary.ToLower()));

            if (request.Type is not null)
                query = query.Where(x => x.Type.Equals(request.Type));

            return query;
        }
    }
}
