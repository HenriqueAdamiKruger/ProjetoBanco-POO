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
    public partial class frmNovaMovimentacao : Form
    {
        SqlConnection conexao = null;

        public frmNovaMovimentacao(SqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;

            CarregarTipoMovimentacao();
        }

        private void CarregarTipoMovimentacao()
        {
            Dictionary<String, int> Tipos = new Dictionary<String, int>();

            Tipos.Add("Entrada", 1);
            Tipos.Add("Saída", 2);

            comboBox1.DataSource = new BindingSource(Tipos, null);
            comboBox1.ValueMember = "Key";
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            double valor = 0;
            int tipo = comboBox1.SelectedIndex + 1;

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

            Movimentacao movimentacao = new Movimentacao(0, valor, tipo);
            bool retorno = MovimentacaoDB.SetInsereMovimentacao(movimentacao, conexao);
            if (retorno)
            {
                MessageBox.Show("Sucesso, movimentação incluída.");
                Close();
            }
            else
            {
                MessageBox.Show("Erro, movimentação não incluída.");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
