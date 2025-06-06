namespace ProjetoControleFinanceiro.Models
{
    public class TransacoesModel
    {
        public int IdTransacao { get; set; }
        public string NomeTransacao { get; set; }
        public double ValorTransacao { get; set; }
        public string DescricaoTransacao { get; set; }

        public int IdCategoria { get; set; }
        public CategoriasModel Categoria { get; set; }
    }
}
