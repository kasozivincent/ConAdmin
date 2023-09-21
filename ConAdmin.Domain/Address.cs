namespace ConAdmin.Domain;

public record Address
{
    public string City { get; }
    public string Street { get; }
    public string State { get; }
    public string PostalCode { get; }

    private Address(string street, string city, string state, string postalCode)
    {
        City = city;
        Street = street;
        State = state;
        PostalCode = postalCode;
    }
    private static bool Validate(string street, string city, string state, string postalCode)
        => (!string.IsNullOrEmpty(street) &&
            !string.IsNullOrEmpty(city) &&
            !string.IsNullOrEmpty(state) &&
            !string.IsNullOrEmpty(postalCode));

    public static Address Create(string street, string city, string state, string postalCode)
        => Validate(street, city, state, postalCode)
            ? new Address(street, city, state, postalCode)
            : throw new Exception("Invalid arguments");
}