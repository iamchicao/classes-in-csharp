using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB12
{
    public partial class LAB12 : Form
    {
        public LAB12()
        {
            InitializeComponent();
        }

        private void BTNprocessar_Click(object sender, EventArgs e)
        {
            var Nome = TXTnome.Text;
            var Telefone = TXTnome.Text;
            var Endereco = TXTendereco.Text;
            var Sexo = "Sexo não definido";
            if (RBTmasculino.Checked)
            {
                Sexo = "Masculino";
            }
            else if(RBTfeminino.Checked)
            {
                Sexo = "Feminino";
            }
            LTBsaida.Text = Sexo;

            var Estado = "Não informado";
            if (RBTsolteiro.Checked)
            {
                Estado = "Solteiro(a)";
            }
            else if(RBTsolteiro.Checked)
            {
                Estado = "Solteiro(a)";
            }
            else if (RBTseparado.Checked)
            {
                Estado = "Separado(a)";
            }
            else if (RBTdivorciado.Checked)
            {
                Estado = "Divorciado(a)";
            }
            else if (RBTviuvo.Checked)
            {
                Estado = "Viúvo(a)";
            }
            else if (RBToutro.Checked)
            {
                Estado = "Outro";
            }

            // Inclui nome no LTBsaida
            LTBsaida.Items.Add("Nome: " + TXTnome.Text);
            // Inclui endereço no LTBsaida
            LTBsaida.Items.Add("Endereço: " + TXTendereco.Text);
            // Inclui telefone no LTBsaida
            LTBsaida.Items.Add("Telefone: " + MTBtelefone.Text);
            // Inclui sexo no LTBsaida
            // se radioButton 1 marcado
            if (RBTfeminino.Checked)
                LTBsaida.Items.Add("Sexo: Feminino");
            else// senão
                // radioButton2 marcado
            if (RBTmasculino.Checked) // se radioButton2 marcado
                LTBsaida.Items.Add("Sexo: Masculino");
            else //senão
                LTBsaida.Items.Add("Sexo: não declarado");

            // Inclui estado civil no LTBsaida
            // inclui a quantidade de filhos
            // se checkBox1 marcado
            if (CKBpossuifilhos.Checked)
                LTBsaida.Items.Add("Quantidade de filhos: " + TXTfilhos.Text);
            else // senão
                LTBsaida.Items.Add("Não possui filhos");
            // Inclui uma linha
            LTBsaida.Items.Add("-------------------------------------------------");
        }

        private void RBTmasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBLquantos.Visible = false;
            TXTfilhos.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            // Limpa a caixa de Lista
            LTBsaida.Items.Clear();
            // Limpa entradas
            TXTnome.Text = "";
            TXTendereco.Text = "";
            MTBtelefone.Text = "";
            RBTfeminino.Checked = false;
            RBTmasculino.Checked = false;
            RBTsolteiro.Checked = false;
            RBTsolteiro.Checked = false;
            RBTseparado.Checked = false;
            RBTdivorciado.Checked = false;
            RBTviuvo.Checked = false;
            RBToutro.Checked = false;
            CKBpossuifilhos.Checked = false;
            LBLquantos.Visible = false;
            // volta o cursor para textBox1
            TXTnome.Focus();
        }

        private void CKBpossuifilhos_CheckedChanged(object sender, EventArgs e)
        {
            {
                // se checkBox Possui Filhos marcado
                if (CKBpossuifilhos.Checked)
                {
                    LBLquantos.Visible = true; // visível
                    TXTfilhos.Visible = true;
                }
                else // senão marcado
                {
                    LBLquantos.Visible = false; // invisível
                    TXTfilhos.Visible = false;
                    TXTfilhos.Text = "";
                }
            }
        }

        private void RBTseparado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTdivorciado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTviuvo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBToutro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTcasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBTsolteiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LTBsaida_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LBquantos_Click(object sender, EventArgs e)
        {
            LBLquantos.Visible = false;
        }

        private void TXTfilhos_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
