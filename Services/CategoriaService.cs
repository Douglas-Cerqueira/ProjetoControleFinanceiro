using Microsoft.EntityFrameworkCore;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Repository;
using ProjetoControleFinanceiro.Services.Contracts;

namespace ProjetoControleFinanceiro.Services
{
    public class CategoriaService : ICategoriaService
    {
        public async Task AdicionarCategoria(CategoriasModel categoria)
        {
			try
			{
                using var context = new FinanceiroContext();

                context.Categorias.Add(categoria);
                await context.SaveChangesAsync();
            }
			catch (Exception ex)
			{

				throw;
			}
        }

        public async Task EditarCategoria(CategoriasModel categorias)
        {
            try
            {
                using var context = new FinanceiroContext();
                context.Categorias.Attach(categorias);
                context.Entry(categorias).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task ExcluirCategoria(CategoriasModel categorias)
        {
            try
            {
                using var context = new FinanceiroContext();
                context.Categorias.Remove(categorias);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<CategoriasModel>> ObterTodasCategorias()
        {
            try
            {
                using var context = new FinanceiroContext();

                var categorias = await context.Categorias
                    .AsNoTracking()
                    .ToListAsync();

                return categorias;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
