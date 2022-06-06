using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Controler
{
    public class Conexao
    {
        public Conexao()
        {

        }
        public static SqlConnection GetConexao()
        {
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(@"Data Source=IKE;Initial Catalog=banco;User ID=sa;Password=123456ike");
                conexao.Open();
                Console.WriteLine("Conexão OK!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao conectar banco: " + e.Message);
            }

            return conexao;
        }

        public static void SetFechaConexao(SqlConnection conexao)
        {
            if (conexao != null)
            {
                try
                {
                    conexao.Close();
                    Console.WriteLine("Fechamento OK!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao fechar conexão banco: " + e.Message);
                }
            }
        }
    }
}
