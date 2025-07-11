using Biogenom.Application.DataBase;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Biogenom.Infrastructure;

public static class Inject
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<AppDbContext>();
        
        services.AddScoped<IReportRepository, ReportRepository>();

        return services;
    }
}