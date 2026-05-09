

# 🚀 SistemaArquiteturaTrabalho - Padrões de Projeto (MVC, MVP, MVVM)

Este projeto foi desenvolvido como parte de um estudo prático sobre **Arquitetura de Software** no curso de Análise e Desenvolvimento de Sistemas (ADS). O objetivo principal é demonstrar a implementação funcional de três dos padrões de projeto mais utilizados no mercado: **MVC**, **MVP** e **MVVM**, utilizando C# e Windows Forms.

---

## 💡 A Ideia Principal

A proposta deste sistema é um "Contador Universal". Embora a funcionalidade seja simples (incrementar um número), a complexidade e o valor acadêmico residem na **separação de responsabilidades**.

Em vez de colocar todo o código dentro de um botão, o projeto distribui a lógica em camadas, permitindo que a interface (View) e os dados (Model) sejam independentes. Isso facilita a manutenção, o teste e a escalabilidade do software.

---

## 🏗️ Estrutura do Projeto e Funcionamento

O projeto está organizado em pastas, cada uma representando uma camada ou um padrão específico:

### 1. 📦 Models

Contém o `ContadorModel.cs`, que é a **fonte da verdade**.

* **Função:** Armazenar o estado bruto do dado (o valor atual do contador).
* **Regra:** Não conhece nenhuma interface gráfica; é puro dado.

### 2. 🧩 MVC (Model-View-Controller)

* **Arquivo:** `FormMVC.cs`
* **Como funciona:** O formulário atua como a View e o Controller. Ele recebe o evento do usuário, atualiza o Model e altera o texto da tela manualmente. É o padrão clássico e mais direto.

### 3. 🛡️ MVP (Model-View-Presenter)

* **Arquivos:** `IContadorView.cs`, `ContadorPresenter.cs`, `FormMVP.cs`
* **Como funciona:** Aqui a View é "burra". Ela apenas repassa o clique para o **Presenter**. O Presenter processa a lógica no Model e **comanda** a View (através de uma Interface) sobre o que ela deve exibir. Excelente para manter o código da tela limpo.

### 4. ⚡ MVVM (Model-View-ViewModel)

* **Arquivos:** `ContadorViewModel.cs`, `FormMVVM.cs`
* **Como funciona:** O padrão mais moderno. A **ViewModel** expõe um estado que a View "observa". Quando o dado muda, a ViewModel dispara um evento de notificação e a View se atualiza automaticamente. É focado em reatividade e desacoplamento total.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Plataforma:** .NET (Windows Forms)
* **Ambiente:** Visual Studio 2022
* **Versionamento:** Git & GitHub

---

## 🚀 Como Executar o Projeto

1. Clone o repositório.
2. Abra o arquivo `.sln` no Visual Studio.
3. No arquivo `Program.cs`, escolha qual padrão deseja testar descomentando a linha correspondente:
```csharp
// Application.Run(new MVC.FormMVC());
// Application.Run(new MVP.FormMVP());
Application.Run(new MVVM.FormMVVM());

```


4. Pressione `F5` ou clique em **Iniciar**.

---

## 🎓 Autor

Desenvolvido por **Mariana Pinheiro** – Estudante de ADS.
*Foco em Arquitetura de Software e Desenvolvimento .NET.*

