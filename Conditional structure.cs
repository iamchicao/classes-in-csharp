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
    public partial class FRMlab10 : Form
    {
        public FRMlab10()
        {
            InitializeComponent();
        }
        // Variáveis globais
        float nota1, nota2;

        private void TXTnota1_TextChanged(object sender, EventArgs e)
        {
            // Entrada nota1
            try // usuário bom
            {
                nota1 = float.Parse(TXTnota1.Text);
                // se nota<0 ou nota1>10
                if(nota1<0 || nota1>10) // if(!(nota1>=0 && nota1<=10))
                {
                    MessageBox.Show("A nota 1 deve estar entre zero e dez");
                    TXTnota1.Text = "0"; // Limpa a nota1
                    TXTnota1.SelectAll(); // Seleciona o texto da nota1
                }
            }
            catch // usuário ruim
            {
                // Verificar se a nota1 está vazia
                if(string.IsNullOrEmpty(TXTnota1.Text))
                {
                    MessageBox.Show("Esta campo não pode ficar vazio");
                    TXTnota1.Text = "0"; // Limpa a nota1
                    TXTnota1.SelectAll(); // Seleciona o texto da nota1
                }
                else // senão - Digitou letras
                {
                    MessageBox.Show("Informe apenas valores numéricos");
                    TXTnota1.Text = "0"; // Limpa a nota1
                    TXTnota1.SelectAll(); // Seleciona o texto da nota1
                }

            }
        }

        private void TXTnota2_TextChanged(object sender, EventArgs e)
        {
            // Entrada nota2
            try // usuário bom
            {
                nota2 = float.Parse(TXTnota2.Text);
                // se nota<0 ou nota1>10
                if (nota2 < 0 || nota2 > 10) // if(!(nota2>=0 && nota2<=10))
                {
                    MessageBox.Show("A nota 2 deve estar entre zero e dez");
                    TXTnota2.Text = "0"; // Limpa a nota1
                    TXTnota2.SelectAll(); // Seleciona o texto da nota1
                }
            }
            catch // usuário ruim
            {
                // Verificar se a nota2 está vazia
                if (string.IsNullOrEmpty(TXTnota2.Text))
                {
                    MessageBox.Show("Esta campo não pode ficar vazio");
                    TXTnota2.Text = "0"; // Limpa a nota1
                    TXTnota2.SelectAll(); // Seleciona o texto da nota1
                }
                else // senão - Digitou letras
                {
                    MessageBox.Show("Informe apenas valores numéricos");
                    TXTnota2.Text = "0"; // Limpa a nota1
                    TXTnota2.SelectAll(); // Seleciona o texto da nota1
                }

            }
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            // Declaração de variável
            float media;
            // processamento
            media = (nota1 + nota2) / 2;
            // Arredondar a média com uma casa decimal
            media = (float)Math.Round(media, 1);
            // Saída
            LBLsaidanota.Text = media.ToString("#0.0");
            // Verificar se aluno aprovado - SE média>=5
            if(media>=5)
            {
                LBLsaidasituacao.Text = "APROVADO"; // Escreve aprovado
                LBLsaidasituacao.ForeColor = Color.Blue; // Letra azul 
            }
            else // senão - aluno reprovado
            {
                LBLsaidasituacao.Text = "REPROVADO"; // Escreve reprovado
                LBLsaidasituacao.ForeColor = Color.Red; // Letra vermelha
            }
        }

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            // Limpar as entradas
            TXTnota1.Text = "0";
            TXTnota2.Text = "0";
            // Limpar as saídas
            LBLsaidanota.Text = "";
            LBLsaidasituacao.Text = "";
            // Voltar o cursor para a nota1
            TXTnota1.Focus();
        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            // Sair com pergunta se Deseja mesmo finalizar   
            if (MessageBox.Show("Deseja mesmo terminar", "Finalizando",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit(); // Sair do aplicativo
        }

        private void FRMlab10_Load(object sender, EventArgs e)
        {
            // Valores iniciais para os textBox TXTnota1 e TXTnota2
            TXTnota1.Text = "0";
            TXTnota2.Text = "0";
        }
    }
}
