namespace Biogenom.Domain.Entities.Supplements.ValueObjects;

/// <summary>
/// Представляет объект, содержащий описание и информацию о БАД.
/// Используется для хранения текстового описания и инструкции по использованию.
/// </summary>
public class Info : ValueObject
{
    /// <summary>
    /// Получает описание БАД.
    /// </summary>
    public string Description { get; }
    
    /// <summary>
    /// Получает информацию о применении.
    /// </summary>
    public string Usage { get; }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Info"/>.
    /// </summary>
    /// <param name="description">Описание БАД.</param>
    /// <param name="usage">Информация о применении.</param>
    public Info(string description, string usage)
    {
        Description = description;
        Usage = usage;
    }

    /// <summary>
    /// Возвращает компоненты.
    /// </summary>
    /// <returns>Перечисление компонентов.</returns>
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Description;
        yield return Usage;
    }
}