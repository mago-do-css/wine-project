using _03_WineProject.Domain.Entities;
using System.Linq.Expressions;

namespace _01_WineProject.Business.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task Criar(TEntity entity);
        Task<TEntity> BuscarPorId(Guid id);
        Task<List<TEntity>> BuscarTodos();
        Task<bool> Remover(Guid id);
        Task<bool> Atualizar(TEntity entity); 
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
    }
}
