using _01_WineProject.Business.DTOs;
using _03_WineProject.Domain.Entities;

namespace _01_WineProject.Business.Interfaces
{
    public interface IProdutoService : IService<Produto>
    {
        Task<ProdutoDTO> CriarProduto(ProdutoDTO produtoDTO);  
        Task<bool> RemoverProduto(Guid id);
        Task<ProdutoDTO> AtualizarProduto(ProdutoDTO produtoDTO);
    }
}
