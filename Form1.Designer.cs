namespace Calculadora
{
    partial class Form1
    {
        // 1. Padronização de nomes usando notação húngara para controles
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button[] numberButtons = new System.Windows.Forms.Button[10];
        private System.Windows.Forms.Button[] operatorButtons = new System.Windows.Forms.Button[4];

        // 2. Constantes para configurações de layout
        private const int ButtonSize = 50;
        private const int Spacing = 5;
        private const int DisplayHeight = 40;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // 3. Configuração inicial do formulário
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // 4. Configuração do display
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtResultado.Location = new System.Drawing.Point(Spacing, Spacing);
            this.txtResultado.Size = new System.Drawing.Size(3 * ButtonSize + 2 * Spacing, DisplayHeight);
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.Text = "0";

            // 5. Criação dos botões numéricos
            for (int i = 0; i < 10; i++)
            {
                numberButtons[i] = CreateNumberButton(i);
            }

            // 6. Botões de operação
            string[] operators = { "+", "-", "×", "÷" };
            for (int i = 0; i < operators.Length; i++)
            {
                operatorButtons[i] = CreateOperatorButton(operators[i], i);
            }

            // 7. Botões especiais
            this.btnClear = CreateSpecialButton("C", 0, 4);
            this.btnDecimal = CreateSpecialButton(".", 2, 4);
            this.btnEquals = CreateSpecialButton("=", 3, 4);

            // 8. Configuração final do formulário
            this.ClientSize = new System.Drawing.Size(
                width: 4 * ButtonSize + 5 * Spacing,
                height: 5 * ButtonSize + 6 * Spacing
            );

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                txtResultado,
                btnClear,
                btnDecimal,
                btnEquals
            });
            this.Controls.AddRange(numberButtons);
            this.Controls.AddRange(operatorButtons);

            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // 9. Método factory para botões numéricos
        private System.Windows.Forms.Button CreateNumberButton(int number)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Text = number.ToString();
            btn.Size = new System.Drawing.Size(ButtonSize, ButtonSize);
            btn.Location = GetNumberPosition(number);
            btn.Click += BotaoNumero_Click;
            return btn;
        }

        // 10. Método factory para operadores
        private System.Windows.Forms.Button CreateOperatorButton(string text, int index)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Text = text;
            btn.Size = new System.Drawing.Size(ButtonSize, ButtonSize);
            btn.Location = new System.Drawing.Point(
                x: 3 * (ButtonSize + Spacing) + Spacing,
                y: (index + 1) * (ButtonSize + Spacing) + Spacing
            );
            btn.Click += BotaoOperacao_Click;
            return btn;
        }

        // 11. Método factory para botões especiais
        private System.Windows.Forms.Button CreateSpecialButton(string text, int column, int row)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Text = text;
            btn.Size = new System.Drawing.Size(ButtonSize, ButtonSize);
            btn.Location = new System.Drawing.Point(
                x: column * (ButtonSize + Spacing) + Spacing,
                y: row * (ButtonSize + Spacing) + Spacing
            );

            if (text == "C") btn.Click += BotaoApagar_Click;
            if (text == ".") btn.Click += BotaoPonto_Click;
            if (text == "=") btn.Click += BotaoIgual_Click;

            return btn;
        }

        // 12. Lógica de posicionamento dos números
        private System.Drawing.Point GetNumberPosition(int number)
        {
            if (number == 0)
                return new System.Drawing.Point(Spacing, 4 * (ButtonSize + Spacing) + Spacing);

            return new System.Drawing.Point(
                x: ((number - 1) % 3) * (ButtonSize + Spacing) + Spacing,
                y: ((number - 1) / 3 + 1) * (ButtonSize + Spacing) + Spacing
            );
        }
    }
}