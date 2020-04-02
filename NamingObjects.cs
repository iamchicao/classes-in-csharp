using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTEntrada_TextChanged(object sender, EventArgs e)
        {   
            //Trás o texto de entrada e mostra na saída
            TXTsaida.Text = TXTentrada.Text;
            //Impede que o cliente digite no campo de Saída
            TXTsaida.ReadOnly = true;
        }

        private void LBLresultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            //Impede de fechar antes de limpar
            BTNSair.Enabled = false;
            //Fecha o progrma
            Close();

        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {

            //Limpa os dados da entrada
            TXTentrada.Text = "";

        }
    }
}
