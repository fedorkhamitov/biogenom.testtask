using Biogenom.Domain.Common;

namespace Biogenom.Application.Extensions;

public static class NutrientStatusExtensions
{
    public static string ToDisplayString(this NutrientStatus status)
    {
        return status switch
        {
            NutrientStatus.Deficiency => "Дефицит",
            NutrientStatus.Sufficient => "Достаточно",
            _ => "Не определен"
        };
    }
}