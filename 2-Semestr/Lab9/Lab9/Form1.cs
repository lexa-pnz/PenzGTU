using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        bool check1;
        bool check2;
        bool check3;
        bool check4;
        bool check5;
        bool check6;
        bool check7;
        bool check8;

        private void checks()
        {
            if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pn = Convert.ToDouble(textBox1.Text);
                double vt = Convert.ToDouble(textBox2.Text);
                double sr = Convert.ToDouble(textBox4.Text);
                double cht = Convert.ToDouble(textBox3.Text);
                double pt = Convert.ToDouble(textBox6.Text);
                double sb = Convert.ToDouble(textBox5.Text);
                double vs = Convert.ToDouble(textBox7.Text);
                double price = Convert.ToDouble(textBox8.Text);
                double fin_price;

                label11.Text = (pn * price).ToString("n") + "р.";
                label12.Text = (vt * price).ToString("n") + "р.";
                label13.Text = (sr * price).ToString("n") + "р.";
                label14.Text = (cht * price).ToString("n") + "р.";
                label15.Text = (pt * price).ToString("n") + "р.";

                label16.Text = (sb * 0.8 * price).ToString("n") + "р.";
                label17.Text = (vs * 0.8 * price).ToString("n") + "р.";

                fin_price = (pn + vt + sr + cht + pt + sb*0.8 + vs*0.8) * price;
                label9.Text = fin_price.ToString("n") + "р.";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
                check1 = false;
            else
                check1 = true;

            checks();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                check2 = false;
            else
                check2 = true;

            checks();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
                check4 = false;
            else
                check4 = true;

            checks();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
                check3 = false;
            else
                check3 = true;

            checks();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 0)
                check6 = false;
            else
                check6 = true;

            checks();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0)
                check5 = false;
            else
                check5 = true;

            checks();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == 0)
                check7 = false;
            else
                check7 = true;

            checks();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 0)
                check8 = false;
            else
                check8 = true;

            checks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            label9.Text = "";

            label11.Text = "0,00";
            label12.Text = "0,00";
            label13.Text = "0,00";
            label14.Text = "0,00";
            label15.Text = "0,00";
            label16.Text = "0,00";
            label17.Text = "0,00";

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
