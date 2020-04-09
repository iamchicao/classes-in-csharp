using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {   //Inicializa os componentes
            InitializeComponent();
        }

        private void BUTcalc_Click(object sender, EventArgs e)
        {
            double N1, N2, MD;
            try
            {   //Declara N1, N2 e MD
                //Parse = passa number para uma string porque o 
                //TXT tem como propriedade receber um texto || string
                //Se N1 ou N2 for menor que 0 ou maior que 10, escreve...
                N1 = double.Parse(TXTnota1.Text);
                N2 = double.Parse(TXTnota2.Text);
                if (N1 < 0 || N1 > 10 || N2 < 0 || N2 > 10)
                {
                    MessageBox.Show("Notas Inválidas \n Redigite!");
                    BUTlimp.PerformClick();
                }
                else
                {
                    //Média da Notas é Nota 1 + Nota 2, dividido por 2
                    //Média é apresentada como flutuante
                    MD = (N1 + N2) / 2;
                    MD = Math.Round(MD, 1);
                    LBLmedia.Text = MD.ToString("#0.0");
                    //Caso a nota média for maior que 5
                    if (MD >= 5)
                    {
                    //Pinta o Label do Resultado para a cor Azul
                    LBLresult.ForeColor = Color.Blue;
                    //Escreve no Label do Resultado que o aluno foi aprovado
                    LBLresult.Text = "Aprovado";
                    }
                    //Se não
                    else
                    {
                        //Pinta o Label do Resultado para a cor Vermelho
                        LBLresult.ForeColor = Color.Red;
                        //Escreve no Label do Resultado que o aluno foi reprovado
                        LBLresult.Text = "Reprovado";
                    }
                }
            }
            //Mensagem de erro
            catch
            {
                MessageBox.Show(" Digite apenas números! ");
                BUTlimp.PerformClick();
            }
        }

        private void BUTlimp_Click(object sender, EventArgs e)
        {
            //Limpa o TXT de nota 1
            TXTnota1.Clear();
            //Limpa o TXT de nota 2
            TXTnota2.Clear();
            //Limpa o Label de nota média
            LBLmedia.Text = "";
            //Limpa o Label de situação do aluno
            LBLresult.Text = "";
            //Após apagar todos os campos, faz com que o mouse/cursor volte para a nota 1
            TXTnota1.Focus();
        }

        private void BUTsair_Click(object sender, EventArgs e)
        {
            //Alerta ao sair do programa
            //Texto apresentado ao clicar em Sair no Programa
            string texto = "Deseja sair do Programa Média e Situação ?";
            string titulo = "Finalizando o programa";
            //Caso clique em Não, o alerta fecha e volta ao programa
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
            //Se o clique for Sim
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Encerra a aplicação
                Application.Exit();
            }
        }
    }
}
