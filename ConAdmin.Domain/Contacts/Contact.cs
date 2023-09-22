using ConAdmin.Domain.Companies;
using ConAdmin.Domain.Employees;

namespace ConAdmin.Domain.Contacts;

public class Contact : Person
{
    public string JobTitle { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string MobilePhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public string Remarks { get; set; }
    public Company? CurrentCompany { get; set; }
    public List<Address> Addresses { get; }
    
    public Contact(object? key, string firstName, string lastName) : base(key, firstName, lastName)
    {
        JobTitle = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        MobilePhoneNumber = string.Empty;
        FaxNumber = string.Empty;
        Remarks = string.Empty;
        CurrentCompany = null;
        Addresses = new List<Address>();
    }
}