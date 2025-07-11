namespace Biogenom.Application.Dtos;

public record ReportDto(
    ReportSummaryDto Summary,
    List<NutrientConsumptionDto> CurrentConsumptions,
    PersonalizedSetDto? PersonalizedSet,
    List<NewConsumptionDto> NewConsumptions,
    List<AdvantageDto> Advantages);