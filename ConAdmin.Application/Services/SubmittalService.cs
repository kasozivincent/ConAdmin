using ConAdmin.Domain.Projects;
using ConAdmin.Domain.Submittals;
using ConAdmin.Infrastructure.DataAccess;

namespace ConAdmin.Application.Services;

public class SubmittalService
{
    private readonly IUnitOfWork _uow;

    public SubmittalService(IUnitOfWork uow)
        => this._uow = uow;

    public IEnumerable<Submittal> GetSubmittals(Project project)
        => _uow.Submittals.FindBy(project);

    public IEnumerable<SpecificationSection> GetSpecificationSections()
        => _uow.Submittals.FindAllSpecificationSections();

    public IEnumerable<SubmittalStatus> GetSubmittalStatuses()
        => _uow.Submittals.FindAllSubmittalStatuses();
    
    public  IEnumerable<Discipline> GetDisciplines()
        => _uow.Submittals.FindAllDisciplines();
    
    public void SaveSubmittal(Submittal submittal)
    {
        //SubmittalService.repository[submittal.Key] = submittal;
        _uow.OnComplete();
    }
}