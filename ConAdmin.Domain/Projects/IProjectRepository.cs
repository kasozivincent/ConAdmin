namespace ConAdmin.Domain.Projects;

public interface IProjectRepository : IRepository <Project> 
{
    IEnumerable<Project> FindBy(IEnumerable<MarketSegment> segments, bool completed);
    IEnumerable<MarketSegment> FindAllMarketSegments();
}