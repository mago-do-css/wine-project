using _01_WineProject.Business.DTOs; 

namespace _01_WineProject.Business.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutoDTO> Criar(ProdutoDTO produtoDTO);
        Task<bool> Remover(int id);
        Task<ProdutoDTO> Atualizar(ProdutoDTO produtoDTO);
    }
}