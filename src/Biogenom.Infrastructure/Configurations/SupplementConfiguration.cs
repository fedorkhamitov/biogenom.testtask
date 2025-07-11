using Biogenom.Domain.Entities.Supplements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom.Infrastructure.Configurations;

public class SupplementConfiguration : IEntityTypeConfiguration<Supplement>
{
    public void Configure(EntityTypeBuilder<Supplement> builder)
    {
        builder.ToTable("supplements");

        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.Name)
            .IsRequired()
            .HasColumnType("varchar");

        builder.Property(s => s.Information.Description)
            .IsRequired();
        
        builder.Property(s => s.Information.Usage)
            .IsRequired();
    }
}