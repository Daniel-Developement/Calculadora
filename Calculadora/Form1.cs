using System.Globalization;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operaction = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if(operaction == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operaction == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }else if (operaction == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperaction.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operaction = "MULTIPLICACAO";
            lblOperaction.Text = "x";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operaction = "SUBTRACAO";
            lblOperaction.Text = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operaction = "SOMA";
            lblOperaction.Text = "+";
        }
    }
}