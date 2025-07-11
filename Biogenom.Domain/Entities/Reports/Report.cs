using Biogenom.Domain.Entities.Nutrients;
using Biogenom.Domain.Entities.Supplements;

namespace Biogenom.Domain.Entities.Reports;

public class Report
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public List<NutrientConsumption>? NutrientConsumptions = [];
    public PersonalizedSet? PersonalizedSet { get; set; }
    public List<NewConsumption>? NewConsumptions = [];
    public List<Advantage>? Advantages = [];

    public Report()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }
}