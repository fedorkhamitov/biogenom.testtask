namespace Biogenom.Application.Dtos;

public record NewConsumptionDto(
    string NutrientName,
    double FromFood,
    double FromSupplements,
    string Unit);