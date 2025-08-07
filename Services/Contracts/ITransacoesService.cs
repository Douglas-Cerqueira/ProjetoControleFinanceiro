using ProjetoControleFinanceiro.Models;

namespace ProjetoControleFinanceiro.Services.Contracts
{
    public interface ITransacoesService
    {
        Task AdicionarTransacao(TransacoesModel transacao);
        Task<List<TransacoesModel>> CarregarTransacoes();
    }
}
