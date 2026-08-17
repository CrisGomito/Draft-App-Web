
using Microsoft.EntityFrameworkCore;

namespace DraftAppWeb.Models
{
    public class DraftAppWebDbContext : DbContext
    {
        public DraftAppWebDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Productos> Productos
        {
            get; set;
        }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
