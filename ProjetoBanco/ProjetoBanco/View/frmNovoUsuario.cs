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
    public partial class frmNovoUsuario : Form
    {
        SqlConnection conexao = null;

        public frmNovoUsuario(SqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string senha = textBoxSenha.Text;

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

            Usuario usuario = new Usuario(login, senha);
            bool retorno = UsuarioDB.SetInsereUsuario(usuario, conexao);
            if (retorno)
            {
                MessageBox.Show("Sucesso, usuario incluído.");
                Close();
            }
            else
            {
                MessageBox.Show("Erro, usuario não incluído.");
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
