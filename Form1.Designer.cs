namespace Quiz
{
    partial class QuizAritmetico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tempoRestanteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ElementoSomaEsquerda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ElementoSomaDireita = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.NumericUpDown();
            this.botaoIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.diferenca = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.produto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ElementoMultiDireita = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ElementoMultiEsquerda = new System.Windows.Forms.Label();
            this.divisao = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.ElementoDiviDireita = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ElementoDiviEsquerda = new System.Windows.Forms.Label();
            this.ElementoSubEsquerda = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ElementoSubDireita = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.soma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferenca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisao)).BeginInit();
            this.SuspendLayout();
            // 
            // tempoRestanteLabel
            // 
            this.tempoRestanteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempoRestanteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoRestanteLabel.Location = new System.Drawing.Point(272, 9);
            this.tempoRestanteLabel.Name = "tempoRestanteLabel";
            this.tempoRestanteLabel.Size = new System.Drawing.Size(200, 30);
            this.tempoRestanteLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo Restante";
            // 
            // ElementoSomaEsquerda
            // 
            this.ElementoSomaEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementoSomaEsquerda.Location = new System.Drawing.Point(60, 50);
            this.ElementoSomaEsquerda.Name = "ElementoSomaEsquerda";
            this.ElementoSomaEsquerda.Size = new System.Drawing.Size(60, 50);
            this.ElementoSomaEsquerda.TabIndex = 2;
            this.ElementoSomaEsquerda.Text = "?";
            this.ElementoSomaEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementoSomaDireita
            // 
            this.ElementoSomaDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementoSomaDireita.Location = new System.Drawing.Point(192, 50);
            this.ElementoSomaDireita.Name = "ElementoSomaDireita";
            this.ElementoSomaDireita.Size = new System.Drawing.Size(60, 50);
            this.ElementoSomaDireita.TabIndex = 4;
            this.ElementoSomaDireita.Text = "?";
            this.ElementoSomaDireita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soma
            // 
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(324, 59);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(100, 35);
            this.soma.TabIndex = 2;
            this.soma.Enter += new System.EventHandler(this.resposta_Enter);
            // 
            // botaoIniciar
            // 
            this.botaoIniciar.AutoSize = true;
            this.botaoIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoIniciar.Location = new System.Drawing.Point(189, 315);
            this.botaoIniciar.Name = "botaoIniciar";
            this.botaoIniciar.Size = new System.Drawing.Size(129, 34);
            this.botaoIniciar.TabIndex = 1;
            this.botaoIniciar.Text = "Iniciar o Quiz";
            this.botaoIniciar.UseVisualStyleBackColor = true;
            this.botaoIniciar.Click += new System.EventHandler(this.botaoIniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // diferenca
            // 
            this.diferenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferenca.Location = new System.Drawing.Point(324, 122);
            this.diferenca.Name = "diferenca";
            this.diferenca.Size = new System.Drawing.Size(100, 35);
            this.diferenca.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "+";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 7;
            this.label7.Text = "?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // produto
            // 
            this.produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto.Location = new System.Drawing.Point(324, 175);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(100, 35);
            this.produto.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementoMultiDireita
            // 
            this.ElementoMultiDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementoMultiDireita.Location = new System.Drawing.Point(192, 166);
            this.ElementoMultiDireita.Name = "ElementoMultiDireita";
            this.ElementoMultiDireita.Size = new System.Drawing.Size(60, 50);
            this.ElementoMultiDireita.TabIndex = 14;
            this.ElementoMultiDireita.Text = "?";
            this.ElementoMultiDireita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 13;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementoMultiEsquerda
            // 
            this.ElementoMultiEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementoMultiEsquerda.Location = new System.Drawing.Point(60, 166);
            this.ElementoMultiEsquerda.Name = "ElementoMultiEsquerda";
            this.ElementoMultiEsquerda.Size = new System.Drawing.Size(60, 50);
            this.ElementoMultiEsquerda.TabIndex = 12;
            this.ElementoMultiEsquerda.Text = "?";
            this.ElementoMultiEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisao
            // 
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(324, 225);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(100, 35);
            this.divisao.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(258, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementoDiviDireita
            // 
            this.ElementoDiviDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementoDiviDireita.Location = new System.Drawing.Point(192, 216);
            this.ElementoDiviDireita.Name = "ElementoDiviDireita";
            this.ElementoDiviDireita.Size = new System.Drawing.Size(60, 50);
            this.ElementoDiviDireita.TabIndex = 19;
            this.ElementoDiviDireita.Text = "?";
            this.ElementoDiviDireita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(126, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 18;
            this.label14.Text = "/";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementoDiviEsquerda
            // 
            this.ElementoDiviEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementoDiviEsquerda.Location = new System.Drawing.Point(60, 216);
            this.ElementoDiviEsquerda.Name = "ElementoDiviEsquerda";
            this.ElementoDiviEsquerda.Size = new System.Drawing.Size(60, 50);
            this.ElementoDiviEsquerda.TabIndex = 17;
            this.ElementoDiviEsquerda.Text = "?";
            this.ElementoDiviEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementoSubEsquerda
            // 
            this.ElementoSubEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementoSubEsquerda.Location = new System.Drawing.Point(60, 107);
            this.ElementoSubEsquerda.Name = "ElementoSubEsquerda";
            this.ElementoSubEsquerda.Size = new System.Drawing.Size(60, 50);
            this.ElementoSubEsquerda.TabIndex = 7;
            this.ElementoSubEsquerda.Text = "?";
            this.ElementoSubEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(126, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 50);
            this.label17.TabIndex = 8;
            this.label17.Text = "-";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementoSubDireita
            // 
            this.ElementoSubDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementoSubDireita.Location = new System.Drawing.Point(192, 107);
            this.ElementoSubDireita.Name = "ElementoSubDireita";
            this.ElementoSubDireita.Size = new System.Drawing.Size(60, 50);
            this.ElementoSubDireita.TabIndex = 9;
            this.ElementoSubDireita.Text = "?";
            this.ElementoSubDireita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(258, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 50);
            this.label19.TabIndex = 10;
            this.label19.Text = "=";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuizAritmetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 360);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ElementoDiviDireita);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ElementoDiviEsquerda);
            this.Controls.Add(this.produto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ElementoMultiDireita);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ElementoMultiEsquerda);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.diferenca);
            this.Controls.Add(this.ElementoSubDireita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ElementoSubEsquerda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.botaoIniciar);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ElementoSomaDireita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ElementoSomaEsquerda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempoRestanteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QuizAritmetico";
            this.Text = "Quiz Aritmético";
            ((System.ComponentModel.ISupportInitialize)(this.soma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferenca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tempoRestanteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ElementoSomaEsquerda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ElementoSomaDireita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown soma;
        private System.Windows.Forms.Button botaoIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown diferenca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown produto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ElementoMultiDireita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ElementoMultiEsquerda;
        private System.Windows.Forms.NumericUpDown divisao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ElementoDiviDireita;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label ElementoDiviEsquerda;
        private System.Windows.Forms.Label ElementoSubEsquerda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label ElementoSubDireita;
        private System.Windows.Forms.Label label19;
    }
}

