using Biogenom.Domain.Entities.Supplements.ValueObjects;

namespace Biogenom.Domain.Entities.Supplements;

/// <summary>
/// Представляет биологически активную добавку (БАД).
/// </summary>
public class Supplement
{
    /// <summary>
    /// Уникальный идентификатор БАД.
    /// </summary>
    public Guid Id { get; private set; }
    
    /// <summary>
    /// Название БАД.
    /// </summary>
    public string Name { get; private set; }
    
    /// <summary>
    /// Информация для БАД
    /// </summary>
    public Info Information { get; private set; }
    
    public List<SupplementNutrient> SupplementNutrients = [];
    public List<PersonalizedSetSupplement> PersonalizedSetSupplements = [];
    
    public Supplement(string name, Info information)
    {
        Id = Guid.NewGuid();
        Name = name;
        Information = information;
    }
}