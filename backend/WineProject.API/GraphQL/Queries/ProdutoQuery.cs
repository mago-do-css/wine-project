using _02_WineProject.Data.Interfaces;
using _03_WineProject.Domain.Entities;
using AutoMapper;

namespace WineProject.API.GraphQL.Queries
{
    public class ProdutoQuery
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoQuery(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<IQueryable<Produto>> BuscarTodosProdutos()
        {
            var listaProdutos = await _produtoRepository.BuscarTodos(); 
             
            return listaProdutos;
        }
    }
}
