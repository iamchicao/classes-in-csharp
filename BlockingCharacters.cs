using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LAB14
{
	public class FRMlab14 : Form
	{
		private double cont;

		private double num;

		private double maior;

		private double menor;

		private double soma;

		private IContainer components = null;

		private GroupBox GPBentrada;

		private Button BTNlimpar;

		private Button BTNprocessar;

		private TextBox TXTnumero;

		private GroupBox GPBsaida;

		private TextBox TXTmedia;

		private TextBox TXTquantidade;

		private TextBox TXTmenor;

		private TextBox TXTmaior;

		private Label LBLmedia;

		private Label LBLquantidade;

		private Label LBLmenor;

		private Label LBLmaior;

		public FRMlab14()
		{
			this.InitializeComponent();
		}

		private void BTNlimpar_Click(object sender, EventArgs e)
		{
			this.TXTnumero.Text = "";
			this.TXTmaior.Text = "";
			this.TXTmenor.Text = "";
			this.TXTquantidade.Text = "";
			this.TXTmedia.Text = "";
			this.cont = 0;
			this.soma = 0;
			this.TXTnumero.Focus();
		}

		private void BTNprocessar_Click(object sender, EventArgs e)
		{
			if (this.TXTnumero.Text == "")
			{
				this.TXTnumero.Text = "0";
			}
			else
			{
				this.num = double.Parse(this.TXTnumero.Text);
				this.cont += 1;
				this.soma += this.num;
				if (this.cont != 1)
				{
					if (this.num > this.maior)
					{
						this.maior = this.num;
					}
					if (this.num < this.menor)
					{
						this.menor = this.num;
					}
				}
				else
				{
					this.maior = this.num;
					this.menor = this.num;
				}
				this.maior = Math.Round(this.maior, 2);
				this.menor = Math.Round(this.menor, 2);
				this.cont = Math.Round(this.cont, 2);
				this.maior = Math.Round(this.maior, 2);
				this.TXTmaior.Text = this.maior.ToString("#,##0.00");
				this.TXTmenor.Text = this.menor.ToString("#,##0.00");
				this.TXTquantidade.Text = this.cont.ToString("#,##0.00");
				TextBox tXTmedia = this.TXTmedia;
				double num = Math.Round(this.soma / this.cont, 2);
				tXTmedia.Text = num.ToString("#,##0.00");
				this.TXTnumero.Focus();
				this.TXTnumero.SelectAll();
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

		private void FRMlab14_Load(object sender, EventArgs e)
		{
			this.soma = 0;
			this.cont = 0;
		}

		private void InitializeComponent()
		{
			this.GPBentrada = new GroupBox();
			this.BTNlimpar = new Button();
			this.BTNprocessar = new Button();
			this.TXTnumero = new TextBox();
			this.GPBsaida = new GroupBox();
			this.TXTmedia = new TextBox();
			this.TXTquantidade = new TextBox();
			this.TXTmenor = new TextBox();
			this.TXTmaior = new TextBox();
			this.LBLmedia = new Label();
			this.LBLquantidade = new Label();
			this.LBLmenor = new Label();
			this.LBLmaior = new Label();
			this.GPBentrada.SuspendLayout();
			this.GPBsaida.SuspendLayout();
			base.SuspendLayout();
			this.GPBentrada.Controls.Add(this.BTNlimpar);
			this.GPBentrada.Controls.Add(this.BTNprocessar);
			this.GPBentrada.Controls.Add(this.TXTnumero);
			this.GPBentrada.Location = new Point(24, 12);
			this.GPBentrada.Name = "GPBentrada";
			this.GPBentrada.Size = new System.Drawing.Size(304, 100);
			this.GPBentrada.TabIndex = 0;
			this.GPBentrada.TabStop = false;
			this.GPBentrada.Text = "Informe os valores";
			this.BTNlimpar.Location = new Point(165, 50);
			this.BTNlimpar.Name = "BTNlimpar";
			this.BTNlimpar.Size = new System.Drawing.Size(75, 23);
			this.BTNlimpar.TabIndex = 2;
			this.BTNlimpar.Text = "&Limpar";
			this.BTNlimpar.UseVisualStyleBackColor = true;
			this.BTNlimpar.Click += new EventHandler(this.BTNlimpar_Click);
			this.BTNprocessar.Location = new Point(165, 20);
			this.BTNprocessar.Name = "BTNprocessar";
			this.BTNprocessar.Size = new System.Drawing.Size(75, 23);
			this.BTNprocessar.TabIndex = 1;
			this.BTNprocessar.Text = "&Processar";
			this.BTNprocessar.UseVisualStyleBackColor = true;
			this.BTNprocessar.Click += new EventHandler(this.BTNprocessar_Click);
			this.TXTnumero.Location = new Point(41, 41);
			this.TXTnumero.MaxLength = 5;
			this.TXTnumero.Name = "TXTnumero";
			this.TXTnumero.Size = new System.Drawing.Size(60, 20);
			this.TXTnumero.TabIndex = 0;
			this.TXTnumero.KeyPress += new KeyPressEventHandler(this.TXTnumero_KeyPress);
			this.GPBsaida.Controls.Add(this.TXTmedia);
			this.GPBsaida.Controls.Add(this.TXTquantidade);
			this.GPBsaida.Controls.Add(this.TXTmenor);
			this.GPBsaida.Controls.Add(this.TXTmaior);
			this.GPBsaida.Controls.Add(this.LBLmedia);
			this.GPBsaida.Controls.Add(this.LBLquantidade);
			this.GPBsaida.Controls.Add(this.LBLmenor);
			this.GPBsaida.Controls.Add(this.LBLmaior);
			this.GPBsaida.Location = new Point(24, 127);
			this.GPBsaida.Name = "GPBsaida";
			this.GPBsaida.Size = new System.Drawing.Size(304, 153);
			this.GPBsaida.TabIndex = 1;
			this.GPBsaida.TabStop = false;
			this.GPBsaida.Text = "Resultados";
			this.TXTmedia.Location = new Point(162, 117);
			this.TXTmedia.Name = "TXTmedia";
			this.TXTmedia.ReadOnly = true;
			this.TXTmedia.Size = new System.Drawing.Size(100, 20);
			this.TXTmedia.TabIndex = 7;
			this.TXTquantidade.Location = new Point(162, 86);
			this.TXTquantidade.Name = "TXTquantidade";
			this.TXTquantidade.ReadOnly = true;
			this.TXTquantidade.Size = new System.Drawing.Size(100, 20);
			this.TXTquantidade.TabIndex = 6;
			this.TXTmenor.Location = new Point(162, 55);
			this.TXTmenor.Name = "TXTmenor";
			this.TXTmenor.ReadOnly = true;
			this.TXTmenor.Size = new System.Drawing.Size(100, 20);
			this.TXTmenor.TabIndex = 5;
			this.TXTmaior.Location = new Point(162, 24);
			this.TXTmaior.Name = "TXTmaior";
			this.TXTmaior.ReadOnly = true;
			this.TXTmaior.Size = new System.Drawing.Size(100, 20);
			this.TXTmaior.TabIndex = 4;
			this.LBLmedia.AutoSize = true;
			this.LBLmedia.Location = new Point(23, 120);
			this.LBLmedia.Name = "LBLmedia";
			this.LBLmedia.Size = new System.Drawing.Size(56, 13);
			this.LBLmedia.TabIndex = 3;
			this.LBLmedia.Text = "M É D I A:";
			this.LBLquantidade.AutoSize = true;
			this.LBLquantidade.Location = new Point(23, 89);
			this.LBLquantidade.Name = "LBLquantidade";
			this.LBLquantidade.Size = new System.Drawing.Size(133, 13);
			this.LBLquantidade.TabIndex = 2;
			this.LBLquantidade.Text = "QUANTIDADE de valores:";
			this.LBLmenor.AutoSize = true;
			this.LBLmenor.Location = new Point(23, 58);
			this.LBLmenor.Name = "LBLmenor";
			this.LBLmenor.Size = new System.Drawing.Size(76, 13);
			this.LBLmenor.TabIndex = 1;
			this.LBLmenor.Text = "MENOR valor:";
			this.LBLmaior.AutoSize = true;
			this.LBLmaior.Location = new Point(23, 27);
			this.LBLmaior.Name = "LBLmaior";
			this.LBLmaior.Size = new System.Drawing.Size(71, 13);
			this.LBLmaior.TabIndex = 0;
			this.LBLmaior.Text = "MAIOR valor:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(359, 291);
			base.Controls.Add(this.GPBsaida);
			base.Controls.Add(this.GPBentrada);
			base.Name = "FRMlab14";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Bloquear caracteres especiais - LAB14";
			base.Load += new EventHandler(this.FRMlab14_Load);
			this.GPBentrada.ResumeLayout(false);
			this.GPBentrada.PerformLayout();
			this.GPBsaida.ResumeLayout(false);
			this.GPBsaida.PerformLayout();
			base.ResumeLayout(false);
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