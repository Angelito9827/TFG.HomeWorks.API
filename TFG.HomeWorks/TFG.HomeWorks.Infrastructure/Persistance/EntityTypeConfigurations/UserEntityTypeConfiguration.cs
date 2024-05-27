using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TFG.HomeWorks.Domain.Entities.UserAggregate;
using TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations.Base;

namespace TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations
{
    internal class UserEntityTypeConfiguration : BaseEntityTypeConfiguration<User, int>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.LastName1)
                .HasMaxLength(100);

            builder.Property(u => u.LastName2)
                .HasMaxLength(100);

            builder.Property(u => u.BirthDate)
                .IsRequired();

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.Property(u => u.Gender)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(u => u.ProfileImage)
                .HasMaxLength(200);

            // Relationship with Role
            builder.HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict); // or Cascade depending on your requirements

            builder.HasMany(u => u.HouseMembers)
                 .WithOne(hm => hm.User)
                 .HasForeignKey(hm => hm.UserId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
