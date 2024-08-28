using _01_WineProject.Business.Interfaces;
using _02_WineProject.Data.Context;
using _03_WineProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _02_WineProject.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly WineDbContext _context;

        public ProdutoRepository(WineDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> Atualizar(Produto produto)
        {
            try
            {
                var produtoExistente = await _context.Produto.FindAsync(produto.Id);

                if (produtoExistente == null) {
                    throw new InvalidOperationException("Produto não encontrado");
                }
                  
                produtoExistente.Nome = produto.Nome;
                produtoExistente.QtdeEstoque = produto.QtdeEstoque;
                produtoExistente.Preco = produto.Preco;
                produtoExistente.Peso = produto.Peso;
                produtoExistente.Marca = produto.Marca;
                produtoExistente.Descricao = produto.Descricao;

                _context.Produto.Update(produtoExistente);
                 
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public Task<IEnumerable<Produto>> Buscar(Expression<Func<Produto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Produto> BuscarProdutoPorId(Guid id)
        {
            try
            {
                var produto = await _context.Produto.FindAsync(id);

                if (produto == null)
                { 
                    throw new KeyNotFoundException($"Produto com o ID {id} não encontrado.");
                }

                return produto;

            }
            catch (Exception ex) {
                throw;
            }
        }

        public Task<List<Produto>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public async Task Criar(Produto produto)
        {
            try
            {
               _context.Produto.Add(produto);
               await _context.SaveChangesAsync();
               return ;
            }
            catch (Exception ex) { 
                throw new NotImplementedException();
            }
        }

        public async Task<bool> Remover(Guid id)
        {
            try
            {
                var produto = await _context.Produto.FindAsync(id);

                if (produto == null)
                {
                    return false; // Produto não encontrado
                }
                _context.Produto.Remove(produto);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Task<int> SalvarAlteracao()
        {
            throw new NotImplementedException();
        }
    }
}
