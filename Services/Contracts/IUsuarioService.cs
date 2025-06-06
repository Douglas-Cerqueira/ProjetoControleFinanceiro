using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoControleFinanceiro.Models;

namespace ProjetoControleFinanceiro.Services.Contracts
{
    public interface IUsuarioService
    {
       Task CadastrarUsuario(UsuarioModel usuario);
      
    }
}
