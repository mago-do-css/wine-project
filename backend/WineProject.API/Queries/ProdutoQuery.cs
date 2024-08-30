using _02_WineProject.Data.Context;
using _03_WineProject.Domain.Entities;
using WineProject.API.Types;

namespace WineProject.API.GraphQL
{
    [ExtendObjectType("Query")]
    public partial class ProdutoQuery
    {  
        [GraphQLDescription("Gets the list of products.")]
        public IQueryable<Produto> BuscarTodosProdutos([ScopedService] WineDbContext context)
        {
            return new ProdutoType.ProdutoResolvers().BuscarTodosProdutos(context);
        }  
    }
}
