using Biogenom.Domain.Entities.Reports;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom.Infrastructure.Configurations;

public class NewConsumptionConfiguration : IEntityTypeConfiguration<NewConsumption>
{
    public void Configure(EntityTypeBuilder<NewConsumption> builder)
    {
        builder.ToTable("new_consumptions");

        builder.HasKey(nc => nc.Id);

        builder.HasOne<Report>(nc => nc.Report)
            .WithMany()
            .HasForeignKey("report_id")
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.HasOne(nc => nc.Nutrient)
            .WithMany()
            .HasForeignKey("nutrient_id")
            .OnDelete(DeleteBehavior.Cascade);
    }
}