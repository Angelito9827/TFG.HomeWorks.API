using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TFG.HomeWorks.Domain.Entities.TaskAggregate;
using TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations.Base;

namespace TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations
{
    internal class CategoryEntityTypeConfiguration : BaseEntityTypeConfiguration<Category, int>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.ToTable("Categories");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .HasMaxLength(1000);

            builder.Property(c => c.Icon)
                .HasMaxLength(300);


            builder.HasData(
          new Category
          {
              Id = 1,
              Name = "Bathroom",
              Description = "Bathroom tasks description",
              Icon = "https://localhost:7126/icons/categories/bathroom.svg"
          },
          new Category
          {
              Id = 2,
              Name = "Bedroom",
              Description = "Bedroom tasks description",
              Icon = "https://localhost:7126/icons/categories/bedroom.svg"
          },
          new Category
          {
              Id = 3,
              Name = "Dinning room",
              Description = "Dinning-room tasks description",
              Icon = "https://localhost:7126/icons/categories/dinning-room.svg"
          },
          new Category
          {
              Id = 4,
              Name = "Garage",
              Description = "Garage tasks description",
              Icon = "https://localhost:7126/icons/categories/garage.svg"
          },
          new Category
          {
              Id = 5,
              Name = "Garden",
              Description = "Garden tasks description",
              Icon = "https://localhost:7126/icons/categories/garden.svg"
          },
          new Category
          {
              Id = 6,
              Name = "Kitchen",
              Description = "Kitchen tasks description",
              Icon = "https://localhost:7126/icons/categories/kitchen.svg"
          },
          new Category
          {
              Id = 7,
              Name = "Living room",
              Description = "Living room tasks description",
              Icon = "https://localhost:7126/icons/categories/living-room.svg"
          },
          new Category
          {
              Id = 8,
              Name = "Office",
              Description = "office tasks description",
              Icon = "https://localhost:7126/icons/categories/office-room.svg"
          }
      );

        }
    }
}
