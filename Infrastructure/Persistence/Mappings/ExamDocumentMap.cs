using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mappings;

public class ExamDocumentMap : IEntityTypeConfiguration<ExamDocument>
{
    public void Configure(EntityTypeBuilder<ExamDocument> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(e => e.Patient)
            .WithMany()
            .HasForeignKey(e => e.PatientId)
            .IsRequired();

        builder.Property(e => e.ExamName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.ExamType)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.ExamDate)
            .IsRequired()
            .HasColumnType("timestamp");

        builder.Property(e => e.FilePath)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasIndex(e => e.PatientId);
        builder.HasIndex(e => e.ExamDate);
    }
}