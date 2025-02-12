using System.Windows.Forms;
using System;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double valorAtual = 0;
        private string operacao = "";
        private bool limparTexto = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoNumero_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = sender as Button;

            // Se o texto atual for "0" ou deve limpar a tela, insere o número
            if (textoResultado.Text == "0" || limparTexto)
            {
                textoResultado.Text = botaoPressionado.Text;
                limparTexto = false;
            }
            else
            {
                textoResultado.Text += botaoPressionado.Text;
            }
        }

        private void BotaoApagar_Click(object sender, EventArgs e)
        {
            textoResultado.Text = "0";
            valorAtual = 0;
            operacao = "";
        }

        private void BotaoPonto_Click(object sender, EventArgs e)
        {
            // Garante que o ponto só seja inserido uma vez
            if (!textoResultado.Text.Contains("."))
            {
                textoResultado.Text += ".";
            }
        }

        private void BotaoOperacao_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = sender as Button;

            // Converte o valor atual para double, se possível, e realiza a operação
            if (double.TryParse(textoResultado.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double valorDigitado))
            {
                if (valorAtual != 0)
                {
                    BotaoIgual_Click(sender, e); // Finaliza a operação anterior
                }
                valorAtual = valorDigitado;
                operacao = botaoPressionado.Text;
                limparTexto = true;
            }
            else
            {
                // Se o valor na tela não for um número válido
                MessageBox.Show("Erro: Entrada inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textoResultado.Text = "0";
            }
        }

        private void BotaoIgual_Click(object sender, EventArgs e)
        {
            // Converte o valor de resultado para double e calcula
            if (double.TryParse(textoResultado.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double segundoValor))
            {
                switch (operacao)
                {
                    case "+":
                        valorAtual += segundoValor;
                        break;
                    case "-":
                        valorAtual -= segundoValor;
                        break;
                    case "×":
                        valorAtual *= segundoValor;
                        break;
                    case "÷":
                        if (segundoValor != 0)
                        {
                            valorAtual /= segundoValor;
                        }
                        else
                        {
                            MessageBox.Show("Erro: Divisão por zero não é permitida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textoResultado.Text = "0";
                            return;
                        }
                        break;
                    default:
                        break;
                }

                // Atualiza a tela com o resultado da operação
                textoResultado.Text = valorAtual.ToString(CultureInfo.InvariantCulture);
                operacao = ""; // Reseta a operação
            }
            else
            {
                MessageBox.Show("Erro: Entrada inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textoResultado.Text = "0";
            }
        }
    }
}
