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
    public partial class frmNovaInvestimento : Form
    {
        SqlConnection conexao = null;

        const int Entrada = 1;
        const int Saida = 2;

        public frmNovaInvestimento(SqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            double valor = 0;

            textBoxValor.Text = textBoxValor.Text.Replace('.', ',');

            try
            {
                valor = System.Convert.ToDouble(textBoxValor.Text);
            }
            catch 
            {
                MessageBox.Show(null,
                                "Digite um valor válido",
                                "Erro ao processar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (valor <= 0)
            {
                MessageBox.Show(null,
                                "O campo valor é obrigatório",
                                "Campo obrigatório não prenchido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Investimento investimento = new Investimento(0, valor);
            bool retorno = InvestimentoDB.SetInsereInvestimento(investimento, conexao);
            if (retorno)
            {
                MessageBox.Show("Sucesso, investimento incluída.");
                Close();
            }
            else
            {
                MessageBox.Show("Erro, investimento não incluída.");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
