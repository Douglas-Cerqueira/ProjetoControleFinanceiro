using ProjetoControleFinanceiro.Models;

namespace ProjetoControleFinanceiro.Services.Contracts
{
    public interface ICategoriaService
    {
        Task AdicionarCategoria(CategoriasModel categoria);
        Task<List<CategoriasModel>> ObterTodasCategorias();
        Task EditarCategoria(CategoriasModel categorias);
        Task ExcluirCategoria(CategoriasModel categorias);
    }
}
