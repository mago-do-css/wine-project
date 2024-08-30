using _01_WineProject.Business.DTOs;
using _01_WineProject.Business.Services;
using HotChocolate;
using System.Threading.Tasks; 

public class ProdutoMutation
{
    private readonly ProdutoService _produtoService;

    public ProdutoMutation(ProdutoService produtoService)
    {
        _produtoService = produtoService; 
    }

    public async Task<ProdutoDTO> AdicionarProduto(ProdutoDTO produtoDTO)
    {
       return await _produtoService.CriarProduto(produtoDTO);
    }

    public async Task<ProdutoDTO> AtualizarProduto(ProdutoDTO produtoDTO)
    {

        return await _produtoService.AtualizarProduto(produtoDTO);
    }

    public async Task<bool> ExcluirProduto(Guid id)
    {
         var response = await _produtoService.RemoverProduto(id);

        return response;
    }
}
