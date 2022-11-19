using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Schedule.Domain.Entities;

namespace Schedule.Database.Configuration
{
    public class AppointmentConfig : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("appointment");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("idAppointment");
            builder.Property(e => e.Nis).HasColumnName("nis").HasMaxLength(10);
            builder.Property(e => e.Document).HasColumnName("documentId").HasMaxLength(15);
            builder.Property(e => e.FirstName).HasColumnName("firstName").HasMaxLength(50);
            builder.Property(e => e.LastName).HasColumnName("lastName").HasMaxLength(50);
            builder.Property(e => e.Email).HasColumnName("email").HasMaxLength(150);
            builder.Property(e => e.PhoneNumber).HasColumnName("phoneNumber").HasMaxLength(10);
            builder.Property(e => e.DateShedule).HasColumnName("dateShedule");  // Warning Data Type DATE
            builder.Property(e => e.atDate).HasColumnName("atDate");            // Warning Data Type DATE
            builder.Property(e => e.IsActive).HasDefaultValue(true);




        }

    }
}
