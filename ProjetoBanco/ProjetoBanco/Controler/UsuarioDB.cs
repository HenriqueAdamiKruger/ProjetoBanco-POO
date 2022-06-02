using ProjetoBanco.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Controler
{
    internal class UsuarioDB
    {
        public static List<Usuario> GetUsuarios(SqlConnection conexao)
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                string sql = "select * from usuario";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int codigo = int.Parse(dr["codigo"].ToString());
                    string login = dr["login"].ToString();
                    string senha = (string)dr["senha"];
                    double saldo = System.Convert.ToDouble(dr["saldo"].ToString());
                    Usuario usuario = new Usuario(codigo, login, senha, saldo);
                    lista.Add(usuario);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }
            return lista;
        }

        public static bool SetInsereUsuario(Usuario usuario, SqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string sql = "insert into usuario(login,senha, saldo) values(@login,@senha,0)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = usuario.login;
                cmd.Parameters.Add("@senha", System.Data.SqlDbType.VarChar).Value = usuario.senha;
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

        public static bool SetAlteraUsuario(Usuario usuario, SqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string sql = "update usuario set login = @login, senha = @senha, saldo = @saldo where codigo = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = usuario.codigo;
                cmd.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = usuario.login;
                cmd.Parameters.Add("@senha", System.Data.SqlDbType.VarChar).Value = usuario.senha;
                cmd.Parameters.Add("@saldo", System.Data.SqlDbType.Decimal).Value = usuario.saldo;
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

        public static bool SetExcluirUsuario(int codigo, SqlConnection conexao)
        {
            bool retorno = false;
            try
            {
                string sql = "delete from usuario where codigo = @codigo";
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
