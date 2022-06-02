using ProjetoBanco.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Controler
{
    internal class InvestimentoDB
    {
        public static List<Investimento> GetInvestimentos(SqlConnection conexao)
        {
            List<Investimento> lista = new List<Investimento>();
            try
            {
                string sql = "select * from investimento";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int codigo = int.Parse(dr["codigo"].ToString());
                    double valorinvestido = System.Convert.ToDouble(dr["valorinvestido"].ToString());
                    Investimento investimento = new Investimento(codigo, valorinvestido);
                    lista.Add(investimento);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }
            return lista;
        }

        public static bool SetInsereInvestimento(Investimento investimento, SqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string sql = "insert into investimento (valorinvestido) values(@valorinvestido)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.Add("@valorinvestido", System.Data.SqlDbType.Decimal).Value = investimento.valorInvestido;
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

        public static bool SetExcluirInvestimento(int codigo, SqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string sql = "delete from investimento where codigo = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codigo;
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
