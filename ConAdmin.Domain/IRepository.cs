namespace ConAdmin.Domain;

public interface IRepository<T> where T : EntityBase
{
    T GetBy(object id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    T this[object id] { get; set; }
    void Remove(T entity);
}