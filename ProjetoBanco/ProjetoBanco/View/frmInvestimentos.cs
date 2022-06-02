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
    public partial class frmInvesimentos : Form
    {
        SqlConnection conexao = null;

        public frmInvesimentos(SqlConnection conexao)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            this.conexao = conexao;
            AtualizaTela();
        }

        private void AtualizaTela()
        {
            List<Investimento> lista = InvestimentoDB.GetInvestimentos(conexao);
            dataGridView1.DataSource = lista;
        }

        private void btnNovoInvestimento_Click(object sender, EventArgs e)
        {
            frmNovaInvestimento form = new frmNovaInvestimento(conexao);
            form.ShowDialog();
            AtualizaTela();
        }

        private void btnExcluirInvestimento_Click(object sender, EventArgs e)
        {
            try
            {
                Investimento investimento = (Investimento)dataGridView1.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show(
                            null
                            , $"Deseja excluir o investimento {investimento.codigo} - {investimento.valorInvestido}?"
                            , "Investimento"
                            , MessageBoxButtons.OKCancel
                            , MessageBoxIcon.Question
                            );
                if (result == DialogResult.OK)
                {
                    bool retorno = InvestimentoDB.SetExcluirInvestimento(investimento.codigo, conexao);
                    if (retorno)
                    {
                        MessageBox.Show("Sucesso, investimento excluído!");
                        AtualizaTela();
                    }
                    else
                    {
                        MessageBox.Show("Erro, investimento não excluído!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não existe nenhum investimento para remover");
            }
        }
    }
}
