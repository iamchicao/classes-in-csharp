using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LAB15
{
	public class FRMlab15 : Form
	{
		private IContainer components = null;

		private Label LBLnumero;

		private TextBox TXTnumero;

		private Button BTNparesdivisiveis7;

		private Button BTNtabuada;

		private ListBox LSBsaida;

		private Button BTNlimpar;

		private Button BTNsair;

		public FRMlab15()
		{
			this.InitializeComponent();
		}

		private void BTNlimpar_Click(object sender, EventArgs e)
		{
			this.TXTnumero.Text = "";
			this.LSBsaida.Items.Clear();
			this.TXTnumero.Focus();
		}

		private void BTNparesdivisiveis7_Click(object sender, EventArgs e)
		{
			try
			{
				this.LSBsaida.Items.Clear();
				int num = int.Parse(this.TXTnumero.Text);
				this.LSBsaida.Items.Add("NÚMEROS PARES DIVISÍVEIS POR 7");
				this.LSBsaida.Items.Add("");
				if ((num < 2 ? true : num > 200))
				{
					MessageBox.Show("Digite valores entre 2 e 200");
					this.TXTnumero.Focus();
					this.TXTnumero.SelectAll();
				}
				else
				{
					for (int i = 2; i <= num; i++)
					{
						if ((i % 2 != 0 ? false : i % 7 == 0))
						{
							this.LSBsaida.Items.Add(i);
						}
					}
				}
			}
			catch
			{
				MessageBox.Show("Escolha um número antes de processar");
				this.TXTnumero.Focus();
				this.TXTnumero.SelectAll();
			}
		}

		private void BTNsair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BTNtabuada_Click(object sender, EventArgs e)
		{
			try
			{
				this.LSBsaida.Items.Clear();
				int num = int.Parse(this.TXTnumero.Text);
				this.LSBsaida.Items.Add("TABUADA");
				this.LSBsaida.Items.Add("");
				if ((num < 0 ? true : num > 9))
				{
					MessageBox.Show("Digite valores entre 0 e 9");
					this.TXTnumero.Focus();
					this.TXTnumero.SelectAll();
				}
				else
				{
					for (int i = 0; i <= 10; i++)
					{
						ListBox.ObjectCollection items = this.LSBsaida.Items;
						string[] str = new string[] { num.ToString(), " X ", i.ToString(), " = ", null };
						str[4] = (num * i).ToString();
						items.Add(string.Concat(str));
					}
				}
			}
			catch
			{
				MessageBox.Show("Escolha um número antes de processar");
			}
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.LBLnumero = new Label();
			this.TXTnumero = new TextBox();
			this.BTNparesdivisiveis7 = new Button();
			this.BTNtabuada = new Button();
			this.LSBsaida = new ListBox();
			this.BTNlimpar = new Button();
			this.BTNsair = new Button();
			base.SuspendLayout();
			this.LBLnumero.AutoSize = true;
			this.LBLnumero.Location = new Point(12, 12);
			this.LBLnumero.Name = "LBLnumero";
			this.LBLnumero.Size = new System.Drawing.Size(80, 13);
			this.LBLnumero.TabIndex = 0;
			this.LBLnumero.Text = "Digite um valor:";
			this.TXTnumero.Location = new Point(12, 47);
			this.TXTnumero.MaxLength = 3;
			this.TXTnumero.Name = "TXTnumero";
			this.TXTnumero.Size = new System.Drawing.Size(100, 20);
			this.TXTnumero.TabIndex = 1;
			this.TXTnumero.KeyPress += new KeyPressEventHandler(this.TXTnumero_KeyPress);
			this.BTNparesdivisiveis7.Location = new Point(12, 89);
			this.BTNparesdivisiveis7.Name = "BTNparesdivisiveis7";
			this.BTNparesdivisiveis7.Size = new System.Drawing.Size(100, 36);
			this.BTNparesdivisiveis7.TabIndex = 2;
			this.BTNparesdivisiveis7.Text = "&Números pares divisíveis por 7";
			this.BTNparesdivisiveis7.UseVisualStyleBackColor = true;
			this.BTNparesdivisiveis7.Click += new EventHandler(this.BTNparesdivisiveis7_Click);
			this.BTNtabuada.Location = new Point(12, 134);
			this.BTNtabuada.Name = "BTNtabuada";
			this.BTNtabuada.Size = new System.Drawing.Size(100, 36);
			this.BTNtabuada.TabIndex = 3;
			this.BTNtabuada.Text = "&Tabuada";
			this.BTNtabuada.UseVisualStyleBackColor = true;
			this.BTNtabuada.Click += new EventHandler(this.BTNtabuada_Click);
			this.LSBsaida.FormattingEnabled = true;
			this.LSBsaida.Location = new Point(136, 12);
			this.LSBsaida.Name = "LSBsaida";
			this.LSBsaida.Size = new System.Drawing.Size(231, 264);
			this.LSBsaida.TabIndex = 4;
			this.BTNlimpar.Location = new Point(12, 179);
			this.BTNlimpar.Name = "BTNlimpar";
			this.BTNlimpar.Size = new System.Drawing.Size(100, 36);
			this.BTNlimpar.TabIndex = 5;
			this.BTNlimpar.Text = "&Limpar";
			this.BTNlimpar.UseVisualStyleBackColor = true;
			this.BTNlimpar.Click += new EventHandler(this.BTNlimpar_Click);
			this.BTNsair.Location = new Point(12, 224);
			this.BTNsair.Name = "BTNsair";
			this.BTNsair.Size = new System.Drawing.Size(100, 36);
			this.BTNsair.TabIndex = 6;
			this.BTNsair.Text = "Sai&r";
			this.BTNsair.UseVisualStyleBackColor = true;
			this.BTNsair.Click += new EventHandler(this.BTNsair_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(391, 288);
			base.Controls.Add(this.BTNsair);
			base.Controls.Add(this.BTNlimpar);
			base.Controls.Add(this.LSBsaida);
			base.Controls.Add(this.BTNtabuada);
			base.Controls.Add(this.BTNparesdivisiveis7);
			base.Controls.Add(this.TXTnumero);
			base.Controls.Add(this.LBLnumero);
			base.Name = "FRMlab15";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Pares divisíveis por 7 e Tabuada – LAB15";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void TXTnumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((char.IsDigit(e.KeyChar) ? false : !char.IsControl(e.KeyChar)))
			{
				MessageBox.Show("Digite apenas números ou BackSpace,Del,etc.");
				e.Handled = true;
			}
		}
	}
}