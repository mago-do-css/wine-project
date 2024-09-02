using _01_WineProject.Business.DTOs;
using _01_WineProject.Business.Interfaces;
using _01_WineProject.Business.Services;

namespace WineProject.API.GraphQL.Mutations
{
    public class ProdutoMutation
    {
        private readonly IProdutoService _produtoService;

        public ProdutoMutation(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<ProdutoDTO> AdicionarProduto(ProdutoDTO produtoDTO)
        {
            //sua mutation de fato pede um dto no param
            return await _produtoService.Criar(produtoDTO);
        }

        public async Task<ProdutoDTO> AtualizarProduto(ProdutoDTO produtoDTO)
        {

            return await _produtoService.Atualizar(produtoDTO);
        }

        public async Task<bool> ExcluirProduto(int id)
        {
            var response = await _produtoService.Remover(id);

            return response;
        }
    }

}
