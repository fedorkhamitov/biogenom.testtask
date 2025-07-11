using Biogenom.Domain.Common;
using Biogenom.Domain.Entities.Nutrients;
using Biogenom.Domain.Entities.Reports;
using Biogenom.Domain.Entities.Supplements;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Biogenom.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(IConfiguration configuration, DbContextOptions<AppDbContext> options) : base(options)
    {
        _configuration = configuration;
    }

    private readonly IConfiguration _configuration;
    
    public DbSet<Report?> Reports { get; set; }
    public DbSet<Nutrient> Nutrients { get; set; }
    public DbSet<NutrientConsumption> NutrientConsumptions { get; set; }
    public DbSet<Supplement> Supplements { get; set; }
    public DbSet<SupplementNutrient> SupplementNutrients { get; set; }
    public DbSet<PersonalizedSet> PersonalizedSets { get; set; }
    public DbSet<PersonalizedSetSupplement> PersonalizedSetSupplements { get; set; }
    public DbSet<NewConsumption> NewConsumptions { get; set; }
    public DbSet<Advantage> Advantages { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString(Constants.DbConnectionString));
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}