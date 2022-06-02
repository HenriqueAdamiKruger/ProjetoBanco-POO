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
    public partial class frmMovimentacoes : Form
    {
        SqlConnection conexao = null;

        public frmMovimentacoes(SqlConnection conexao)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            this.conexao = conexao;
            AtualizaTela();
        }

        private void AtualizaTela()
        {
            List<Movimentacao> lista = MovimentacaoDB.GetMovimentacoes(conexao);
            dataGridView1.DataSource = lista;
        }

        private void btnNovaMovimentacao_Click(object sender, EventArgs e)
        {
            frmNovaMovimentacao form = new frmNovaMovimentacao(conexao);
            form.ShowDialog();
            AtualizaTela();
        }
    }
}
