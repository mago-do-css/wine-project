using HotChocolate.Execution.Configuration;
using HotChocolate.Types.Pagination;
using WineProject.API.GraphQL;
using WineProject.API.Types;

namespace WineProject.API
{
    public static class GraphQLConfig
    {
        public static IRequestExecutorBuilder CreateGraphQLConfig(this IServiceCollection services)
        {
            return services
                .AddAuthorization()
                .AddGraphQLServer()
                .AddQueryType<ProdutoQuery>()
                .AddMutationType<ProdutoMutation>()
                .AddType<ProdutoType>() 
                .SetRequestOptions(_ => new HotChocolate.Execution.Options.RequestExecutorOptions
                {
                    ExecutionTimeout = TimeSpan.FromMinutes(5)
                })
                .SetPagingOptions(new PagingOptions
                {
                    DefaultPageSize = 15,
                    MaxPageSize = int.MaxValue,
                    IncludeTotalCount = true
                })
                .AddProjections()
                .AddFiltering()
                .AddSorting();
        }

        public static IRequestExecutorBuilder CreateGraphQLMutationConfig(this IRequestExecutorBuilder builder)
        {
            return builder
                .AddMutationType<ProdutoMutation>();
        }

        public static IRequestExecutorBuilder CreateGraphQLTypeConfig(this IRequestExecutorBuilder builder)
        {
            return builder
                .AddType<ProdutoType>();
        }

        public static IRequestExecutorBuilder CreateGraphQLQueryConfig(this IRequestExecutorBuilder builder)
        {
            return builder
                .AddQueryType<ProdutoQuery>();
        }
    }
}
