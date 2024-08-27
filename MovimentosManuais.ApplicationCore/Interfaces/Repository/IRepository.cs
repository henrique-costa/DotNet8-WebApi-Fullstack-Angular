using System;
using System.Linq.Expressions;

namespace MovimentosManuais.ApplicationCore.Interfaces.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity Add(TEntity entity);
    void Update(TEntity entity);
    IEnumerable<TEntity> GetAll(TEntity entity);
    TEntity GetById(TEntity entity);
    IEnumerable<TEntity> SearchBy(Expression<Func<TEntity, bool>> predicate);
    void Delete(TEntity entity);
}
