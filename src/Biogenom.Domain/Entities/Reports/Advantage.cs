namespace Biogenom.Domain.Entities.Reports;

public class Advantage
{
    public Guid Id { get; private set; }
    public string Text { get; private set; }

    public Report? Report { get; set; }

    public Advantage()
    {
    }

    public Advantage(string text)
    {
        Id = Guid.NewGuid();
        Text = text;
    }
}