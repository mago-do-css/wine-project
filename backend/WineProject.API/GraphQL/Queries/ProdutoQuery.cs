using _02_WineProject.Data.Context;
using _03_WineProject.Domain.Entities;
using WineProject.API.Schema;

namespace WineProject.API.GraphQL
{
    [ExtendObjectType("Query")]
    public partial class ProdutoQuery
    {  
        [GraphQLDescription("Gets the list of products.")]
        public IQueryable<Produto> BuscarTodosProdutos([ScopedService] WineDbContext context)
        {
            //pode acesar diretamente o banco de dados e retornar um iqueriable<produto> 
            //pode aplicar filtros, paginação ou outras operações 
            return new ProdutoType.ProdutoResolvers().BuscarTodosProdutos(context);
        }  
    }
}
