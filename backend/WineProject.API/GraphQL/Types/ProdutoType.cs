using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Data;
using _02_WineProject.Data.Context; 
using System.Linq;
using _03_WineProject.Domain.Entities;
using _01_WineProject.Business.DTOs;

namespace WineProject.API.Schema
{
    public class ProdutoType : ObjectType<Produto>
    {
        protected override void Configure(IObjectTypeDescriptor<Produto> descriptor)
        {
            descriptor
                .Field(p => p.Id)
                .Description("Represents the unique ID of the product.");

            descriptor
                .Field(p => p.Nome)
                .Description("Represents the name of the product.");

            descriptor
                .Field(p => p.QtdeEstoque)
                .Description("Represents the quantity in stock of the product.");

            descriptor
                .Field(p => p.Preco)
                .Description("Represents the price of the product.");

            descriptor
                .Field(p => p.Peso)
                .Description("Represents the weight of the product.");

            descriptor
                .Field(p => p.Marca)
                .Description("Represents the brand of the product.");

            descriptor
                .Field(p => p.Descricao)
                .Description("Represents the description of the product.");

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
