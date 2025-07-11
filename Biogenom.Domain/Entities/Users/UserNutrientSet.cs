namespace Biogenom.Domain.Entities.Users;

public class UserNutrientSet
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid NutrientConsumptionId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}