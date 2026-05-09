// O estado da tela

using System.ComponentModel;
using SistemaArquiteturaTrabalho.Models;

namespace SistemaArquiteturaTrabalho.MVVM
{
    public class ContadorViewModel : INotifyPropertyChanged
    {
        private ContadorModel _model = new ContadorModel();
        public string ValorExibicao => _model.Valor.ToString();

        public void Incrementar()
        {
            _model.Valor++;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ValorExibicao)));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}