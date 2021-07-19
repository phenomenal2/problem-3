using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intertoroman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.ResetText();
            int number = Convert.ToInt32(textBox1.Text);

            if (number.ToString().Trim().Length == 0)
                return;

            if (number >= 4000)
            {
                MessageBox.Show("Please enter a number that is less than 4000.",
                                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBox1.Focus();
                return;
            }
            
            String[] roman = new String[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] decimals = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string romanvalue = String.Empty;

            for (int i = 0; i < 13; i++)
            {
                while (number >= decimals[i])
                {
                    number -= decimals[i];
                    romanvalue += roman[i];
                }
            }

            label2.Text = romanvalue;
        }
    }
}
