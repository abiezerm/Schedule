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

            builder.Property(e => e.DateShedule).HasColumnName("dateShedule");
            builder.Property(e => e.atDate).HasColumnName("atDate");
            builder.Property(e => e.IsActive).HasDefaultValue(true);

            builder.HasOne(a => a.City).WithMany().HasForeignKey(a => a.idCity);
            builder.HasOne(a => a.StatusMigratory).WithMany().HasForeignKey(a => a.idStatusMigratory);
            builder.HasOne(a => a.TypeDocument).WithMany().HasForeignKey(a => a.idTypeDocument);
            builder.HasOne(a => a.Nationalitie).WithMany().HasForeignKey(a => a.idNationality);
            builder.HasOne(a => a.Service).WithMany().HasForeignKey(a => a.idServices);

    }

    }
}
