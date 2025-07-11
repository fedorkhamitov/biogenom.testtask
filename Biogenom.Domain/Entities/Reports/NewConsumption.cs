using Biogenom.Domain.Common;
using Biogenom.Domain.Entities.Nutrients;

namespace Biogenom.Domain.Entities.Reports;

public class NewConsumption
{
    public Guid Id { get; private set; }
    public double CurrentConsumption { get; private set; }
    public double FromSupplement { get; private set; }
    public double FromFood { get; private set; }
    
    public UnitType Unit { get; private set; }
    
    public Nutrient Nutrient { get; set; }
    
    public Report Report { get; set; }

    public NewConsumption()
    {
    }

    public NewConsumption(
        double currentConsumption, 
        double fromSupplement, 
        double fromFood,
        UnitType unit)
    {
        Id = Guid.NewGuid();
        CurrentConsumption = currentConsumption;
        FromSupplement = fromSupplement;
        FromFood = fromFood;
        Unit = unit;
    }
}