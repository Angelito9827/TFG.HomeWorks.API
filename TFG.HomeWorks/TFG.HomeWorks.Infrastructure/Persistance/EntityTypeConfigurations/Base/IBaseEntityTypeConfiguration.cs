using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TFG.HomeWorks.Domain.Entities.Base;

namespace TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations.Base
{
    internal class BaseEntityTypeConfiguration<TEntity, Tkey> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity<Tkey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
        }
    }
}
