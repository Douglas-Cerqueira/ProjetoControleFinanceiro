using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoControleFinanceiro.Models
{
    public class TransacoesModel
    {
        [Key]
        public int IdTransacao { get; set; }
        public string NomeTransacao { get; set; }
        public double ValorTransacao { get; set; }
        public string DescricaoTransacao { get; set; }
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        public CategoriasModel Categoria { get; set; }
    }
}
