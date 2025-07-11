using Biogenom.Domain.Entities.Reports;

namespace Biogenom.Domain.Entities.Supplements;

public class PersonalizedSet
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public string Description { get; private set; }
    public string ProductName { get; private set; }
    public string ProductDetails { get; private set; }

    public List<PersonalizedSetSupplement> PersonalizedSetSupplements = [];

    public Report Report { get; set; }

    public PersonalizedSet(DateTime createdAt, string description, string productName, string productDetails)
    {
        Id = Guid.NewGuid();
        CreatedAt = createdAt;
        Description = description;
        ProductName = productName;
        ProductDetails = productDetails;
    }
}