namespace ConAdmin.Domain.Companies;

public class Company : EntityBase
{
    public string Name { get; set; }
    private string Abbreviation { get; set; }
    private List<Address> Addresses { get; }
    private Address _headquartersAddress;
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public string Url { set; get; }
    public string Remarks { set; get; }
    public Company(object key, string name, string abbrev, Address address) : base(key)
    {
        Name = name;
        Abbreviation = abbrev;
        Addresses = new List<Address>();
    }
    public Address HeadquartersAddress
    {
        get => this._headquartersAddress; 
        set
        {
            if (this._headquartersAddress != value)
            {
                this._headquartersAddress = value;
                if (!Addresses.Contains(value))
                    Addresses.Add(value);
            }
        }
    }
 
}