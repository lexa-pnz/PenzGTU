﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Mil_Km : Form
    {
        public Mil_Km()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*private void Mil_Km_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',')
            { 
                if (textBox1.Text.IndexOf(',') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }

            e.Handled = true;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            double mile;
            double km;

            try
            {
                mile = Convert.ToDouble(textBox1.Text);

                km = mile * 1.609344;

                label2.Text = km.ToString("n") + "км";
            }

            catch
            {
                textBox1.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
