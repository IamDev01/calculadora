using System;
using System.Globalization;
using System.Windows.Forms;

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

            if (txtResultado.Text == "0" || limparTexto)
            {
                txtResultado.Text = botaoPressionado.Text;
                limparTexto = false;
            }
            else
            {
                txtResultado.Text += botaoPressionado.Text;
            }
        }

        private void BotaoApagar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            valorAtual = 0;
            operacao = "";
        }

        private void BotaoPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void BotaoOperacao_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = sender as Button;

            if (double.TryParse(txtResultado.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double valorDigitado))
            {
                if (valorAtual != 0)
                {
                    BotaoIgual_Click(sender, e);
                }
                valorAtual = valorDigitado;
                operacao = botaoPressionado.Text;
                limparTexto = true;
            }
            else
            {
                MessageBox.Show("Erro: Entrada inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "0";
            }
        }

        private void BotaoIgual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResultado.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double segundoValor))
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
                            txtResultado.Text = "0";
                            return;
                        }
                        break;
                    default:
                        break;
                }
                txtResultado.Text = valorAtual.ToString(CultureInfo.InvariantCulture);
                operacao = "";
            }
            else
            {
                MessageBox.Show("Erro: Entrada inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "0";
            }
        }
    }
}
