using ConAdmin.Domain.Companies;
using ConAdmin.Domain.Contacts;
using ConAdmin.Domain.Employees;
using ConAdmin.Domain.Projects;
using ConAdmin.Domain.Submittals;

namespace ConAdmin.Infrastructure.DataAccess;

public interface IUnitOfWork 
{
    public IProjectRepository Projects { get; }
    public IEmployeeRepository Employees { get; }
    public IContactRepository Contacts { get; }
    public ICompanyRepository Companies { get; }
    public ISubmittalRepository Submittals { get; }
    void OnComplete();
}