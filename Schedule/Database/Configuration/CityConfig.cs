using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule.Domain.Entities;

namespace Schedule.Database.Configuration;

public class CityConfig : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("city");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).HasColumnName("idCity");
        builder.Property(e => e.Name).HasColumnName("City").HasMaxLength(50);
        builder.Property(e => e.IsActive).HasDefaultValue(true);
    }
}