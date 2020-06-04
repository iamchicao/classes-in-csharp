using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2
{
    public partial class Form1 : Form
    {
		double potencia;
		double tensao;
		double corrente;
		double maior;
		double menor;
		bool limpar = false;
		bool primeiro = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			if ((!(this.TXTequipamento.Text != "") || !(this.TXTtensao.Text != "") ? true : this.TXTcorrente.Text == ""))
			{
				MessageBox.Show("Não pode deixar campos vazios para efetuar o cadastro");
			}
			else
			{
				this.potencia = this.tensao * this.corrente;
				this.LSTsaida.Items.Add(string.Concat("Equipamento: ", this.TXTequipamento.Text));
				this.LSTsaida.Items.Add(string.Concat("Tensão: ", this.TXTtensao.Text, " Volt(s)"));
				this.LSTsaida.Items.Add(string.Concat("Corrente: ", this.TXTcorrente.Text, " Ampere(s)"));
				this.LSTsaida.Items.Add(string.Concat("Potência: ", this.potencia.ToString("#,###.0 Watt(s)")));
				this.LSTsaida.Items.Add("---------------------------------------------------------------");
				if (!this.primeiro)
				{
					if (this.potencia > this.maior)
					{
						this.maior = this.potencia;
					}
					if (this.potencia < this.menor)
					{
						this.menor = this.potencia;
					}
				}
				else
				{
					this.maior = this.potencia;
					this.menor = this.potencia;
					this.primeiro = false;
				}
				this.LBLmenor.Text = this.maior.ToString("#,###.0 watt(s)");
				this.LBLmaior.Text = this.menor.ToString("#,###.0 watt(s)");
				this.limpar = true;
				this.TXTequipamento.Clear();
				this.TXTtensao.Clear();
				this.TXTcorrente.Clear();
				this.limpar = false;
				this.TXTequipamento.Focus();
			}
		}

        private void LBLmaior_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
			this.limpar = true;
			this.TXTequipamento.Clear();
			this.TXTtensao.Clear();
			this.TXTcorrente.Clear();
			this.limpar = false;
			this.LBLmenor.Text = "";
			this.LBLmaior.Text = "";
			this.LSTsaida.Items.Clear();
			this.primeiro = true;
			this.TXTequipamento.Focus();
		}

        private void BTNsair_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Deseja mesmo finalizar", "Finalizando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
			{
				base.Close();
			}
		}

        private void TXTcorrente_TextChanged(object sender, EventArgs e)
        {
			try
			{
				this.corrente = double.Parse(this.TXTcorrente.Text);
				if ((this.corrente < 0 ? true : this.corrente > 100000))
				{
					MessageBox.Show("A corrente deve estar entre 0 e 100.000 Amperes.");
					this.TXTcorrente.SelectAll();
				}
			}
			catch
			{
				if (!this.limpar)
				{
					if (!string.IsNullOrEmpty(this.TXTcorrente.Text))
					{
						MessageBox.Show("Informe apenas valores numéricos.");
					}
					else
					{
						MessageBox.Show("Este campo não pode ficar vazio.");
					}
					this.limpar = true;
					this.TXTcorrente.Clear();
					this.TXTcorrente.Focus();
					this.limpar = false;
					this.TXTcorrente.Focus();
				}
			}
		}

        private void TXTtensao_TextChanged(object sender, EventArgs e)
        {
			try
			{
				this.tensao = double.Parse(this.TXTtensao.Text);
				if ((this.tensao < 0 ? true : this.tensao > 100000000))
				{
					MessageBox.Show("A tensão deve estar entre 0 volt e 100.000.000 Volts.");
					this.TXTtensao.SelectAll();
				}
			}
			catch
			{
				if (!this.limpar)
				{
					if (!string.IsNullOrEmpty(this.TXTtensao.Text))
					{
						MessageBox.Show("Informe apenas valores numéricos.");
					}
					else
					{
						MessageBox.Show("Este campo não pode ficar vazio.");
					}
					this.limpar = true;
					this.TXTtensao.Clear();
					this.TXTtensao.Focus();
					this.limpar = false;
					this.TXTtensao.Focus();
				}
			}
		}

        private void label7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
