using ProjetoBanco.Controler;
using ProjetoBanco.Model;
using ProjetoBanco.View;
using System.Data.SqlClient;

namespace ProjetoBanco
{
    public partial class frmPrincipal : Form
    {
        SqlConnection conexao = null;

        private Form formularioAtivo;

        public frmPrincipal()
        {
            this.conexao = Conexao.GetConexao();

            InitializeComponent();

            BotaoAtivo(btnHome);

            this.labelNomeUsuario.Text = UsuarioLogado.usuario.login;

            this.labelSaldo.Text = '$' + System.Convert.ToString(UsuarioLogado.usuario.saldo);
        }

        private void MostrarFormulario(Form formulario)
        {
            FecharFormularioAberto();

            formularioAtivo = formulario;
            formulario.TopLevel = false;
            panelForm.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        }
        private void FecharFormularioAberto()
        {
            if (formularioAtivo != null)
            {
                formularioAtivo.Close();
            }
        }
        private void BotaoAtivo(Button botaoFormularioPrincipal)
        {
            foreach (Control botao in panelPrincipal.Controls)
            {
                botao.ForeColor = Color.White;
            }

            botaoFormularioPrincipal.ForeColor = Color.Red;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            BotaoAtivo(btnHome);
            FecharFormularioAberto();
            this.labelSaldo.Text = '$' + System.Convert.ToString(UsuarioLogado.usuario.saldo);
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            BotaoAtivo(btnUsuarios);
            MostrarFormulario(new frmUsuarios(conexao));
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            BotaoAtivo(btnMovimentacoes);
            MostrarFormulario(new frmMovimentacoes(conexao));
        }

        private void btnInvestimentos_Click(object sender, EventArgs e)
        {
            BotaoAtivo(btnInvestimentos);
            MostrarFormulario(new frmInvesimentos(conexao));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
            Application.Exit();
        }
    }
}