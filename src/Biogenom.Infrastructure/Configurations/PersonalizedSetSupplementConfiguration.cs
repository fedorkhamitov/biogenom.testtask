using Biogenom.Domain.Entities.Supplements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom.Infrastructure.Configurations;

public class PersonalizedSetSupplementConfiguration : IEntityTypeConfiguration<PersonalizedSetSupplement>
{
    public void Configure(EntityTypeBuilder<PersonalizedSetSupplement> builder)
    {
        builder.ToTable("personalized_set_supplements");

        builder.HasKey(pss => pss.Id);
        
        builder.HasOne(pss => pss.PersonalizedSet)
            .WithMany()
            .HasForeignKey("personalized_set_id")
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.HasOne(pss => pss.Supplement)
            .WithMany()
            .HasForeignKey("supplement_id")
            .OnDelete(DeleteBehavior.Cascade);
    }
}