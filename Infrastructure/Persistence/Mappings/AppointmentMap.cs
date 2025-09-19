using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mappings;

public class AppointmentMap : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.UserId).IsRequired().HasMaxLength(100);
        builder.Property(a => a.ScheduledDate).IsRequired();
        builder.Property(a => a.DoctorName).IsRequired().HasMaxLength(100);
        builder.Property(a => a.Description).HasMaxLength(500);
    }
}