using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTEntrada.Clear();

            LBLresultado.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTEntrada_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TXTSaida_TextChanged(object sender, EventArgs e)
        {   
            //Impede o cliente de digitar na saída
            LBLresultado.ReadOnly = true;
            //Habilita o botão sair
            BTNSair.Enabled = true;
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {   
            //Habilita o botão Sair
            BTNSair.Enabled = false;

            //Fechar o programa
            this.Close();
        }

        private void BTNProcessar_Click(object sender, EventArgs e)
        {   
            //Exibe mensagem do TXTEntrada ao clicar em Processar
            LBLresultado.Text = TXTEntrada.Text;
        }
    }
}
