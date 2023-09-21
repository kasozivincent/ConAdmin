namespace ConAdmin.Domain.Projects;

public interface IProjectRepository : IRepository <Project> 
{
    IEnumerable<Project> FindBy(IEnumerable<MarketSegment> segments, bool completed);
    Project FindBy(string projectNumber);
    IEnumerable<MarketSegment> FindAllMarketSegments();
}