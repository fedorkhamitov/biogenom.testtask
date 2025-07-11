using Biogenom.Domain.Common;
using Biogenom.Domain.Entities.Nutrients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom.Infrastructure.Configurations;

public class NutrientConfiguration : IEntityTypeConfiguration<Nutrient>
{
    public void Configure(EntityTypeBuilder<Nutrient> builder)
    {
        builder.ToTable("nutrients");

        builder.HasKey(n => n.Id);
        
        builder.Property(n => n.Name)
            .IsRequired()
            .HasColumnType("varchar");

        builder.OwnsOne(n => n.Information, info =>
        {
            info.Property(i => i.BodyEffect)
                .HasColumnName("body_effect")
                .HasMaxLength(Constants.MaxHighTextLenght);
                
            info.Property(i => i.DietaryRecommendations)
                .HasColumnName("dietary_recommendations")
                .HasMaxLength(Constants.MaxHighTextLenght);
        });
    }
}