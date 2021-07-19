using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void B_seis_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "6";
            }
            
        }

        private void B_zero_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "0";
            }
            
        }

        private void B_um_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "1";
            }
            
        }

        private void B_dois_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "2";
            }
            
        }

        private void B_tres_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "3";
            }
            
        }

        private void B_quatro_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "4";
            }
            
        }

        private void B_cinco_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "5";
            }
            
        }

        private void B_sete_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "7";
            }
            
        }

        private void B_oito_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "8";
            }
            
        }

        private void B_nove_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                L_campoatual.Text += "9";
            }
            
        }

        
        private void B_Clear_Click(object sender, EventArgs e)
        {
            L_campoatual.Text = "";
            L_campoum.Text = "";
            L_sinal.Text = "";
        }

        private void B_mais_Click(object sender, EventArgs e)
        {
            var resultado = Utils.IdentificaOperacao(L_campoum.Text, L_campoatual.Text, L_sinal.Text);
            if (resultado.Length > 10)
            {
                R_Muito_G();
            }
            else if (resultado == "a")
            {

            }
            else if (resultado == "b")
            {
                L_campoum.Text = L_campoatual.Text;
                L_campoatual.Text = "";
                L_sinal.Text = "+";
            }
            else if (resultado == "c")
            {
                L_sinal.Text = "+";
            }
            else
            {
                L_campoum.Text = resultado;
                L_campoatual.Text = "";
                L_sinal.Text = "+";
            }    
        }

        private void B_menos_Click(object sender, EventArgs e)
        {
            var resultado = Utils.IdentificaOperacao(L_campoum.Text, L_campoatual.Text, L_sinal.Text);
            if (resultado.Length > 10)
            {
                R_Muito_G();
            }
            else if (resultado == "a")
            {

            }
            else if (resultado == "b")
            {
                L_campoum.Text = L_campoatual.Text;
                L_campoatual.Text = "";
                L_sinal.Text = "-";
            }
            else if (resultado == "c")
            {
                L_sinal.Text = "-";
            }
            else
            {
                L_campoum.Text = resultado;
                L_campoatual.Text = "";
                L_sinal.Text = "-";
            }
        }

        private void B_vezes_Click(object sender, EventArgs e)
        {
            var resultado = Utils.IdentificaOperacao(L_campoum.Text, L_campoatual.Text, L_sinal.Text);
            if (resultado.Length > 10)
            {
                R_Muito_G();
            }
            else if (resultado == "a")
            {

            }
            else if (resultado == "b")
            {
                L_campoum.Text = L_campoatual.Text;
                L_campoatual.Text = "";
                L_sinal.Text = "*";
            }
            else if (resultado == "c")
            {
                L_sinal.Text = "*";
            }
            else
            {
                L_campoum.Text = resultado;
                L_campoatual.Text = "";
                L_sinal.Text = "*";
            }
        }

        private void B_dividir_Click(object sender, EventArgs e)
        {
            var resultado = Utils.IdentificaOperacao(L_campoum.Text, L_campoatual.Text, L_sinal.Text);
            if (resultado.Length > 10)
            {
                R_Muito_G();
            }
            else if (resultado == "a")
            {

            }
            else if (resultado == "b")
            {
                L_campoum.Text = L_campoatual.Text;
                L_campoatual.Text = "";
                L_sinal.Text = "/";
            }
            else if (resultado == "c")
            {
                L_sinal.Text = "/";
            }
            else
            {
                L_campoum.Text = resultado;
                L_campoatual.Text = "";
                L_sinal.Text = "/";
            }
        }

        private void B_virgula_Click(object sender, EventArgs e)
        {
            if (L_campoatual.Text.Length > 10)
            {
                N_Add_N();
            }
            else
            {
                if (Utils.Tem_virgula(L_campoatual.Text))
                {
                    L_campoatual.Text += ",";

                }
            }
            
        }

        private void B_igual_Click(object sender, EventArgs e)
        {
            var resultado = Utils.Returner(L_campoum.Text, L_campoatual.Text, L_sinal.Text);
            if (resultado.Length > 10)
            {
                R_Muito_G();
            }
            else if (resultado != null)
            {
                L_campoum.Text = "";
                L_campoatual.Text = resultado;
                L_sinal.Text = "";
            }
        }

        private void B_Rquadrada_Click(object sender, EventArgs e)
        {
            var resultado = Utils.CRQuad(L_campoum.Text, L_campoatual.Text, L_sinal.Text);
            if (resultado.Length > 10)
            {
                R_Muito_G();
            }
            else if (resultado != null)
            {
                L_campoum.Text = "";
                L_campoatual.Text = resultado;
                L_sinal.Text = "";
            }
        }

        private void N_Add_N()
        {
            MessageBox.Show("Não é Possivel Digitar mais Números!!!!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void R_Muito_G()
        {
            MessageBox.Show("O Resultado da Ultima conta é muito Grande!!!!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }
}
