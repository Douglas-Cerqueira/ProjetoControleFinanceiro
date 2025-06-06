using ProjetoControleFinanceiro.Models;

namespace ProjetoControleFinanceiro.Services.Contracts
{
    public interface IUsuarioService
    {
        Task CadastrarUsuario(UsuarioModel usuario);
        Task<UsuarioModel> ObterUsuarioPorEmailESenha(string email, string senha);
    }
}
