using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Model
{
    public class Usuario
    {
        public int codigo { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public double saldo { get; set; }

        public Usuario()
        {

        }

        public Usuario(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }

        public Usuario(int codigo, string login, string senha, double saldo)
        {
            this.codigo = codigo;
            this.login = login;
            this.senha = senha;
            this.saldo = saldo;
        }
    }
}
