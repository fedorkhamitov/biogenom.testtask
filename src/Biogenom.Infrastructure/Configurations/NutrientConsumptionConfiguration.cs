using Biogenom.Domain.Entities.Nutrients;
using Biogenom.Domain.Entities.Reports;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom.Infrastructure.Configurations;

public class NutrientConsumptionConfiguration : IEntityTypeConfiguration<NutrientConsumption>
{
    public void Configure(EntityTypeBuilder<NutrientConsumption> builder)
    {
        builder.ToTable("nutrient_consumptions");

        builder.HasKey(nc => nc.Id);
            
        builder.Property(nc => nc.CurrentValue)
            .HasColumnName("current_value")
            .IsRequired();
            
        builder.Property(nc => nc.NormalValue)
            .HasColumnName("norm_value")
            .IsRequired();
            
        builder.Property(nc => nc.Unit)
            .HasConversion<string>()
            .IsRequired();
            
        builder.Property(nc => nc.Status)
            .HasConversion<string>()
            .IsRequired();

        builder.HasOne(nc => nc.Report)
            .WithMany()
            .HasForeignKey("report_id")
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.HasOne(nc => nc.Nutrient)
            .WithMany()
            .HasForeignKey("nutrient_id")
            .OnDelete(DeleteBehavior.Cascade);
    }
}