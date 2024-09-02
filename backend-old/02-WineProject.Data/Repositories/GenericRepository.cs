using _01_WineProject.Business.Interfaces;
using _02_WineProject.Data.Context;
using _03_WineProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _02_WineProject.Data.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly WineDbContext _context;

        public GenericRepository(WineDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<bool> Atualizar(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task Criar(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
