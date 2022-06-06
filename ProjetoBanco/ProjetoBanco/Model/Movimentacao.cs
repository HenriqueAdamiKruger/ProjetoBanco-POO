using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Model
{
    public class Movimentacao
    {
        public int codigo { get; set; }
        public int usuario { get; set; }    
        public double valor { get; set; }        
        public int tipo { get; set; }
        public string observacao { get; set; }

        public Movimentacao()
        {

        }

        public Movimentacao(int codigo, double valor, int tipo)
        { 
            this.codigo = codigo;
            this.valor = valor;
            this.tipo = tipo;
        }
    }
}
