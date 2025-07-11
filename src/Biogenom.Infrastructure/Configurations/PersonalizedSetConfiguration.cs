using Biogenom.Domain.Common;
using Biogenom.Domain.Entities.Supplements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom.Infrastructure.Configurations;

public class PersonalizedSetConfiguration : IEntityTypeConfiguration<PersonalizedSet>
{
    public void Configure(EntityTypeBuilder<PersonalizedSet> builder)
    {
        builder.ToTable("personalized_sets");

        builder.HasKey(ps => ps.Id); 
        
        builder.Property(ps => ps.Description)
            .HasMaxLength(Constants.MaxHighTextLenght);
            
        builder.Property(ps => ps.ProductName)
            .HasColumnName("product_name")
            .HasMaxLength(Constants.MaxLowTextLenght);
            
        builder.Property(ps => ps.ProductDetails)
            .HasColumnName("product_details")
            .HasMaxLength(Constants.MaxHighTextLenght);

        builder.HasOne(ps => ps.Report)
            .WithOne(r => r.PersonalizedSet)
            .HasForeignKey("report_id")
            .OnDelete(DeleteBehavior.Cascade);
    }
}