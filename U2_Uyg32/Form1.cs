using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sayinin_karesi;
            try
            {
                sayi = Convert.ToInt16(textBox1.Text);
                sayinin_karesi = sayi * sayi;
                MessageBox.Show(sayinin_karesi.ToString());

            }
            catch
            {
                MessageBox.Show("hatalı giriş yaptınız");
            }

            finally
            {
            }

        }
    }
}

