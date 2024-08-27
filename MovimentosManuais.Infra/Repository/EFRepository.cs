using System;
using System.Linq.Expressions;
using MovimentosManuais.ApplicationCore.Interfaces.Repository;
using MovimentosManuais.Infra.Data;

namespace MovimentosManuais.Infra.Repository;

public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly MovimentosManuaisContext _dbContext;

    public EFRepository(MovimentosManuaisContext dbContext)
    {
        _dbContext = dbContext;
    }

    public TEntity Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> GetAll(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public TEntity GetById(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> SearchBy(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
