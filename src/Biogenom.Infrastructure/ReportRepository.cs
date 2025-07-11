using Biogenom.Application.DataBase;
using Biogenom.Domain.Entities.Reports;
using Microsoft.EntityFrameworkCore;

namespace Biogenom.Infrastructure;

public class ReportRepository : IReportRepository
{
    private readonly AppDbContext _context;

    public ReportRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Report?> GetLastReportAsync()
    {
        return await _context.Reports
            .Include(r => r.NutrientConsumptions)
                .ThenInclude(nc => nc.Nutrient)
            .Include(r => r.PersonalizedSet)
                .ThenInclude(ps => ps.PersonalizedSetSupplements)
                    .ThenInclude(pss => pss.Supplement)
            .Include(r => r.NewConsumptions)!
                .ThenInclude(nc => nc.Nutrient)
            .Include(r => r.Advantages)
            .OrderByDescending(r => r.CreatedAt)
            .FirstOrDefaultAsync();
    }
}