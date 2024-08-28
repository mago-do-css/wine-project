using _03_WineProject.Domain.Entities;
using _03_WineProject.Domain.Entities.Produtos;
using Microsoft.EntityFrameworkCore;

namespace _02_WineProject.Data.Context
{
    public class WineDbContext : DbContext
    {
        public WineDbContext(DbContextOptions<WineDbContext> options) : base(options)
        {
        }

        //Definir DbSet para as entidades
        public DbSet<Produto> Produto {get; set;}
        public DbSet<Vinho> Vinho {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vinho>()
                .Property(v =>v.Nome).IsRequired();

            //modelBuilder.Entity<Produto>(p =>
            //{
            //    p.Property(p => p.Nome)
            //    .IsRequired()
            //    .HasMaxLenght(50);
            //});
        }  
    }
}
