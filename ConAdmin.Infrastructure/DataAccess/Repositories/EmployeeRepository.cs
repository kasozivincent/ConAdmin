using ConAdmin.Domain.Employees;

namespace ConAdmin.Infrastructure.DataAccess.Repositories;

public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    public IEnumerable<Employee> GetConstructionAdministrators()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetPrincipals()
    {
        throw new NotImplementedException();
    }
}