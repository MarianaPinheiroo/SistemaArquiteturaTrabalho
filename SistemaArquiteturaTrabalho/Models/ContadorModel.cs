// SistemaArquiteturaTrabalho\Models\ContadorModel.cs
// O Model é apenas o dado bruto. Ele não sabe que existe uma tela ou um botão.
namespace SistemaArquiteturaTrabalho.Models
{
    public class ContadorModel
    {
        // O Model apenas armazena o valor (Estado da aplicação)
        public int Valor { get; set; } = 0;
    }
}