using Biogenom.Application.DataBase;
using Biogenom.Application.Dtos;
using Biogenom.Application.Extensions;
using Biogenom.Domain.Common;

namespace Biogenom.Application.Services;

public class ReportService
{
    private readonly IReportRepository _reportRepository;
    
    public ReportService(IReportRepository reportRepository)
    {
        _reportRepository = reportRepository;
    }
    
    public async Task<ReportDto?> GetLastReportAsync()
    {
        var report = await _reportRepository.GetLastReportAsync();
        if (report == null) return null;
        
        var summary = new ReportSummaryDto(
            DeficiencyCount: report.NutrientConsumptions?.Count(nc => nc.Status == NutrientStatus.Deficiency) ?? 0,
            SufficientCount: report.NutrientConsumptions?.Count(nc => nc.Status == NutrientStatus.Sufficient) ?? 0
        );
        
        var currentConsumptions = report.NutrientConsumptions?
            .Select(nc => new NutrientConsumptionDto(
                NutrientName: nc.Nutrient?.Name ?? "Неизвестный нутриент",
                CurrentValue: nc.CurrentValue,
                NormValue: nc.NormalValue,
                Unit: nc.Unit.ToDisplayString(),
                Status: nc.Status.ToDisplayString()
            ))
            .ToList() ?? [];
        
        PersonalizedSetDto? personalizedSet = null;
        if (report.PersonalizedSet != null)
        {
            personalizedSet = new PersonalizedSetDto(
                Description: report.PersonalizedSet.Description,
                ProductName: report.PersonalizedSet.ProductName,
                ProductDetails: report.PersonalizedSet.ProductDetails,
                Supplements: report.PersonalizedSet.PersonalizedSetSupplements?
                    .Select(pss => pss.Supplement?.Name ?? "Неизвестная БАД")
                    .ToList() ?? []
            );
        }
        
        var newConsumptions = report.NewConsumptions?
            .Select(nc => new NewConsumptionDto(
                NutrientName: nc.Nutrient?.Name ?? "Неизвестный нутриент",
                FromFood: nc.FromFood,
                FromSupplements: nc.FromSupplement,
                Unit: nc.Unit.ToDisplayString()
            ))
            .ToList() ?? [];
        
        var advantages = report.Advantages?
            .Select(a => new AdvantageDto(Text: a.Text))
            .ToList() ?? [];
        
        return new ReportDto(
            Summary: summary,
            CurrentConsumptions: currentConsumptions,
            PersonalizedSet: personalizedSet,
            NewConsumptions: newConsumptions,
            Advantages: advantages
        );
    }
}