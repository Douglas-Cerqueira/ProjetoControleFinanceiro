using Microsoft.EntityFrameworkCore;
using ProjetoControleFinanceiro.Models;

namespace ProjetoControleFinanceiro.Repository
{
    public class FinanceiroContext : DbContext
    {
        public DbSet<CategoriasModel> Categorias { get; set; }
        public DbSet<TransacoesModel> Transacoes { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-S864QTA;Database=FinanceiroDb;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UsuarioModel>(e =>
            {
                e.HasKey(u => u.Id);
                e.Property(u => u.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();
            });

            builder.Entity<CategoriasModel>(e =>
            {
                e.HasKey(c => c.IdCategoria);
                e.Property (c => c.IdCategoria)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            });

            builder.Entity<TransacoesModel>(e =>
            {
                e.HasKey(t => t.IdTransacao);
                e.Property(t => t.IdTransacao)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            });

            base.OnModelCreating(builder);
        }
    }
}
