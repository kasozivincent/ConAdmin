namespace ConAdmin.Domain.Employees;

public class Employee : Person
{
    private string JobTitle { get; set; }
 
    public Employee(object key, string firstName, string lastName) : base(key, firstName, lastName)
        =>  JobTitle = string.Empty;
}