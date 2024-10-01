using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private double valor;
        private string operacao = "";
        private void buttonSoma_Click(object sender, EventArgs e)
        {
            valor = double.Parse(text.Text);
            operacao = "+";
            text.Clear();
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            double valor2 = double.Parse(text.Text);
            double resultado = 0;

            if (operacao == "+")
            {
                resultado = valor + valor2;
            }
            if (operacao == "/")
            {
                resultado = valor / valor2;
            }
            if (operacao == "-")
            {
                resultado = valor - valor2;
            }
            if (operacao == "*")
            {
                resultado = valor * valor2;
            }
            text.Text = resultado.ToString();
        }

        private void buttonSubtrai_Click(object sender, EventArgs e)
        {
            valor = double.Parse(text.Text);
            operacao = "-";
            text.Clear();
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            valor = double.Parse(text.Text);
            operacao = "/";
            text.Clear();
        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {
            valor = double.Parse(text.Text);
            operacao = "*";
            text.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            text.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmCelsius frmTeste = new frmCelsius();
            frmTeste.ShowDialog();
        }

        private void celsiusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCelsius frmTeste = new frmCelsius();
            frmTeste.ShowDialog();
        }

        private void fahrenheitParaCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
