using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_goldsoru9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random;
            int sayi;
            for (int i = 0; i < 100; i++)
            {
                sayi = random.Next(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deger;
            int skor;
            skor = 100;
            deger = Convert.ToInt32(textBox1.Text);
            skor = Convert.ToInt32(label1.Text);
            if (sayi<deger)
            {
                MessageBox.Show("yukarı");
                skor - 10;

            }
            else
            {
                MessageBox.Show("aşagı");
            }
        }
    }
}
