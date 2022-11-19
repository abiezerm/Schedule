using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule.Domain.Entities;

namespace Schedule.Database.Configuration
{
    public class SatusMigratoryConfig : IEntityTypeConfiguration<StatusMigratory>
    {
        public void Configure(EntityTypeBuilder<StatusMigratory> builder)
        {
            builder.ToTable("status_migratory");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("idStatusMigratory");
            builder.Property(e => e.Name).HasColumnName("statusMigratory").HasMaxLength(50);
            builder.Property(e => e.IsActive).HasDefaultValue(true);
        }
    }
}
