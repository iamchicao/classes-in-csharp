using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            //Fechar o Programa
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Texto escrito no Label de saída
            LBLresultado.Text = "Primeira aplicação em CSharp";

            //Desabilitar o botão Sair
            BTNSair.Enabled = false;        }

        private void BTNMens_Click(object sender, EventArgs e)
        {
            //Alterar a cor do texto do Label de Saída
            LBLresultado.ForeColor = Color.Blue;

            //Alterar a cor de fundo do Label de Saída
            LBLresultado.BackColor = Color.Beige;

            //Alterar o texto do Label de Saída
            LBLresultado.Text = "Informação de entrada\n" +
                TXTentrada.Text;

            //Habilitar botão de saída
            BTNSair.Enabled = true;
        }

        private void BTNLimp_Click(object sender, EventArgs e)
        {
            //Limpar o texto do TXTBox de entrada
            TXTentrada.Text = "";

            //Limpar o Label de Saída
            LBLresultado.Text = "Primeira aplicação em CSharp";

            //Alterar a cor do fundo do Label de Saída
            LBLresultado.BackColor = Color.Aquamarine;

            //Alterar a cor da letra do Label de Saída
            LBLresultado.BackColor = Color.Black;

            //Desabilitar o botão de Saída
            BTNSair.Enabled = false;

            //Voltar o cursor ao TextBox de Entrada
            TXTentrada.Focus();
        }
    }
}
