namespace ConAdmin.Domain.Companies;

public class Company : EntityBase
{
    public string Name { get; set; }
    private string Abbreviation { get; set; }
    private Address Address { get; set; }

    public Company(object key, string name, string abbrev, Address address) : base(key)
    {
        Name = name;
        Abbreviation = abbrev;
        Address = address;
    }
 
}