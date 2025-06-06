using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
            //Quero que salve no usando entity porem no sql server, oq faço
            options.UseSqlServer("Server=DESKTOP-S864QTA;Database=FinanceiroDb;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
