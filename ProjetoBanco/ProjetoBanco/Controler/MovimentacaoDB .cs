using ProjetoBanco.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Controler
{
    internal class MovimentacaoDB
    {
        public static List<Movimentacao> GetMovimentacoes(SqlConnection conexao)
        {
            List<Movimentacao> lista = new List<Movimentacao>();
            try
            {
                string sql = "select * from movimentacao";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int codigo = int.Parse(dr["codigo"].ToString());
                    double valor = System.Convert.ToDouble(dr["valor"].ToString());
                    int tipo = int.Parse(dr["tipo"].ToString());
                    Movimentacao movimentacao = new Movimentacao(codigo, valor, tipo);
                    lista.Add(movimentacao);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }
            return lista;
        }

        public static bool SetInsereMovimentacao(Movimentacao movimentacao, SqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string sql = "insert into movimentacao(valor, tipo) values(@valor, @tipo)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.Add("@valor", System.Data.SqlDbType.Decimal).Value = movimentacao.valor;
                cmd.Parameters.Add("@tipo", System.Data.SqlDbType.Int).Value = movimentacao.tipo;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }
            return retorno;
        }
    }
}
