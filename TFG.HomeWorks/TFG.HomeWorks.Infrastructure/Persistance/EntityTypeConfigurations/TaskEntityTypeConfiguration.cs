using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TFG.HomeWorks.Domain.Entities.TaskAggregate;
using TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations.Base;

namespace TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations
{
    internal class TaskEntityTypeConfiguration : BaseEntityTypeConfiguration<Domain.Entities.TaskAggregate.Task, int>
    {
        public override void Configure(EntityTypeBuilder<Domain.Entities.TaskAggregate.Task> builder)
        {
            base.Configure(builder);

            builder.ToTable("Tasks");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(t => t.Description)
                .HasMaxLength(1000);

            builder.Property(t => t.State)
                .IsRequired();

            builder.Property(t => t.CreationDate)
                .IsRequired();

            builder.Property(t => t.DeadlineDate)
                .IsRequired();

            builder.Property(t => t.AssignedTo)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(t => t.AssignedBy)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(t => t.Category)
                .WithMany()
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.House)
                .WithMany()
                .HasForeignKey(t => t.HouseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed data
            builder.HasData(GetPreconfiguredHouses());
        }
        private List<Domain.Entities.TaskAggregate.Task> GetPreconfiguredHouses()
        {
            var random = new Random();
            var tasks = new List<Domain.Entities.TaskAggregate.Task>();
            for (int i = 1; i <= 20; i++)
            {
                tasks.Add(new Domain.Entities.TaskAggregate.Task()
                {
                    Id = i,
                    Name = $"Tarea {i}",
                    Description = $"Descripción de la Tarea {i}",
                    State = TaskState.NEW,
                    CreationDate = DateTime.Now,
                    DeadlineDate = DateTime.Now.AddDays(90),
                    AssignedTo = $"Usuario{i}",
                    AssignedBy = "Ángel",
                    CategoryId = random.Next(1, 8),
                    HouseId = i
                });
            }
            return tasks;
        }
    }
}

