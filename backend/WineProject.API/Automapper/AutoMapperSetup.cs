
namespace WineProject.API.Automapper
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ProdutoMapping));
        }
    } 
}
