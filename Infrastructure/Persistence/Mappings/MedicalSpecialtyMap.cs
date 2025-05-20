using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mappings;

public class MedicalSpecialtyMap : IEntityTypeConfiguration<MedicalSpecialty>
{
    public void Configure(EntityTypeBuilder<MedicalSpecialty> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Id)
            .ValueGeneratedOnAdd();

        builder.Property(m => m.FullName)
            .IsRequired()
            .HasMaxLength(200);

        builder.HasOne(m => m.Specialty)
            .WithMany()
            .HasForeignKey(m => m.MedicalSpecialtyId)
            .IsRequired();

        builder.HasIndex(m => m.MedicalSpecialtyId);
    }
}