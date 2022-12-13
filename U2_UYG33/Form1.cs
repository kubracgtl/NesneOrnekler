using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_UYG33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi;
            long parola;
            try
            {
                kullaniciadi = txt_kullaniciadi.Text.ToString();
                parola = long.Parse(txt_sifre.Text.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("giriş başarılı hoşgeldınız" + txt_kullaniciadi);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
