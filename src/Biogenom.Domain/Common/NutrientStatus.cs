namespace Biogenom.Domain.Common;

/// <summary>
/// Перечисление статусов потребления нутриента относительно нормы.
/// </summary>
public enum NutrientStatus
{
    /// <summary>
    /// Статус не определён или не рассчитан.
    /// </summary>
    None,
    
    /// <summary>
    /// Дефицит нутриента (значение ниже нормы).
    /// </summary>
    Deficiency,
    
    /// <summary>
    /// Достаточное количество нутриента (значение потребления в пределах нормы).
    /// </summary>
    Sufficient,
}