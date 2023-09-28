using Microsoft.EntityFrameworkCore;

namespace Locadora.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Filme> Filme { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


    }
}
