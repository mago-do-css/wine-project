using _01_WineProject.Business.Interfaces;
using _01_WineProject.Business.Services;
using _02_WineProject.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace _01_WineProject.Business.Configuration
{
    public static class DependencyInjection
    { 
        public static IServiceCollection DependencesServices(this IServiceCollection services)
        { 
            services.AddScoped<IProdutoService, ProdutoService>(); 
            
            return services;
        } 
    }
}
