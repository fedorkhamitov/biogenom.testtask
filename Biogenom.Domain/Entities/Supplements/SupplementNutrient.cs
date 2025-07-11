using Biogenom.Domain.Common;
using Biogenom.Domain.Entities.Nutrients;

namespace Biogenom.Domain.Entities.Supplements;

public class SupplementNutrient
{
    public Guid Id { get; private set; }
    public double Amount { get; private set; }
    public UnitType Unit { get; private set; }
    public Supplement Supplement { get; set; }
    public Nutrient Nutrient { get; set; }

    public SupplementNutrient()
    {
    }

    public SupplementNutrient(double amount, UnitType unit)
    {
        Id = Guid.NewGuid();
        Amount = amount;
        Unit = unit;
    }
}