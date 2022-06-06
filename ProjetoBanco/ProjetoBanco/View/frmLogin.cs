using ProjetoBanco.Controler;
using ProjetoBanco.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBanco.View
{
    public partial class frmLogin : Form
    {
        SqlConnection conexao = null;

        Usuario usuarioLogado = null;
        public frmLogin()
        {
            InitializeComponent();

            conexao = Conexao.GetConexao();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            Usuario usuario = new Usuario(login, senha);

            List<Usuario> listaUsuarios = UsuarioDB.GetUsuarios(conexao);

            bool usarioEncontrado = false;

            foreach (Usuario user in listaUsuarios)
            {
                if ((user.login == login) & (user.senha == senha)) {
                    usarioEncontrado = true;
                    usuario.codigo = user.codigo;
                    usuario.saldo = user.saldo;
                }
            }

            if (!usarioEncontrado)
            {
                MessageBox.Show(null,
                                "Login ou senha inválidos, tente novamente",
                                "Usuário inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } 
            else
            {
                UsuarioLogado.usuario = usuario;

                Form formPrincipal = new frmPrincipal();
                formPrincipal.TopLevel = true;
                formPrincipal.BringToFront();
                formPrincipal.Show();

                this.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formNovoUsuario = new frmNovoUsuario(conexao);

            formNovoUsuario.TopLevel = true;
            formNovoUsuario.BringToFront();
            formNovoUsuario.Show();
        }
    }
}
