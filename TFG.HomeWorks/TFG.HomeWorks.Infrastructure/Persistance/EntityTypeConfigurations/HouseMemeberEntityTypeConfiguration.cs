using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;
using TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations.Base;

namespace TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations
{
    internal class HouseMemeberEntityTypeConfiguration : BaseEntityTypeConfiguration<HouseMember, int>
    {
        public override void Configure(EntityTypeBuilder<HouseMember> builder)
        {
            builder.HasKey(hm => hm.Id);

            builder.HasIndex(hm => new { hm.HouseId, hm.UserId }).IsUnique();

            builder.HasOne(hm => hm.House)
                .WithMany(h => h.Members)
                .HasForeignKey(hm => hm.HouseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(hm => hm.User)
                .WithMany(u => u.HouseMembers)
                .HasForeignKey(hm => hm.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
