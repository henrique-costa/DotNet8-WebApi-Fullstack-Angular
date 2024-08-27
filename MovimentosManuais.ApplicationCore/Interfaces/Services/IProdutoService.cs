using System;
using System.Linq.Expressions;
using MovimentosManuais.ApplicationCore.Entity;

namespace MovimentosManuais.ApplicationCore.Interfaces.Services;

public interface IProdutoService
{
    Produto Add(Produto entity);
    void Update(Produto entity);
    Task<IEnumerable<Produto>> GetAll();
    Produto GetById(int Id);
    IEnumerable<Produto> Search(Expression<Func<Produto, bool>> predicate);
    void Delete(Produto entity);
}
