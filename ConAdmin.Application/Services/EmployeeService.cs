using ConAdmin.Domain.Employees;
using ConAdmin.Infrastructure.DataAccess;

namespace ConAdmin.Application.Services;

public class EmployeeService
{
    private readonly IUnitOfWork _uow;

    public EmployeeService(IUnitOfWork uow)
        => this._uow = uow;

    public IEnumerable<Employee> GetConstructionAdministrators()
        => _uow.Employees.GetConstructionAdministrators();

    public IEnumerable<Employee> GetPrincipals()
        => _uow.Employees.GetPrincipals();
}