namespace Biogenom.Application.Dtos;

public record NutrientConsumptionDto(
    string NutrientName,
    double CurrentValue,
    double NormValue,
    string Unit,
    string Status);