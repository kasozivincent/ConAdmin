namespace ConAdmin.Domain;

public interface IRepository<TEntity> where TEntity : EntityBase
{
    TEntity GetBy(object id);
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> FindBy(Func<TEntity, bool> predicate);
    void Add(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);
    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
}