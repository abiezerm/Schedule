using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule.Domain.Entities;

namespace Schedule.Database.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("iduser");
            builder.Property(e => e.Name).HasColumnName("user").HasMaxLength(50);
            builder.Property(e => e.Email).HasColumnName("email").HasMaxLength(150);
            builder.Property(e => e.Password).HasColumnName("userKey").HasMaxLength(255);
            builder.Property(e => e.IsActive).HasDefaultValue(true);
        }
    }
}
