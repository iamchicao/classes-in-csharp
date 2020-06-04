using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB16
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
			try
			{
				double num = double.Parse(this.TXTentrada1.Text);
				double num1 = double.Parse(this.TXTentrada2.Text);
				double num2 = double.Parse(this.TXTentrada3.Text);
				if ((num <= 0 || num1 <= 0 || num2 <= 0 ? true : num + num1 + num2 != 180))
				{
					this.LBLsaida.Text = "Não é Triângulo";
				}
				else if ((num >= 90 || num1 >= 90 ? false : num2 < 90))
				{
					this.LBLsaida.Text = "Triângulo Acutângulo";
				}
				else if ((num > 90 || num1 > 90 ? false : num2 <= 90))
				{
					this.LBLsaida.Text = "Triângulo Retângulo";
				}
				else
				{
					this.LBLsaida.Text = "Triângulo Obtusângulo";
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Entradas inválidas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.BTNlimpar.PerformClick();
			}
		}

        private void BTNlado_Click(object sender, EventArgs e)
        {
			try
			{
				double num = double.Parse(this.TXTentrada1.Text);
				double num1 = double.Parse(this.TXTentrada2.Text);
				double num2 = double.Parse(this.TXTentrada3.Text);
				if ((num >= num1 + num2 || num1 >= num + num2 ? true : num2 >= num + num1))
				{
					this.LBLsaida.Text = "Não é Triângulo";
				}
				else if ((num != num1 ? false : num1 == num2))
				{
					this.LBLsaida.Text = "Triângulo Equilátero";
				}
				else if ((num == num1 || num == num2 ? false : num1 != num2))
				{
					this.LBLsaida.Text = "Triângulo Escaleno";
				}
				else
				{
					this.LBLsaida.Text = "Triângulo Isósceles";
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Entradas inválidas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.BTNlimpar.PerformClick();
			}
		}

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
			this.TXTentrada1.Text = "";
			this.TXTentrada2.Text = "";
			this.TXTentrada3.Text = "";
			this.LBLsaida.Text = "";
			this.TXTentrada1.Focus();
		}

        private void BTNsait_Click(object sender, EventArgs e)
        {
			base.Close();
		}
    }
}
