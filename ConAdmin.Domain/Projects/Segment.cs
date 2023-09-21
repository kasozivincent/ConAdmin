namespace ConAdmin.Domain.Projects;
public class MarketSegment : EntityBase
{
    public MarketSector ParentSector { get; }
    public string Name { get; set; }
    public string Code { set; get; }
 
    public MarketSegment(object? key, MarketSector parentSector, string name,
        string code) : base(key)
    {
        ParentSector = parentSector;
        Name = name;
        Code = code;
    }
}