using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiferenciacionFinita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TipoD.Items.Add("Centrada");
            TipoD.Items.Add("Hacia Atras");
            TipoD.Items.Add("Hacia Delante");
            Error.Items.Add("O(h)");
            Error.Items.Add("O(h^2)");
            Error.Items.Add("O(h^4)");
            Derivada.Items.Add("1er Derivada");
            Derivada.Items.Add("2da Derivada");
            Derivada.Items.Add("3er Derivada");
            Derivada.Items.Add("4ta Derivada");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xi = Convert.ToDouble(Xi.Text);
            double h = Convert.ToDouble(H.Text);
            double a1 = Convert.ToDouble(A1.Text);
            double a2 = Convert.ToDouble(A2.Text);
            double a3 = Convert.ToDouble(A3.Text);
            double a4 = Convert.ToDouble(A4.Text);
            double c = Convert.ToDouble(C.Text);
            double res = 0;
            string error = Error.Text;
            string derivada = Derivada.Text;
            
            Formulas F = new Formulas(xi, h, a1, a2, a3, a4, c, error, derivada);

            if(TipoD.Text == "Centrada")
            {
                res = F.FormulasCentradas();
            } 
            else if(TipoD.Text == "Hacia Atras")
            {
                res = F.FormulasAtras();
            }
            else
            {
                res = F.FormulasDelante();
            }

            Resultado.Text = Resultado.Text + " " + res;
        }
    }
}
