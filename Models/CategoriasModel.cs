namespace ProjetoControleFinanceiro.Models
{
    public class CategoriasModel
    {
        public int IdCategoria { get; set; }
        public string Nome { get; set; }

        public List<TransacoesModel> Transacoes { get; set; }
    }
}
