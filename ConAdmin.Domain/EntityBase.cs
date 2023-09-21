namespace ConAdmin.Domain;

public abstract class EntityBase
{
    protected EntityBase() : this(null){}
    protected EntityBase(object? key) => Key = key;
    public object? Key { get; }
    public override bool Equals(object? entity)
        => entity is EntityBase other && this == other;
    public override int GetHashCode()
        => this.Key.GetHashCode();
    public static bool operator ==(EntityBase base1, EntityBase base2)
        => base1.Key == base2.Key;
    public static bool operator !=(EntityBase base1, EntityBase base2)
        => !(base1 == base2);
}