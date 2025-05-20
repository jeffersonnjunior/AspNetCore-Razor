using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mappings;

public class VaccineDocumentMap : IEntityTypeConfiguration<VaccineDocument>
{
    public void Configure(EntityTypeBuilder<VaccineDocument> builder)
    {
        builder.HasKey(v => v.Id);

        builder.Property(v => v.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(v => v.Patient)
            .WithMany()
            .HasForeignKey(v => v.PatientId)
            .IsRequired();

        builder.Property(v => v.VaccineName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(v => v.Manufacturer)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(v => v.AdministrationDate)
            .IsRequired()
            .HasColumnType("datetime2");

        builder.Property(v => v.LotNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(v => v.PatientId);
        builder.HasIndex(v => v.AdministrationDate);
    }
}