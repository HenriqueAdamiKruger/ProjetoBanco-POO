using ProjetoBanco.Model;
using ProjetoBanco.View;

namespace ProjetoBanco
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Usuario usuarioLogado = null;

            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}