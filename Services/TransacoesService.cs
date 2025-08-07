using Microsoft.EntityFrameworkCore;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Repository;
using ProjetoControleFinanceiro.Services.Contracts;

namespace ProjetoControleFinanceiro.Services
{
    public class TransacoesService : ITransacoesService
    {
        public async Task AdicionarTransacao(TransacoesModel transacao)
        {
            try
            {
                using var context = new FinanceiroContext();
                context.Transacoes.Add(transacao);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<TransacoesModel>> CarregarTransacoes()
        {
            try
            {
                using var context = new FinanceiroContext();
                return await context.Transacoes
                    .Include(t => t.Categoria)
                    .ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
