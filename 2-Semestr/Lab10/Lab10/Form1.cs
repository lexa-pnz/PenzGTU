using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a = 0, b = 0, c = 0;
        char znak = ' ';

        private void Number_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += (sender as Button).Text;
                label1.Text += (sender as Button).Text;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignClick(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
                label1.Text += (sender as Button).Text[0];
                textBox1.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Equally(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(textBox1.Text);
                switch (znak)
                {
                    case '+':
                        c = a + b;
                        break;
                    case '-':
                        c = a - b;
                        break;
                    case '*':
                        c = a * b;
                        break;
                    case '/':
                        c = a / b;
                        break;
                }
                textBox1.Text = c.ToString();
                label1.Text += " = " + c + " ";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void PlusAndMinus(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0,1);
                else
                    textBox1.Text = '-' + textBox1.Text;
            }
        }

        private void Remove(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }
    }
}
