using ConAdmin.Domain.Projects;
using ConAdmin.Infrastructure.DataAccess;

namespace ConAdmin.Application.Services;

public class ProjectService
{
    private readonly IUnitOfWork _uow;

    public ProjectService(IUnitOfWork uow)
        => this._uow = uow;

    public IEnumerable<Project> GetAllProjects()
        => _uow.Projects.GetAll();

    public IEnumerable<MarketSegment> GetMarketSegments()
        => _uow.Projects.FindAllMarketSegments();
}