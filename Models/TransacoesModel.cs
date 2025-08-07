using ProjetoControleFinanceiro.Enums;

namespace ProjetoControleFinanceiro.Models
{
    public class TransacoesModel
    {
        public int IdTransacao { get; set; }
        public DateTime DataTransacao { get; set; }
        public StatusEnum Status { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public decimal ValorTransacao { get; set; }
        public string DescricaoTransacao { get; set; }

        public int IdCategoria { get; set; }
        public CategoriasModel Categoria { get; set; }
    }
}
