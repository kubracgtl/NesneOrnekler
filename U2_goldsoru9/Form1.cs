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
        int sayi;
        int tutulan;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            sayi = 100;
            button2.Enabled = true;
            for (int i = 0; i < 100; i++)
            {
                tutulan = random.Next(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tahmin = Convert.ToInt32(textBox1.Text);
                if (tahmin < sayi)
                {
                    MessageBox.Show("yukarı");
                    sayi = sayi - 10;
                }
                else if (tahmin < tutulan)
                {
                    MessageBox.Show("aşagı");
                    sayi = sayi - 10;
                }
                else
                {
                    MessageBox.Show("tebrikler ayıcık kazandınız");
                }
                if (sayi == 0)
                {
                    MessageBox.Show("oyunu kaybettiniz tekrar başlayınız");
                    button2.Enabled = false;
                }
                label2.Text = sayi.ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("lütfen sayi giriniz");

                throw;
            }
        }
    }
}