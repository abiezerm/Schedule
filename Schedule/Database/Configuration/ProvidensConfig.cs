using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule.Domain.Entities;

namespace Schedule.Database.Configuration
{
    public class ProvidensConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("province");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("idProvince");
            builder.Property(e => e.Name).HasColumnName("provinces").HasMaxLength(50);
            builder.Property(e => e.IsActive).HasDefaultValue(true);
        }

    }
}
