using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleFinanceiro.Enums
{
    public enum StatusEnum  
    {
        Entrada = 1, 
        Saida = 2, 
        Divida = 3 
    }
    public enum FormaPagamento
    {
        Pix = 1,
        Credito = 2,
        Debito = 3,
        Boleto = 4,
        Dinheiro = 5
    }
}

