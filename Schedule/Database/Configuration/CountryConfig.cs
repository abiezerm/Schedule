using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule.Domain.Entities;

namespace Schedule.Database.Configuration;

public class CountryConfig : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Countries");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).HasColumnName("idCountry");
        builder.Property(e => e.Name).HasColumnName("nameCountry").HasMaxLength(50);
        builder.Property(e => e.IsActive).HasDefaultValue(true);

        builder.HasMany(x => x.Cities)
            .WithOne(c => c.Country)
            .HasForeignKey(c => c.CountryId);
    }
}