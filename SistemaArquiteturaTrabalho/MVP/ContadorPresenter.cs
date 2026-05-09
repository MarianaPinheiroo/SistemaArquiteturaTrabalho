// mais conhecido como o cerebro

using SistemaArquiteturaTrabalho.Models;

namespace SistemaArquiteturaTrabalho.MVP
{
    public class ContadorPresenter
    {
        private readonly IContadorView _view;
        private readonly ContadorModel _model = new ContadorModel();

        public ContadorPresenter(IContadorView view) { _view = view; }

        public void Incrementar()
        {
            _model.Valor++;
            _view.ValorTexto = _model.Valor.ToString();
        }
    }
}