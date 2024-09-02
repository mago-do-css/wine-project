using _02_WineProject.Data.Context;
using _02_WineProject.Data.Interfaces;
using _03_WineProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _02_WineProject.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IDbContextFactory<WineDbContext> _context;

        public ProdutoRepository(IDbContextFactory<WineDbContext> context)
        {
            _context = context;
        }

        public async Task Atualizar(Produto produto)
        {
            using (WineDbContext context = _context.CreateDbContext())
            {
                var produtoExistente = await context.Produto.FindAsync(produto.Id);

                if (produtoExistente == null)
                {
                    throw new InvalidOperationException("Produto não encontrado");
                }

                produtoExistente.Nome = produto.Nome;
                produtoExistente.QtdeEstoque = produto.QtdeEstoque;
                produtoExistente.Preco = produto.Preco;
                produtoExistente.Peso = produto.Peso;
                produtoExistente.Marca = produto.Marca;
                produtoExistente.Descricao = produto.Descricao;

                context.Produto.Update(produtoExistente);

               await context.SaveChangesAsync(); 
            }  
        }

        public async Task<Produto> BuscarPorId(int id)
        {
            using (WineDbContext context = _context.CreateDbContext())
            {
                var produto = await context.Produto.FindAsync(id);

                if (produto == null)
                {
                    throw new KeyNotFoundException($"Produto com o ID {id} não encontrado.");
                }

                return produto; 
            }  
        }

        public async Task<IQueryable<Produto>> BuscarTodos()
        {
            using (WineDbContext context = _context.CreateDbContext())
            {
             var produtos = await context.Produto.ToListAsync();
                return produtos.AsQueryable();
            }
        }

        public async Task Criar(Produto produto)
        {
            using (WineDbContext context = _context.CreateDbContext())
            {
                context.Produto.Add(produto);
                await context.SaveChangesAsync(); 
            } 
        }

        public async Task<bool> Remover(int id)
        {
            using (WineDbContext context = _context.CreateDbContext())
            {
                var produto = await context.Produto.FindAsync(id);

                if (produto == null)
                {
                    return false; // Produto não encontrado
                }

               // produto.Ativo = false;

                //context.Produto.Update(produto);

                await context.SaveChangesAsync();

                return true;
            }  
        }
    }
}
