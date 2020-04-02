using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB09
{
    public partial class FRMlab09 : Form
    {
        // área inicial do formulário para declarações globais/públicas.
        float numero1, numero2;
        double result;
        // acima: variáveis que serão usadas por todos os clicks dos botões.

        public FRMlab09()
        {
            InitializeComponent();
        }

        private bool valida_entrada() // função não associada a objeto/evento,
        {                             // que retorna um valor lógico (boolean).
            try
            {
                numero1 = float.Parse(TXTnumero1.Text);
                numero2 = float.Parse(TXTnumero2.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("ERRO!  Campos vazios ou não numéricos.  Redigite.");
                BTNlimpar.PerformClick();       
                return false;
            }
        }

        private void saida(Color cor) // função não associada a objeto/evento.
        {
            // Recebe parâmetro  COR  que é usado no segundo comando abaixo.
            // Este parâmetro é do tipo  Color e seu valor é dado por  Color.nome_da_cor 
            LBLsaida.Text = result.ToString();
            LBLsaida.BackColor = cor;
            TXTnumero1.Focus();
        }

        private void FRMlab09_Load(object sender, EventArgs e)
        {
            // para procedimentos iniciais do formulário.
            BTNlimpar.PerformClick();
        }

        private void TXTnumero1_TextChanged(object sender, EventArgs e)
        {
            // Programar o evento "TextChanged" é uma alternativa interessante.
            // A função valida_entrada() pode ser chamada daqui ao invés de sê-lo
            // no evento Click dos botões de cálculo. Neste caso é necessário
            // adaptar o controle de retorno (true ou false) e tratar cada campo
            // TXTvalor1 e TXTvalor2 separadamente, com mensagens de erro personalidadas.
        }

        private void TXTnumero2_TextChanged(object sender, EventArgs e)
        {
            // Aqui valem as mesmas observações da função acima.
        }

        private void BTNsoma_Click(object sender, EventArgs e)
        {
            if (valida_entrada())
            {
                // cálculo específico deste "objeto_evento"
                result = (double)(numero1 + numero2);
                saida(Color.Silver);
            }
        }


        private void BTNsubtracao_Click(object sender, EventArgs e)
        {
            if (valida_entrada())
            {
                // cálculo específico deste "objeto_evento"
                result = (double)(numero1 - numero2);
                saida(Color.Green);
            }
        }

        private void BTNmultiplicacao_Click(object sender, EventArgs e)
        {
            if (valida_entrada())
            {
                // cálculo específico deste "objeto_evento"
                result = (double)(numero1 * numero2);
                saida(Color.Blue);
            }
        }

        private void BTNdivisao_Click(object sender, EventArgs e)
        {
            if (valida_entrada())
            {
                // cálculo específico deste "objeto_evento"
                if (numero2 == 0)
                {
                    LBLresultado.Text = "erro:div_0";
                    LBLresultado.BackColor = Color.Salmon;
                }
                else
                {
                    result = (double)(numero1 / numero2);
                    saida(Color.Red);
                }
            }
        }

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            // Iniciamos com zero, ao invés de  TXTnumero1.Clear();
            TXTnumero1.Text = "0";
            TXTnumero2.Text = "0";
            LBLsaida.Text = "";
            LBLsaida.BackColor = Color.Beige;
        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            // Fechar o programa
            this.Close();
        }
    }
}
