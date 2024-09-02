using _03_WineProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace _02_WineProject.Data.Context
{
    public class WineDbContext :DbContext
    {
        public WineDbContext(DbContextOptions<WineDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WineDbContext).Assembly);
        }
    } 
}
