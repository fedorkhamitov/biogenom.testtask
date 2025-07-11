namespace Biogenom.Domain.Entities.Supplements;

public class PersonalizedSetSupplement
{
    public Guid Id { get; private set; }
    
    public PersonalizedSet PersonalizedSet { get; set; }
    
    public Supplement Supplement { get; set; }

    public PersonalizedSetSupplement()
    {
    }

    public PersonalizedSetSupplement(PersonalizedSet personalizedSet)
    {
        Id = Guid.NewGuid();
        PersonalizedSet = personalizedSet;
    }
}