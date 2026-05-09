using System;
using System.Windows.Forms;

namespace SistemaArquiteturaTrabalho
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Escolha qual padrão testar descomentando uma linha por vez:
            // Application.Run(new MVC.FormMVC());
            // Application.Run(new MVP.FormMVP());
            Application.Run(new MVVM.FormMVVM());
        }
    }
}