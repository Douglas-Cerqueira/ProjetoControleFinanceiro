using Microsoft.EntityFrameworkCore;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Repository;
using ProjetoControleFinanceiro.Views;

namespace ProjetoControleFinanceiro.ColetaInformacoes
{
    public class CategoriaColetaInformacoes
    {
        public List<CategoriasModel> ObterCategorias()
        {
            using var context = new FinanceiroContext();
            return context.Categorias
                      .AsNoTracking()
                      .ToList();
        }
    }
}
