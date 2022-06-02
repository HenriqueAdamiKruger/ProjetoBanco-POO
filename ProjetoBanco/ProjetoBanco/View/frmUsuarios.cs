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
    public partial class frmUsuarios : Form
    {
        SqlConnection conexao = null;

        public frmUsuarios(SqlConnection conexao)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            this.conexao = conexao;
            AtualizaTela();
        }

        private void AtualizaTela()
        {
            List<Usuario> lista = UsuarioDB.GetUsuarios(conexao);
            dataGridView1.DataSource = lista;
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmNovoUsuario form = new frmNovoUsuario(conexao);
            form.ShowDialog();
            AtualizaTela();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            try
            { 
                Usuario usuario = (Usuario)dataGridView1.CurrentRow.DataBoundItem;

           

                DialogResult result = MessageBox.Show(null, 
                                                      $"Deseja excluir o usuário {usuario.codigo} - {usuario.login}?",
                                                      "Usuário",
                                                      MessageBoxButtons.OKCancel,
                                                      MessageBoxIcon.Question );
                if (result == DialogResult.OK)
                {
                    bool retorno = UsuarioDB.SetExcluirUsuario(usuario.codigo, conexao);
                    if (retorno)
                    {
                        MessageBox.Show("Sucesso, usuário excluído!");
                        AtualizaTela();
                    }
                    else
                    {
                        MessageBox.Show("Erro, usuário não excluído!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não existe usuários a serem excluidos");
            }

        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
                frmAlterarUsuario form = new frmAlterarUsuario(conexao, usuario);
                form.ShowDialog();
                AtualizaTela();
            } catch
            {
                MessageBox.Show("Não existe usuários a serem alterados");
            }
            
        }
    }
}
