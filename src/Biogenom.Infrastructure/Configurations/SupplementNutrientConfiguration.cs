using Biogenom.Domain.Entities.Supplements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom.Infrastructure.Configurations;

public class SupplementNutrientConfiguration : IEntityTypeConfiguration<SupplementNutrient>
{
    public void Configure(EntityTypeBuilder<SupplementNutrient> builder)
    {
        builder.ToTable("supplement_nutrients");

        builder.HasKey(sn => sn.Id);
        
        builder.Property(sn => sn.Amount)
            .IsRequired();
            
        builder.Property(sn => sn.Unit)
            .IsRequired();

        builder.HasOne(sn => sn.Supplement)
            .WithMany()
            .HasForeignKey("supplement_id")
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.HasOne(sn => sn.Nutrient)
            .WithMany()
            .HasForeignKey("nutrient_id")
            .OnDelete(DeleteBehavior.Cascade);
        
        
    }
}