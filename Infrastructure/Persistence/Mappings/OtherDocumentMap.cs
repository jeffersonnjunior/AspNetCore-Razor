using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mappings;

public class OtherDocumentMap : IEntityTypeConfiguration<OtherDocument>
{
    public void Configure(EntityTypeBuilder<OtherDocument> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(o => o.Patient)
            .WithMany()
            .HasForeignKey(o => o.PatientId)
            .IsRequired();

        builder.Property(o => o.DocumentType)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(o => o.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(o => o.IssueDate)
            .IsRequired()
            .HasColumnType("timestamp");

        builder.HasIndex(o => o.PatientId);
        builder.HasIndex(o => o.IssueDate);
    }
}