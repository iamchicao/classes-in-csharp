using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB05
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            //Limpa Entradas
            TXTNome.Text = "";
            TXTSexo.Text = "";
            TXTIdade.Text = "0";

            //Limpar saídas
            LBLResultado.Text = "";
            HSBidade.Value = 0;

            //Volta o cursor para o nome
            TXTNome.Focus();

        }

        private void TXTSexo_TextChanged(object sender, EventArgs e)
        {
            //Se digitar F exibe Feminino
            if (TXTSexo.Text == "F")
                LBLResultado.Text = "Feminino";
            else//Se não
                //Se digitar M exibe Masculino
                if (TXTSexo.Text == "M")
                LBLResultado.Text = "Masculino";
            //Se não, não exibirá nada
            else
                LBLResultado.Text = "";
        }

        private void HSBidade_Scroll(object sender, ScrollEventArgs e)
        {
            //Conversão de valor para string e exibe no TXTIdade
            TXTIdade.Text = HSBidade.Value.ToString();
        }

        private void BTNProcessar_Click(object sender, EventArgs e)
        {
            LBLResultado.Text = "Dados Cadastrais\n" +
                "===================\n" +
                "Nome:" + TXTNome.Text +
                "\nIdade:" + TXTIdade.Text +
                "\nSexo:" + LBLResultado.Text;
        }

        private void TXTIdade_TextChanged(object sender, EventArgs e)
        {
            //Tranforma número do campo Idade para rolar o scroll
            HSBidade.Value = int.Parse(TXTIdade.Text);
        }
    }
}
