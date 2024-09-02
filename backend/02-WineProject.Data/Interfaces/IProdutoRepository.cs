using _03_WineProject.Domain.Entities;
using System.Linq.Expressions;

namespace _02_WineProject.Data.Interfaces
{
    public interface IProdutoRepository
    {
        Task Criar(Produto produto);
        Task<Produto> BuscarPorId(int id);
        Task<IQueryable<Produto>> BuscarTodos();
        Task<bool> Remover(int id);
        Task Atualizar(Produto produto); 
    }
}
