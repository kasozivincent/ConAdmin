using ConAdmin.Domain;
using ConAdmin.Domain.Projects;

namespace ConAdmin.Infrastructure.DataAccess.Repositories;

public class ProjectRepository : Repository<Project>, IProjectRepository 
{
    public IEnumerable<Project> FindBy(IEnumerable<MarketSegment> segments, bool completed)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<MarketSegment> FindAllMarketSegments()
    {
        throw new NotImplementedException();
    }

    public void SaveContact(ProjectContact contact)
    {
        throw new NotImplementedException();
    }
}