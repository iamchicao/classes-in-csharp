using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB07
{
    public partial class FRMlab07 : Form

    {
        public FRMlab07()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mensagens em duas linhas
            LBLmens1.Text = "Selecione um valor, \nentre 1,84 e 119,43";
            LBLmens3.Text = "Cálculos ative pela: \nbarra ou caixa de texto";
            /* Nesta versão consideramos que os valores da barra vão de 1,84 até
            119,43 .
            / As propriedades Minimum, Maximum e Value são integer e portanto não
            têm frações.
            / Para resolver isso, tratamos a parte fracionária como inteira dentro da
            barra e
            / fazemos a conversão apenas no momento de mostrar o valor selecionado e
            no momento
            / de realizar as operações matemáticas. */

            TXTnumero.Text = Convert.ToString((float)VSBnumero.Value / 100); 
            // valor mínimo da barra
            // A divisão por 100 serve para inserir o ponto fracionário no TXTvalor.Text .
        }

        private void Calculos()
        {
            // o tipo citado entre parênteses será aplicado ao resultado do
            // lado direito, antes de atribui-lo à variável do lado esquerdo.
            float valor;
            double pot;
            float rad;
            valor = (float)VSBnumero.Value / 100;
            pot = (double)System.Math.Round(Math.Pow(valor, 3), 2);

            // A função "Round" arredonda a quantidade de casas decimais
            // especificada no segundo parâmetro.
            rad = (float)(System.Math.Round(Math.Sqrt(valor), 3));

            // no Label redefinimos as propriedades AutoSize e BorderStyle.
            LBLsaida.Text = "Resultados: " + '\n' + '\n' +
            "Raiz Quadrada= " + rad + '\n' +
            "Valor elevado ao Cubo= " + pot;
        }

        private void BTNLimp_Click(object sender, EventArgs e)
        {
            // Limpa a saída
            LBLsaida.Text = "";
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            //Fecha o programa
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Tranforma número do campo Valor para rolar o scroll
            VSBnumero.Value = int.Parse(LBLsaida.Text);
        }

        private void VSBnumero_Scroll(object sender, ScrollEventArgs e)
        {
            Calculos();
            // Se não tivéssemos criado a função Calculos() e tivéssemos
            // mantido os comandos originais em BTNcalculos_Click ,
            // poderíamos chamá-lo a partir daqui, da seguinte forma :
            // BTNcalculos.PerformClick(); ou
            // BTNcalculos_Click(VSBvalor,null);

            TXTnumero.Text = Convert.ToString((float)VSBnumero.Value / 100);
            // A divisão por 100 é para inserir o ponto fracionário !
            //
            // A rigor, não precisamos chamar Calculos() daqui porque
            // já chamamos de TXTnumero_TextChanged( ) , que é ativado
            // no momento em que atualizamos TXTvalor.Text .

        }

        private void TXTnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLSaida_Click(object sender, EventArgs e)
        {
            int valor;
            long pot;
            float rad;
            valor = VSBnumero.Value;
            // o tipo citado entre parênteses será aplicado ao resultado do
            // lado direito, antes de atribui-lo à variável do lado esquerdo.
            pot = (long)(System.Math.Pow(valor, 3));
            rad = (float)(System.Math.Sqrt(valor));
            // no Label redefinimos as propriedades AutoSize, BorderStyle, BackColor e Font.
            LBLsaida.Text = "Resultados: " + '\n' + '\n' + "Raiz Quadrada= " + rad + '\n' +
            "Valor elevado ao Cubo= " + pot;
        }

        private void LBLTexto_Click(object sender, EventArgs e)
        {

        }

        private void TXTValor_TextChanged(object sender, EventArgs e)
        {
            // Nesta versão, o usuário pode escolher o valor também pela TextBox.
            // Há apenas uma restrição para a digitação dos valores fracionários:
            // o usuário deve usar a vírgula como separador decimal e não o ponto.
            float valor;
            if (!float.TryParse(TXTnumero.Text, out valor) || string.IsNullOrEmpty(TXTnumero.Text))
            {
                LBLsaida.Text = valor + " valor informado não é numérico ou está vazio.";
                return; // sai da função TXTnumero_TextChanged()
            }
            if (float.Parse(TXTnumero.Text) >= 1.84 && float.Parse(TXTnumero.Text) <= 119.43)
            {
                VSBnumero.Value = (int)(float.Parse(TXTnumero.Text) * 100);
            }
            else
            {
                LBLsaida.Text = valor + " fora da faixa numérica válida.";
            }
        }
    }
}
