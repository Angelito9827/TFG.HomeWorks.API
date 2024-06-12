using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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

        }
    }
}
