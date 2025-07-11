namespace Biogenom.Application.Dtos;

public record PersonalizedSetDto(
    string Description,
    string ProductName,
    string ProductDetails,
    List<string> Supplements);