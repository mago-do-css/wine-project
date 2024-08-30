using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Data;
using _02_WineProject.Data.Context; 
using System.Linq;
using _03_WineProject.Domain.Entities;
using _01_WineProject.Business.DTOs;

namespace WineProject.API.Types
{
    public class ProdutoType : ObjectType<Produto>
    {
        protected override void Configure(IObjectTypeDescriptor<Produto> descriptor)
        {
            descriptor
                .Field(p => p.Id) ;

            descriptor
                .Field(p => p.Nome)
                .Description("Nome do produto");

            descriptor
                .Field(p => p.QtdeEstoque)
                .Description("Quantidade do estoque");

            descriptor
                .Field(p => p.Preco)
                .Description("Preço do produto");

            descriptor
                .Field(p => p.Peso)
                .Description("Peso do produto");

            descriptor
                .Field(p => p.Marca)
                .Description("Marca do produto");

            descriptor
                .Field(p => p.Descricao)
                .Description("Descrição");

            // Exemplo de um campo que resolve dados diretamente do banco de dados
            descriptor
                .Field("buscarTodosProdutos")
                .ResolveWith<ProdutoResolvers>(p => p.BuscarTodosProdutos(default))
                .UseDbContext<WineDbContext>()
                .Description("Gets all products.");
        }

        public class ProdutoResolvers
        {
            [UseDbContext(typeof(WineDbContext))]
            public IQueryable<Produto> BuscarTodosProdutos([ScopedService] WineDbContext context)
            {
                return context.Produto;
            }
        }
    }
}
