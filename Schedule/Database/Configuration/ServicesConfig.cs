using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule.Domain.Entities;

namespace Schedule.Database.Configuration
{
    public class ServicesConfig : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.ToTable("services");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("idservices");
            builder.Property(e => e.Name).HasColumnName("services").HasMaxLength(50);
            builder.Property(e => e.IsActive).HasDefaultValue(true);
        }

    }
}
