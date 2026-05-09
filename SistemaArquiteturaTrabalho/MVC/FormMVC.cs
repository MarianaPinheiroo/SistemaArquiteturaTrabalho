// No MVC de Windows Forms simples, o formulário acaba agindo como View e Controller ao mesmo tempo.

using System;
using System.Windows.Forms;
using SistemaArquiteturaTrabalho.Models;

namespace SistemaArquiteturaTrabalho.MVC
{
    public partial class FormMVC : Form
    {
        private ContadorModel _model = new ContadorModel();
        private Button btn = new Button { Text = "MVC: +1", Left = 50, Top = 50, Width = 100 };
        private Label lbl = new Label { Text = "0", Left = 50, Top = 20 };

        public FormMVC()
        {
            Controls.Add(btn);
            Controls.Add(lbl);

            // No MVC, a View avisa o "Controller" (neste caso o próprio Form) 
            // e ele atualiza o Model e a tela manualmente.
            btn.Click += (s, e) => {
                _model.Valor++;
                lbl.Text = _model.Valor.ToString();
            };
        }
    }
}