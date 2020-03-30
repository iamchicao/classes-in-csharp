using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB06
{
    public partial class FRMlab06 : Form
    {
        public FRMlab06()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Minímo 0 e Máximo 60 no valor
            VSBnumero.Value = 0;
            VSBnumero.Maximum = 69;

            //o parâmetro "###" é opcional e define a máscara de geração do string.
            TXTnumero.Text = VSBnumero.Value.ToString("###");
        }

        private void BTNCalc_Click(object sender, EventArgs e)
        {
            // o tipo citado entre parênteses será aplicado ao resultado do
            // lado direito, antes de atribui-lo à variável do lado esquerdo.
            int valor;
            long pot;
            float rad;
            valor = VSBnumero.Value;

            pot = (long)(System.Math.Pow(valor, 3));
            rad = (float)(System.Math.Sqrt(valor));

            // no Label redefinimos as propriedades AutoSize, BorderStyle, BackColor e Font.
            LBLSaida.Text = "Resultados: " + '\n' + '\n' + "Raiz Quadrada= " + rad + '\n' +
            "Valor elevado ao Cubo= " + pot;
        }

        private void BTNLimp_Click(object sender, EventArgs e)
        {
            // Limpa a saída
            LBLSaida.Text = "";
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            //Fecha o programa
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Tranforma número do campo Valor para rolar o scroll
            VSBnumero.Value = int.Parse(LBLSaida.Text);
        }

        private void VSBnumero_Scroll(object sender, ScrollEventArgs e)
        {
            // Limpamos o Label de resultados para evitar inconsistência de informação na interface.
            LBLSaida.Text = "";

            // Redefinimos as propriedades Maximum, Minimum e LargeChange da Barra de Rolagem.
            TXTnumero.Text = VSBnumero.Value.ToString();

            // O comando abaixo permite chamar o procedimento do click do botão calculos,
            // toda vez que o usuário mexer na barra de rolagem. O botão calculos deixa de ter sentido !
            BTNCalc_Click(VSBnumero, null);

        }

        private void TXTnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLSaida_Click(object sender, EventArgs e)
        {

        }
    }
}
