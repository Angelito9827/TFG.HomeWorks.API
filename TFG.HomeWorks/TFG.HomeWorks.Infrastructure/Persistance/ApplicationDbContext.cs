using Microsoft.EntityFrameworkCore;
using TFG.HomeWorks.Application.Repositories;

namespace TFG.HomeWorks.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura el mapeo de base de datos para todas las entidades que tengan definida una imlplementacion de IEntityTypeConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<Enum>()
                .HaveConversion<string>()
                .HaveMaxLength(50);
        }
    }
}
