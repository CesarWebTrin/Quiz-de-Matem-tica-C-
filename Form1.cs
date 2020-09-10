using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class QuizAritmetico : Form
    {
        Random randomico = new Random();

        int somador1;
        int somador2;

        int minuindo;
        int subtraindo;

        int multiplicando;
        int multiplica;

        int divisor;
        int dividendo;

        int tempoRestante;

        public void IniciaQuiz()
        {
            somador1 = randomico.Next(50);
            somador2 = randomico.Next(50);
          
            somador1 = randomico.Next(50);
            somador2 = randomico.Next(50);     
          
            ElementoSomaEsquerda.Text = somador1.ToString();
            ElementoSomaDireita.Text = somador2.ToString();

            minuindo = randomico.Next(1, 101);
            subtraindo = randomico.Next(1, minuindo);

            ElementoSubDireita.Text = subtraindo.ToString();
            ElementoSubEsquerda.Text = minuindo.ToString();

            multiplicando = randomico.Next(2, 11);
            multiplica = randomico.Next(2, 11);

            ElementoMultiEsquerda.Text = multiplicando.ToString();
            ElementoMultiDireita.Text = multiplica.ToString();

            divisor = randomico.Next(2, 11);
            int temporarioQuocient = randomico.Next(2, 11);
            dividendo = divisor * temporarioQuocient;

            ElementoDiviEsquerda.Text = dividendo.ToString();
            ElementoDiviDireita.Text = divisor.ToString();

            soma.Value = 0;
            diferenca.Value = 0;
            produto.Value = 0;
            divisao.Value = 0;

            tempoRestante = 30;
            tempoRestanteLabel.Text = "30 segundos";
            timer1.Start();
        }

        private bool checaResposta()
        {
            if (somador1 + somador2 == soma.Value
                    && (minuindo - subtraindo == diferenca.Value)
                    && (multiplicando * multiplica == produto.Value)
                    && (dividendo / divisor == divisao.Value))
                return true;
            else
                return false;
        }
        public QuizAritmetico()
        {
            InitializeComponent();
        }

        private void botaoIniciar_Click(object sender, EventArgs e)
        {
            IniciaQuiz();
            botaoIniciar.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checaResposta())
            {
                timer1.Stop();
                MessageBox.Show("Parabéns, você acertou!");
                botaoIniciar.Enabled = true;
            }
            else if(tempoRestante > 0)
            {
                tempoRestante--;
                tempoRestanteLabel.Text = tempoRestante + " segundos";
            }
            else
            {
                timer1.Stop();
                tempoRestanteLabel.Text = "O seu tempo acabou";
                MessageBox.Show("Você não finalizou no tempo fornecido");
                soma.Value = somador1 + somador2;
                diferenca.Value = minuindo - subtraindo;
                produto.Value = multiplicando * multiplica;
                divisao.Value = dividendo / divisor;
                botaoIniciar.Enabled = true;
            }
        }

        private void resposta_Enter(object sender, EventArgs e)
        {
            NumericUpDown caixaResposta = sender as NumericUpDown;

            if(caixaResposta != null)
            {
                int tamanhoResposta = caixaResposta.Value.ToString().Length;
                caixaResposta.Select(0, tamanhoResposta);
            }
        }
    }
}
