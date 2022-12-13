using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GOLDSORU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = ("matematik");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = ("türkçe");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = ("nesne taban");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = ("robotik kodlama");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int not1, not2, not3, ortalama;
                not1 = Convert.ToInt16(textBox1.Text);
                not2 = Convert.ToInt16(textBox2.Text);
                not3 = Convert.ToInt16(textBox3.Text);
               
                if (not1>100 || not1<0 || not2>100 ||not2<0 || not3<100||not3<0)
                {
                    MessageBox.Show("100 den küçük sayı giriniz");
                }
                else
                {
                    ortalama = (not1 + not2 + not3) / 3;
                    label3.Text = ortalama.ToString();
                }
            }
            catch
            {
                MessageBox.Show("hatalı giriş yaptınız");
            }

        }
    }
}
