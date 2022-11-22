using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_UYG25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double us;
            double kuvvet;
            us = Convert.ToDouble(textBox1.Text);
            for (int i = 0; i < us; i++)      
            {
                kuvvet = Math.Pow(10, i);
                listBox1.Items.Add(kuvvet);
            }
        }
    }
}
