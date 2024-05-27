using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TFG.HomeWorks.Domain.Entities.UserAggregate;
using TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations.Base;

namespace TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations
{
    internal class RoleEntityTypeConfiguration : BaseEntityTypeConfiguration<Role, int>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100); // Example: Set the maximum length of the role name

            builder.HasData(
               Role.Create(Roles.User),
               Role.Create(Roles.Admin)
           );

            // Optionally, you can configure relationships here if needed.
            // For example, if a role has specific permissions associated with it.

            // If there are no additional configurations needed for Role entity,
            // you can keep this class empty, and BaseEntityTypeConfiguration will handle the base configuration.
        }
    }
}
