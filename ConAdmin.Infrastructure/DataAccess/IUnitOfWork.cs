using ConAdmin.Domain.Companies;
using ConAdmin.Domain.Contacts;
using ConAdmin.Domain.Employees;
using ConAdmin.Domain.Projects;

namespace ConAdmin.Infrastructure.DataAccess;

public interface IUnitOfWork 
{
    public IProjectRepository Projects { get; }
    public IEmployeeRepository Employees { get; }
    public IContactRepository Contacts { get; }
    public ICompanyRepository Companies { get; }
    void OnComplete();
}