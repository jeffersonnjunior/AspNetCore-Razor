using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mappings;

public class ExamResultMap : IEntityTypeConfiguration<ExamResult>
{
    public void Configure(EntityTypeBuilder<ExamResult> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.UserId).IsRequired().HasMaxLength(100);
        builder.Property(e => e.ExamType).IsRequired().HasMaxLength(100);
        builder.Property(e => e.ExamDate).IsRequired();
        builder.Property(e => e.Result).HasMaxLength(1000);
    }
}