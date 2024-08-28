﻿using _01_WineProject.Business.Interfaces;
using _02_WineProject.Data.Context;
using _02_WineProject.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace _02_WineProject.Data.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection CreateDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<WineDbContext>(options =>
            {
                options.UseNpgsql(connectionString, npgsqlOptions =>
                {
                    npgsqlOptions.MigrationsAssembly(typeof(WineDbContext).Assembly.FullName);
                });
            });

            // Registro dos repositórios genéricos
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

            // Adicionar outros serviços ou repositórios específicos se necessário
            // Exemplo: services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
