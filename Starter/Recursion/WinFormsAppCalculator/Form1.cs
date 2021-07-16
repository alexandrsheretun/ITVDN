using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operand1, operand2;
            int.TryParse(TB1.Text, out operand1);
            int.TryParse(TB2.Text, out operand2);
            if (Mod.Checked == true)
            {
                TB3.Text = Convert.ToString(operand1 % operand2);
            }
            else if (Deg.Checked == true)
            {
                TB3.Text = Convert.ToString(Math.Pow(operand1, operand2));
            }
            else if (Con.Checked == true)
            {
                for (int i = operand2; i != 0; i /= 10)
                {
                    operand1 *= 10;
                    operand1 += operand2;
                }

                TB3.Text = Convert.ToString(Math.Pow(operand1, operand2));
            }
            else if (Div.Checked == true)
            {
                TB3.Text = Convert.ToString(operand1 / operand2);
            }
        }
    }
}
