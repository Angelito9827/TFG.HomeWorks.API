using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;
using TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations.Base;

namespace TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations
{
    internal class HouseEntityTypeConfiguration : BaseEntityTypeConfiguration<House, int>
    {
        public override void Configure(EntityTypeBuilder<House> builder)
        {
            base.Configure(builder);

            builder.HasKey(h => h.Id);

            builder.Property(h => h.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(h => h.Description)
                .HasMaxLength(500);

            builder.Property(h => h.Address)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(h => h.ProfileImage)
                .HasMaxLength(200);

            builder.HasMany(h => h.Members)
                .WithOne(m => m.House)
                .HasForeignKey(m => m.HouseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data
            builder.HasData(GetPreconfiguredHouses());
        }
        private List<House> GetPreconfiguredHouses()
        {
            var houses = new List<House>();
            for (int i = 1; i <= 20; i++)
            {
                houses.Add(new House(
                    id: i * 100,
                    name: $"Mi Casa {i}",
                    description: $"Descripción de mi casa {i}",
                    address: $"Dirección de mi casa {i}",
                    profileImage: $"uploads/default.jpg",
                    isAdmin: false
                ));
            }
            return houses;
        }
    }

}
