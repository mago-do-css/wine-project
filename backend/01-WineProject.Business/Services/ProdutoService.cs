using _01_WineProject.Business.DTOs;
using _01_WineProject.Business.Interfaces;
using _02_WineProject.Data.Interfaces;
using _02_WineProject.Data.Repositories;
using _03_WineProject.Domain.Entities;
using AutoMapper;

namespace _01_WineProject.Business.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<ProdutoDTO> Atualizar(ProdutoDTO produtoDTO)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoDTO);
                await _produtoRepository.Atualizar(produto); 

                var produtoAtualizado = await _produtoRepository.BuscarPorId(produto.Id);
                var produtoAtualizadoDTO = _mapper.Map<ProdutoDTO>(produtoAtualizado);

                return produtoAtualizadoDTO;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ProdutoDTO> Criar(ProdutoDTO produtoDTO)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoDTO);
                await _produtoRepository.Criar(produto);

                return _mapper.Map<ProdutoDTO>(produto);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task<bool> Remover(int id)
        {
            try
            {
                var produtoRemover = _produtoRepository.Remover(id);

                return produtoRemover;
            }catch(Exception ex)
            {
             return null;
            }
        }
    }
}
