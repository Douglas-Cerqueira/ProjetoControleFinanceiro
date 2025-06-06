using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Repository;
using ProjetoControleFinanceiro.Services.Contracts;
using ProjetoControleFinanceiro.Views;

namespace ProjetoControleFinanceiro.Services
{
    public class UsuarioService : IUsuarioService
    {
        public async Task CadastrarUsuario(UsuarioModel usuario)
        {
			try
			{
				using (var db = new FinanceiroContext())
				{
					db.Usuarios.Add(usuario);
					await db.SaveChangesAsync();

				}
			}
			catch (Exception )
			{

				throw;
			}
        }

        
    }
}
