using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB08
{
    public partial class Calculadora : Form
    {
        public float num1;
        public float num2;

        public Calculadora()
        {
            InitializeComponent();

        }

        private void entrada() // função não associada a objeto/evento.
        {
            num1 = float.Parse(numero1.Text);
            num2 = float.Parse(numero2.Text);
            // A estrutura deste procedimento é falha porque tem potencial
            // de produzir erro de run-time, considerando que o float.Parse
            // vai dar erro se o usuário deixar o campo vazio ou digitar
            // qualquer caractere não numérico.
            // A versão Lab03b vai corrigir isso e estruturar melhor!
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Chama o botão limpar.
            BTNlimpar.PerformClick();
        }

        private void saida(Color cor)
        {   // Recebe parâmetro COR que é usado no segundo comando abaixo.
            // Este parâmetro é do tipo Color e seu valor é dado por Color.nome_da_cor
            //LBLsaida.Text = result.Text;
            result.BackColor = cor;
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            // Fechar o programa
            this.Close();
        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            // Iniciamos com zero, ao invés de TXTnumero1.Clear();
            numero1.Text = "0";
            numero2.Text = "0";
            LBLsaida.BackColor = Color.Beige;
        }

        private void BTNDiv_Click(object sender, EventArgs e)
        {
            entrada();
            // cálculo específico deste "objeto_evento"
            if (num2 == 0)
            {
                result.Text = "Erro";
                result.BackColor = Color.Salmon;
            }
            else
            {
                result.Text = (num1 / num2).ToString();
                saida(Color.Red);
            }
        }

        private void BTNMult_Click(object sender, EventArgs e)
        {
            entrada();
            // cálculo específico deste "objeto_evento"
            result.Text = (num1 * num2).ToString();
            saida(Color.Blue);
        }

        private void BTNSub_Click(object sender, EventArgs e)
        {
            entrada();
            // cálculo específico deste "objeto_evento"
            result.Text = (num1 - num2).ToString();
            saida(Color.Green);
        }

        private void BTNSomar_Click(object sender, EventArgs e)
        {
            entrada();
            // cálculo específico deste "objeto_evento"
            result.Text = (num1 + num2).ToString();
            saida(Color.Silver);
        }

        private void TXTnumero1_TextChanged(object sender, EventArgs e)
        {
            // Programar o evento "TextChanged" é uma alternativa interessante.
            // Entretanto, deve-se cuidar para que o processo de "Limpar" as
            // caixas de entrada não dê erro (caso mova um valor vazio), porque
            // a conversão de "" (vazio) para um tipo numérico é inválida.
            //num1 = float.Parse(TXTnumero1.Text);
            //num2 = float.Parse(TXTnumero2.Text);
            // Os comandos acima, se programados aqui e no mesmo evento do  TXTvalor2, 
            // substituem a função entrada(), com o cuidado de mover "0" ao
            // invés de "" para o .Text no procedimento BTNlimpar_Click .
        }

        private void LBLsaida_Click(object sender, EventArgs e)
        {

        }
    }
}
