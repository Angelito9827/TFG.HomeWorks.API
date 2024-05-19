using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TFG.HomeWorks.Domain.Entities;
using TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations.Base;

namespace TFG.HomeWorks.Infrastructure.Persistance.EntityTypeConfigurations
{
    internal class WeatherForecastEntityTypeConfiguration : BaseEntityTypeConfiguration<WeatherForecast, Guid>
    {
        public override void Configure(EntityTypeBuilder<WeatherForecast> builder)
        {
            base.Configure(builder);

            builder.ToTable("WeatherForecast", "dbo");
            builder.Property(x => x.CreateDate).HasColumnName("CreateDate");
            builder.Property(x => x.Summary).HasColumnName("Summary").HasMaxLength(250);
            builder.Property(x => x.TemperatureC).HasColumnName("TemperatureC");
            builder.Ignore(x => x.TemperatureF);
        }
    }
}
