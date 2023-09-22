using ConAdmin.Domain.Projects;

namespace ConAdmin.Domain.Submittals;

public interface ISubmittalRepository : IRepository<Submittal>
{
    IEnumerable<Submittal> FindBy(Project project);
    IEnumerable<SpecificationSection> FindAllSpecificationSections();
    IEnumerable<SubmittalStatus> FindAllSubmittalStatuses();
    IEnumerable<Discipline> FindAllDisciplines();
}