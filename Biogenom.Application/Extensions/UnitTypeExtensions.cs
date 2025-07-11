using Biogenom.Domain.Common;

namespace Biogenom.Application.Extensions;

public static class UnitTypeExtensions
{
    public static string ToDisplayString(this UnitType unit)
    {
        return unit switch
        {
            UnitType.Gram => "г",
            UnitType.Milligram => "мг",
            UnitType.Microgram => "мкг",
            UnitType.Kilocalorie => "ккал",
            _ => "ед."
        };
    }
}