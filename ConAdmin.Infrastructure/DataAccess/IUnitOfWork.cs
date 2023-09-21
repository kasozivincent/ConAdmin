using ConAdmin.Domain.Employees;
using ConAdmin.Domain.Projects;

namespace ConAdmin.Infrastructure.DataAccess;

public interface IUnitOfWork 
{
    public IProjectRepository Projects { get; }
    public IEmployeeRepository Employees { get; }
    void OnComplete();
}