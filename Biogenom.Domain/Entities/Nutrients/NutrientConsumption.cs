using Biogenom.Domain.Common;
using Biogenom.Domain.Entities.Reports;

namespace Biogenom.Domain.Entities.Nutrients;

/// <summary>
/// Представляет информацию о потреблении конкретного нутриента.
/// </summary>
public class NutrientConsumption
{
    /// <summary>
    /// Уникальный идентификатор записи о потреблении нутриента.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Фактическое (текущее) значение потребления нутриента.
    /// </summary>
    public double CurrentValue { get; private set; }

    /// <summary>
    /// Значение нормы потребления нутриента.
    /// </summary>
    public double NormalValue { get; private set; }

    /// <summary>
    /// Единица измерения потребления нутриента.
    /// </summary>
    public UnitType Unit { get; private set; }

    /// <summary>
    /// Статус нутриента.
    /// </summary>
    public NutrientStatus Status { get; private set; }


    //public Guid? NutrientId { get; private set; }

    /// <summary>
    /// Нутриент, к которому относится эта запись.
    /// </summary>
    public Nutrient? Nutrient { get; set; }

    //public Guid? ReportId { get; private set; } = default;

    /// <summary>
    /// Отчет
    /// </summary>
    public Report? Report { get; set; }

    public NutrientConsumption()
    {
    }

    public NutrientConsumption(double currentValue, double normalValue, UnitType unit, NutrientStatus status)
    {
        Id = Guid.NewGuid();
        CurrentValue = currentValue;
        NormalValue = normalValue;
        Unit = unit;
        Status = status;
    }
}