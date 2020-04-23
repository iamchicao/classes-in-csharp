using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Inicialização de Compoenentes
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MP10_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Se o valor 1 estiver vázia ou número informado for menor que 0
            if(MP10_1.Text == "" || Converter(MP10_1.Text) < 0)
            {
                //Exibe Mensagem
                MessageBox.Show("Campo de preenchimento obrigatório, somente valores positivos");
                //Retorna o foco do mouse para o valor 1
                MP10_1.Focus();
            }
            //E Se o valor 2 estiver vázia ou número informado for menor que 0
            else if(MP10_2.Text == "" || Converter(MP10_2.Text) < 0)
            {
                //Exibe Mensagem
                MessageBox.Show("Campo de preenchimento obrigatório, somente valores positivos");
                //Retorna o foco do mouse para o valor 2
                MP10_2.Focus();
            }
            //E Se o valor 3 estiver vázia ou número informado for menor que 0
            else if(MP10_3.Text == "" || Converter(MP10_3.Text) < 0)
            {   //Exibe Mensagem
                MessageBox.Show("Campo de preenchimento obrigatório, somente valores positivos");
                //Retorna o foco do mouse para o valor 3
                MP10_3.Focus();
            }
            //E Se o valor 4 estiver vázia ou número informado for menor que 0
            else if(MP10_4.Text == "" || Converter(MP10_4.Text) < 0)
            {
                //Exibe Mensagem
                MessageBox.Show("Campo de preenchimento obrigatório, somente valores positivos");
                //Retorna o foco do mouse para o valor 4
                MP10_4.Focus();
            }
            //Se não
            else
            {
                //Soma todos os valores e divide por 4
                var Resultado = Converter(MP10_1.Text) + Converter(MP10_2.Text)
              + Converter(MP10_3.Text) + Converter(MP10_4.Text) / 4;

                //Define a varíiável Indice como string vazia
                string Indice = string.Empty;
                //Define a varável Cor como default Color Branco
                Color Cor = Color.White;
                //Se Resultado for menor que 50
                if(Resultado <= 50)
                {
                    //Adiciona a string a Indice
                    Indice = "A qualidade e saúde do ar é Boa";
                    //Adiciona Color a Cor
                    Cor = Color.Green;
                }
                //Se Resultado for maior que 50 e menor que 150
                else if(Resultado > 50 & Resultado <= 150)
                {
                    //Adiciona a string a Indice
                    Indice = "A qualidade e saúde do ar é Regular";
                    //Adiciona Color a Cor
                    Cor = Color.Blue;
                }
                //Se Resultado for maior que 150 e menor que 250
                else if(Resultado > 150 & Resultado <= 250)
                {
                    //Adiciona a string a Indice
                    Indice = "A qualidade e saúde do ar é Inadequada";
                    //Adiciona Color a Cor
                    Cor = Color.Yellow;
                }
                //Se Resultado for maior que 250 e menor que 420
                else if (Resultado > 250 & Resultado <= 420)
                {
                    //Adiciona a string a Indice
                    Indice = "A qualidade e saúde do ar é Má";
                    //Adiciona Color a Cor
                    Cor = Color.Orange;
                }
                //Se Resultado for maior que 420
                else if (Resultado > 420)
                {
                    //Adiciona a string a Indice
                    Indice = "A qualidade e saúde do ar é Péssima";
                    //Adiciona Color a Cor
                    Cor = Color.Red;
                }
                //Exibe a mensagem da qualidade do ar
                MMP10.Text = Resultado.ToString();
                //Muda a cor da Label de Resultado conforme a qualidade
                LBLsaida.BackColor = Cor;
                //Trás a qualidade do ar
                LBLsaida.Text = Indice.ToString();
            }
        }

        public double Converter(string conv)
        {
            //Convertendo string para número
            return double.Parse(conv);
        }

        private void MP10_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Encerra o programa
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpa o texto do Label de Saida
            LBLsaida.Text = "";
            //Limpa o texto do TextBox de Valor 1
            MP10_1.Text = "";
            //Limpa o texto do TextBox de Valor 2
            MP10_2.Text = "";
            //Limpa o texto do TextBox de Valor 3
            MP10_3.Text = "";
            //Limpa o texto do TextBox de Valor 4
            MP10_4.Text = "";
            //Limpa o texto do TextBox de Valor de Média
            MMP10.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MMP10_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNprocessar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ao pressionar ENTER no teclado clica o botão Processar
            if(e.KeyChar == 13)
            {
                //Clica no Botão Processar
                BTNprocessar.PerformClick();
            }

            //Ao pressionar BACKSPACE no teclado clica o botão Limpar
            else if(e.KeyChar == 8)
            {
                //Clica no Botão Limpar
                BTNlimpar.PerformClick();
            }

            //Ao pressionar ESC(Escape) no teclado clica o botão Sair
            else if(e.KeyChar == 27)
            {
                //Clica no Botão Sair
                BTNsair.PerformClick();
            }
        }

        private void MP10_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para somente aceitar número e vírgula
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e vírgula");
            }
        }

        private void MP10_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para somente aceitar número e vírgula
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e vírgula");
            }
        }

        private void MP10_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para somente aceitar número e vírgula
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e vírgula");
            }
        }

        private void MP10_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para somente aceitar número e vírgula
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e vírgula");
            }
        }
    }
}
