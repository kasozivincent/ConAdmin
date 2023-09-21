namespace ConAdmin.Domain.Employees;

public interface IEmployeeRepository : IRepository<Employee>
{
    IEnumerable<Employee> GetConstructionAdministrators();
    IEnumerable<Employee> GetPrincipals();
}