using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace TFG.HomeWorks.Infrastructure.Persistance
{
    public enum DbConnectionEnum { APP }

    public class DbConnectionFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DbConnectionFactory(IServiceProvider serviceProvider)
            => _serviceProvider = serviceProvider;

        public IDbConnection GetDefaultDbConnection() => GetDbConnection(DbConnectionEnum.APP);

        public IDbConnection GetDbConnection(DbConnectionEnum dbConnectionEnum)
            => dbConnectionEnum switch
            {
                DbConnectionEnum.APP => _serviceProvider.GetRequiredService<ApplicationDbContext>().Database.GetDbConnection(),
                _ => throw new NotImplementedException(),
            };
    }
}