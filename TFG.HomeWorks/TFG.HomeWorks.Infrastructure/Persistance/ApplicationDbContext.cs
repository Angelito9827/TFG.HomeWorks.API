using Microsoft.EntityFrameworkCore;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;
using TFG.HomeWorks.Domain.Entities.UserAggregate;

namespace TFG.HomeWorks.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<House> Houses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HouseMember> HouseMembers { get; set; }

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
