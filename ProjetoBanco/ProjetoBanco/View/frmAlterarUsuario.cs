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
    public partial class frmAlterarUsuario : Form
    {
        SqlConnection conexao = null;
        Usuario usuario = null;

        public frmAlterarUsuario(SqlConnection conexao, Usuario usuario)
        {
            InitializeComponent();
            this.conexao = conexao;
            this.usuario = usuario;
            AtualizaTela();
        }

        private void AtualizaTela()
        {
            textBoxLogin.Text = usuario.login;
            textBoxSenha.Text = usuario.senha;
            textBoxCodigo.Text = usuario.codigo.ToString();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string senha = textBoxSenha.Text;
            int codigo = System.Convert.ToInt32(textBoxCodigo.Text);

            if (login == "")
            {
                MessageBox.Show(null,
                                "O campo login é obrigatório",
                                "Campo obrigatório não prenchido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (senha == "")
            {
                MessageBox.Show(null,
                                "O campo senha é obrigatório",
                                "Campo obrigatório não prenchido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = new Usuario(codigo, login, senha, 0.00);
            bool retorno = UsuarioDB.SetAlteraUsuario(usuario, conexao);
            if (retorno)
            {
                MessageBox.Show("Sucesso, usuário alterado.");
                Close();
            }
            else
            {
                MessageBox.Show("Erro, usuário não alterado.");
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
