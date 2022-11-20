using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule.Domain.Entities;

namespace Schedule.Database.Configuration
{
    public class TypeDocumentConfig : IEntityTypeConfiguration<TypeDocument>
    {
        public void Configure(EntityTypeBuilder<TypeDocument> builder)
        {
            builder.ToTable("type_document");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("idTypeDocument");
            builder.Property(e => e.Name).HasColumnName("TypeDocument").HasMaxLength(50);
            builder.Property(e => e.IsActive).HasDefaultValue(true);
        }
    }
}
