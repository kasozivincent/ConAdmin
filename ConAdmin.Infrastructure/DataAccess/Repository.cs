using ConAdmin.Domain;

namespace ConAdmin.Infrastructure.DataAccess;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
{
    public TEntity GetBy(object id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> FindBy(Func<TEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public TEntity this[object id]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public void Remove(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        throw new NotImplementedException();
    }
}