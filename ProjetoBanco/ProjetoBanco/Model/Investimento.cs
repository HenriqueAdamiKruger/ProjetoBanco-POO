using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Model
{
    public class Investimento
    {
        public int codigo { get; set; }
        public int usuario { get; set; }
        public double valorInvestido { get; set; }
        public double valorRetorno { get; set; }
        public string observacao { get; set; }

        public Investimento()
        {

        }

        public Investimento(int codigo, double valorInvestido)
        {
            this.codigo = codigo;
            this.valorInvestido = valorInvestido;
        }
    }
}
