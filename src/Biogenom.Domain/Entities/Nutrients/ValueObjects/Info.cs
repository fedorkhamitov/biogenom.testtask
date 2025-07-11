namespace Biogenom.Domain.Entities.Nutrients.ValueObjects;

/// <summary>
/// Описывает влияние нутриента на организм и рекомендации по питанию.
/// </summary>
public class Info : ValueObject
{
    /// <summary>
    /// Эффект на организм.
    /// </summary>
    public string BodyEffect { get; }
    
    /// <summary>
    /// Рекомендации по питанию.
    /// </summary>
    public string DietaryRecommendations { get; }
    
    public Info(string bodyEffect, string dietaryRecommendations)
    {
        BodyEffect = bodyEffect ?? throw new ArgumentNullException(nameof(bodyEffect));
        DietaryRecommendations = dietaryRecommendations ?? throw new ArgumentNullException(nameof(dietaryRecommendations));
    }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return BodyEffect;
        yield return DietaryRecommendations;
    }
}