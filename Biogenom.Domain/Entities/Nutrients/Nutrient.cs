using Biogenom.Domain.Entities.Nutrients.ValueObjects;
using Biogenom.Domain.Entities.Reports;
using Biogenom.Domain.Entities.Supplements;

namespace Biogenom.Domain.Entities.Nutrients;

/// <summary>
/// Представляет нутриент (витамин, минерал или другое полезное вещество), включая основное и альтернативное название.
/// </summary>
public class Nutrient
{
    /// <summary>
    /// Уникальный идентификатор нутриента.
    /// </summary>
    public Guid Id { get; private set; }
    
    /// <summary>
    /// Основное название нутриента (например, "Витамин В9").
    /// </summary>
    public string Name { get; private set; }
    
    /// <summary>
    /// Альтернативное или синонимичное название нутриента (например, "фолиевая кислота").
    /// </summary>
    public string AlternativeName { get; private set; }
    
    /// <summary>
    /// Информация для нутриента
    /// </summary>
    public Info Information { get; private set; }

    public List<NutrientConsumption>? NutrientConsumptions = [];
    public List<SupplementNutrient>? SupplementNutrients = [];
    public List<NewConsumption>? NewConsumptions = [];

    public Nutrient()
    {
    }

    public Nutrient(string name, string alternativeName, Info information)
    {
        Id = Guid.NewGuid();
        Name = name;
        AlternativeName = alternativeName;
        Information = information;
    }
}