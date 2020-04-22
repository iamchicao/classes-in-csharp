using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB13
{
    public partial class Form1 : Form
    {

        // aqui declaramos as variáveis globais, públicas do formulário,
        // que deverão ser usadas por 2 ou mais eventos.
        int a;
        int b;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBLsaida1.Text = "Valores selecionados:" + '\n' + '\n' +
            "a = 0" + '\n' + "b = 0";
            Calculos();
        }

        public void Calculos()
        {
            // Esta é uma Função independente de objetos e eventos,
            // que pode ser chamada de qualquer procedimento/evento deste
            // formulário. O objetivo é evitar redundância de código.
            string msg;
            float raiz;
            msg = "Resultados Obtidos:" + '\n' + '\n';
            // \n -> pula para a linha seguinte ao ser processado.
            if (CKBsoma.Checked == true)
            {
                msg = msg + '\n' + "SOMA: " + (a + b);
                // neste caso, por envolver strings e números, a
                // conversão para string é feita automaticamente.
            }
            if (CKBmultiplicacao.Checked == true)
            {
                msg = msg + '\n' + "MULTIPLICAÇÃO: " + (a * b);
            }
            if (CKBexpressao.Checked)
            {
                raiz = (float)(System.Math.Sqrt(b));
                msg = msg + '\n' + "EXPRESSÃO: " + (a * a + raiz);
            }
            LBLsaida2.Text = msg;
            // Após a mensagem estar completamente montada,
            // ela foi transferida para o Label de saída.
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Calculos();
        }

        private void LBLsaida2_Click(object sender, EventArgs e)
        {

        }

        private void VSBvalor_Scroll(object sender, ScrollEventArgs e)
        {
            if (RDBa.Checked == true)
            {
                a = VSBvalor.Value;
            }
            else
            {
                b = VSBvalor.Value;
            }
            // linhas de comando muito longas podem ser "quebradas" em 2 ou mais
            // linhas, porque o controle final está no caractere ; (ponto-e-ula) .
            LBLsaida1.Text = "Valores selecionados:" + '\n' + '\n' +
            "a = " + a + '\n' + "b = " + b;
            
            Calculos();
            // no comando acima, estamos chamando a execução da
            // função "Calculos". Após a execução de "Calculos"
            // o programa continua a partir da linha seguinte à sua chamada.
            // Neste exemplo, toda vez que o usuário alterar o valor
            // de A ou de B através da Barra de Rolagem, chamamos à execução
            // a rotina Calculos, com o objetivo de evitar inconsistências
            // temporárias entre as informações mostradas na interface.
        }

        private void CKBsoma_CheckedChanged(object sender, EventArgs e)
        {
            Calculos();
        }

        private void CKBexpressao_CheckedChanged(object sender, EventArgs e)
        {
            Calculos();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            VSBvalor.Value = b;
            // a Barra é atualizada com o último valor da variável B.
            // Sem este comando, a variável é que será redefinida com o
            // último valor que estiver na barra de rolagem.
            // Observe o comportamento do programa com e sem este comando !
            // Para testar o programa SEM este comando , basta colocar
            // à sua esquerda um par de barras de comentário (//).
        }

        private void RDBa_CheckedChanged(object sender, EventArgs e)
        {
            VSBvalor.Value = a;
            // a Barra é atualizada com o último valor da variável A.
            // Sem este comando, a variável é que será redefinida com o
            // último valor que estiver na barra de rolagem.
            // Observe o comportamento do programa com e sem este comando !
            // Para testar o programa SEM este comando , basta colocar
            // à sua esquerda um par de barras de comentário (//).
        }

        private void BTNencerra_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
