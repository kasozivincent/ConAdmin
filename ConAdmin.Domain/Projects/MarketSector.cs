namespace ConAdmin.Domain.Projects;

public class MarketSector : EntityBase
{
    public string Name { set; get; }
    public IEnumerable<MarketSegment> Segments { get; }
 
    public MarketSector(object? key, string name) : base(key)
    {
        Name = name;
        Segments = new List<MarketSegment>();
    }
}