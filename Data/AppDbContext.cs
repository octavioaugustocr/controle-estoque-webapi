using controle_produtos_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace controle_produtos_webapi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProdutosModel> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutosModel>(entity => entity.Property(p => p.Preco).HasColumnType("decimal(18,2)"));
        }
    }
}
