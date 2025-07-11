using Biogenom.Domain.Entities.Reports;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom.Infrastructure.Configurations;

public class AdvantageConfiguration : IEntityTypeConfiguration<Advantage>
{
    public void Configure(EntityTypeBuilder<Advantage> builder)
    {
        builder.ToTable("advantages");

        builder.HasKey(a => a.Id);

        builder.HasOne(a => a.Report)
            .WithMany()
            .HasForeignKey("report_id")
            .OnDelete(DeleteBehavior.Cascade);
    }
}