namespace Calculadora
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textoResultado;
        private System.Windows.Forms.Button botaoApagar;
        private System.Windows.Forms.Button botao0;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.Button botao9;
        private System.Windows.Forms.Button botaoSoma;
        private System.Windows.Forms.Button botaoSubtracao;
        private System.Windows.Forms.Button botaoMultiplicacao;
        private System.Windows.Forms.Button botaoDivisao;
        private System.Windows.Forms.Button botaoIgual;
        private System.Windows.Forms.Button botaoPonto;

        /// <summary>
        /// Limpa os recursos em uso.
        /// </summary>
        /// <param name="disposing">Se verdadeiro, descarta os recursos gerenciados.</param>
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
            this.textoResultado = new System.Windows.Forms.TextBox();
            this.botaoApagar = new System.Windows.Forms.Button();
            this.botao0 = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.botao4 = new System.Windows.Forms.Button();
            this.botao5 = new System.Windows.Forms.Button();
            this.botao6 = new System.Windows.Forms.Button();
            this.botao7 = new System.Windows.Forms.Button();
            this.botao8 = new System.Windows.Forms.Button();
            this.botao9 = new System.Windows.Forms.Button();
            this.botaoSoma = new System.Windows.Forms.Button();
            this.botaoSubtracao = new System.Windows.Forms.Button();
            this.botaoMultiplicacao = new System.Windows.Forms.Button();
            this.botaoDivisao = new System.Windows.Forms.Button();
            this.botaoIgual = new System.Windows.Forms.Button();
            this.botaoPonto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoResultado
            // 
            this.textoResultado.BackColor = System.Drawing.SystemColors.Control;
            this.textoResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textoResultado.Location = new System.Drawing.Point(10, 10);
            this.textoResultado.Name = "textoResultado";
            this.textoResultado.Size = new System.Drawing.Size(226, 31);
            this.textoResultado.TabIndex = 0;
            this.textoResultado.Text = "0";
            this.textoResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // botaoApagar
            // 
            this.botaoApagar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoApagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botaoApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoApagar.Location = new System.Drawing.Point(10, 236);
            this.botaoApagar.Name = "botaoApagar";
            this.botaoApagar.Size = new System.Drawing.Size(50, 50);
            this.botaoApagar.TabIndex = 11;
            this.botaoApagar.Text = "C";
            this.botaoApagar.UseVisualStyleBackColor = false;
            this.botaoApagar.Click += new System.EventHandler(this.BotaoApagar_Click);
            // 
            // botao0
            // 
            this.botao0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao0.Location = new System.Drawing.Point(66, 236);
            this.botao0.Name = "botao0";
            this.botao0.Size = new System.Drawing.Size(50, 50);
            this.botao0.TabIndex = 1;
            this.botao0.Text = "0";
            this.botao0.UseVisualStyleBackColor = false;
            this.botao0.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.Location = new System.Drawing.Point(10, 180);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(50, 50);
            this.botao1.TabIndex = 2;
            this.botao1.Text = "1";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.Location = new System.Drawing.Point(66, 180);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(50, 50);
            this.botao2.TabIndex = 3;
            this.botao2.Text = "2";
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao3
            // 
            this.botao3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao3.Location = new System.Drawing.Point(122, 180);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(50, 50);
            this.botao3.TabIndex = 4;
            this.botao3.Text = "3";
            this.botao3.UseVisualStyleBackColor = false;
            this.botao3.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao4
            // 
            this.botao4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao4.Location = new System.Drawing.Point(10, 120);
            this.botao4.Name = "botao4";
            this.botao4.Size = new System.Drawing.Size(50, 50);
            this.botao4.TabIndex = 5;
            this.botao4.Text = "4";
            this.botao4.UseVisualStyleBackColor = false;
            this.botao4.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao5
            // 
            this.botao5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao5.Location = new System.Drawing.Point(66, 120);
            this.botao5.Name = "botao5";
            this.botao5.Size = new System.Drawing.Size(50, 50);
            this.botao5.TabIndex = 6;
            this.botao5.Text = "5";
            this.botao5.UseVisualStyleBackColor = false;
            this.botao5.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao6
            // 
            this.botao6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao6.Location = new System.Drawing.Point(122, 120);
            this.botao6.Name = "botao6";
            this.botao6.Size = new System.Drawing.Size(50, 50);
            this.botao6.TabIndex = 7;
            this.botao6.Text = "6";
            this.botao6.UseVisualStyleBackColor = false;
            this.botao6.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao7
            // 
            this.botao7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao7.Location = new System.Drawing.Point(10, 60);
            this.botao7.Name = "botao7";
            this.botao7.Size = new System.Drawing.Size(50, 50);
            this.botao7.TabIndex = 8;
            this.botao7.Text = "7";
            this.botao7.UseVisualStyleBackColor = false;
            this.botao7.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao8
            // 
            this.botao8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao8.Location = new System.Drawing.Point(66, 60);
            this.botao8.Name = "botao8";
            this.botao8.Size = new System.Drawing.Size(50, 50);
            this.botao8.TabIndex = 9;
            this.botao8.Text = "8";
            this.botao8.UseVisualStyleBackColor = false;
            this.botao8.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botao9
            // 
            this.botao9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botao9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botao9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao9.Location = new System.Drawing.Point(122, 60);
            this.botao9.Name = "botao9";
            this.botao9.Size = new System.Drawing.Size(50, 50);
            this.botao9.TabIndex = 10;
            this.botao9.Text = "9";
            this.botao9.UseVisualStyleBackColor = false;
            this.botao9.Click += new System.EventHandler(this.BotaoNumero_Click);
            // 
            // botaoSoma
            // 
            this.botaoSoma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoSoma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botaoSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSoma.Location = new System.Drawing.Point(186, 60);
            this.botaoSoma.Name = "botaoSoma";
            this.botaoSoma.Size = new System.Drawing.Size(50, 50);
            this.botaoSoma.TabIndex = 12;
            this.botaoSoma.Text = "+";
            this.botaoSoma.UseVisualStyleBackColor = false;
            this.botaoSoma.Click += new System.EventHandler(this.BotaoOperacao_Click);
            // 
            // botaoSubtracao
            // 
            this.botaoSubtracao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoSubtracao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botaoSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSubtracao.Location = new System.Drawing.Point(186, 120);
            this.botaoSubtracao.Name = "botaoSubtracao";
            this.botaoSubtracao.Size = new System.Drawing.Size(50, 50);
            this.botaoSubtracao.TabIndex = 13;
            this.botaoSubtracao.Text = "-";
            this.botaoSubtracao.UseVisualStyleBackColor = false;
            this.botaoSubtracao.Click += new System.EventHandler(this.BotaoOperacao_Click);
            // 
            // botaoMultiplicacao
            // 
            this.botaoMultiplicacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoMultiplicacao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botaoMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMultiplicacao.Location = new System.Drawing.Point(186, 180);
            this.botaoMultiplicacao.Name = "botaoMultiplicacao";
            this.botaoMultiplicacao.Size = new System.Drawing.Size(50, 50);
            this.botaoMultiplicacao.TabIndex = 14;
            this.botaoMultiplicacao.Text = "×";
            this.botaoMultiplicacao.UseVisualStyleBackColor = false;
            this.botaoMultiplicacao.Click += new System.EventHandler(this.BotaoOperacao_Click);
            // 
            // botaoDivisao
            // 
            this.botaoDivisao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoDivisao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botaoDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDivisao.Location = new System.Drawing.Point(186, 236);
            this.botaoDivisao.Name = "botaoDivisao";
            this.botaoDivisao.Size = new System.Drawing.Size(50, 50);
            this.botaoDivisao.TabIndex = 15;
            this.botaoDivisao.Text = "÷";
            this.botaoDivisao.UseVisualStyleBackColor = false;
            this.botaoDivisao.Click += new System.EventHandler(this.BotaoOperacao_Click);
            // 
            // botaoIgual
            // 
            this.botaoIgual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoIgual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botaoIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoIgual.Location = new System.Drawing.Point(186, 292);
            this.botaoIgual.Name = "botaoIgual";
            this.botaoIgual.Size = new System.Drawing.Size(50, 50);
            this.botaoIgual.TabIndex = 16;
            this.botaoIgual.Text = "=";
            this.botaoIgual.UseVisualStyleBackColor = false;
            this.botaoIgual.Click += new System.EventHandler(this.BotaoIgual_Click);
            // 
            // botaoPonto
            // 
            this.botaoPonto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoPonto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botaoPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPonto.Location = new System.Drawing.Point(122, 236);
            this.botaoPonto.Name = "botaoPonto";
            this.botaoPonto.Size = new System.Drawing.Size(50, 50);
            this.botaoPonto.TabIndex = 17;
            this.botaoPonto.Text = ".";
            this.botaoPonto.UseVisualStyleBackColor = false;
            this.botaoPonto.Click += new System.EventHandler(this.BotaoPonto_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(245, 352);
            this.Controls.Add(this.botaoApagar);
            this.Controls.Add(this.botao0);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao4);
            this.Controls.Add(this.botao5);
            this.Controls.Add(this.botao6);
            this.Controls.Add(this.botao7);
            this.Controls.Add(this.botao8);
            this.Controls.Add(this.botao9);
            this.Controls.Add(this.textoResultado);
            this.Controls.Add(this.botaoSoma);
            this.Controls.Add(this.botaoSubtracao);
            this.Controls.Add(this.botaoMultiplicacao);
            this.Controls.Add(this.botaoDivisao);
            this.Controls.Add(this.botaoIgual);
            this.Controls.Add(this.botaoPonto);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
