using Microsoft.EntityFrameworkCore;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Repository;
using ProjetoControleFinanceiro.Services.Contracts;

namespace ProjetoControleFinanceiro.Services
{
    public class UsuarioService : IUsuarioService
    {
        public async Task CadastrarUsuario(UsuarioModel usuario)
        {
            try
            {
                using var context = new FinanceiroContext();

                context.Usuarios.Add(usuario);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UsuarioModel> ObterUsuarioPorEmailESenha(string email, string senha)
        {
            try
            {
                using var context = new FinanceiroContext();

                return await context.Usuarios
                    .AsNoTracking()
                    .SingleOrDefaultAsync(u => u.Email == email && u.Senha == senha);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
