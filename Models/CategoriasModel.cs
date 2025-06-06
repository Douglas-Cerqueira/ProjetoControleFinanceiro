using System.ComponentModel.DataAnnotations;

namespace ProjetoControleFinanceiro.Models
{
    public class CategoriasModel
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        public List<TransacoesModel> Transacoes { get; set; }
    }
}
