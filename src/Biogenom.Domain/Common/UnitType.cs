namespace Biogenom.Domain.Common;

/// <summary>
/// Перечисление единиц измерения для нутриентов
/// </summary>
public enum UnitType
{
    /// <summary>
    /// Без единицы измерения.
    /// </summary>
    None,
    
    /// <summary>
    /// Грамм (г).
    /// </summary>
    Gram,
    
    /// <summary>
    /// Миллиграмм (мг).
    /// </summary>
    Milligram,
    
    /// <summary>
    /// Микрограмм (мкг).
    /// </summary>
    Microgram,
    
    /// <summary>
    /// Килокалория (ккал) — единица измерения энергии.
    /// </summary>
    Kilocalorie
}