using _01_WineProject.Business.DTOs;
using _01_WineProject.Business.Interfaces;
using _02_WineProject.Data.Repositories;
using _03_WineProject.Domain.Entities;
using AutoMapper;
using System.Linq.Expressions;

namespace _01_WineProject.Business.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly ProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(ProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<ProdutoDTO> AtualizarProduto(ProdutoDTO produtoDTO)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoDTO);
                var produtoParaAtualizar = await  _produtoRepository.Atualizar(produto);

                if (produtoParaAtualizar == false)
                {
                    throw new InvalidOperationException("Produto não encontrado");
                }

                var produtoAtualizado = await _produtoRepository.BuscarProdutoPorId(produto.Id);
                var produtoAtualizadoDTO = _mapper.Map<ProdutoDTO>(produtoAtualizado);

                return produtoAtualizadoDTO;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
 
        public async Task<ProdutoDTO> CriarProduto(ProdutoDTO produtoDto)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoDto);
                await _produtoRepository.Criar(produto);

                return _mapper.Map<ProdutoDTO>(produto);

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> RemoverProduto(Guid id)
        {
            try
            {
                var removerProduto = await _produtoRepository.Remover(id);

                if (removerProduto == false)
                {
                    throw new InvalidOperationException("Produto não encontrado");
                }
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
