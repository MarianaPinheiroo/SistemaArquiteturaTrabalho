using System;
using System.Windows.Forms;

namespace SistemaArquiteturaTrabalho.MVVM
{
    public partial class FormMVVM : Form
    {
        private ContadorViewModel _vm = new ContadorViewModel();
        private Label lbl = new Label { Left = 50, Top = 20 };
        private Button btn = new Button { Text = "MVVM: +1", Left = 50, Top = 50, Width = 100 };

        public FormMVVM()
        {
            Controls.Add(lbl); Controls.Add(btn);
            lbl.Text = _vm.ValorExibicao;
            _vm.PropertyChanged += (s, e) => lbl.Text = _vm.ValorExibicao;
            btn.Click += (s, e) => _vm.Incrementar();
        }
    }
}