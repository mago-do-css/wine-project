using _03_WineProject.Domain.Entities;

namespace _01_WineProject.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
       //Task<Produto> BuscarProdutoPorId(Guid id);
    }
}
