using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==2)
            {
                TXTBİLGİ.Text = "";
                TXTBİLGİ.Text+=textBox1.Text+"\r\n";
                TXTBİLGİ.Text+=textBox2.Text+"\r\n";
                TXTBİLGİ.Text+=textBox3.Text+"\r\n";
                decimal hesap = 0;
                if (ncorba.Value > 0)
                {
                    hesap += ncorba.Value * 50;
                    TXTBİLGİ.Text += string.Format("Çorba {0:C}", ncorba.Value * 50) + "\r\n";
                }
                else if (nsalataa.Value > 0)
                {
                    hesap += nsalataa.Value * 20;
                    TXTBİLGİ.Text += string.Format("salata{0:c}", nsalataa.Value * 20);
                }
                else if (nanayemek.Value >0)
                {
                    hesap += nanayemek.Value * 100;
                    TXTBİLGİ.Text += string.Format("anayemek{0:c}", nanayemek.Value * 100);

                }
                else
                {
                    hesap += ntatlı.Value * 40;
                    TXTBİLGİ.Text += string.Format("tatlı{0:c}", ntatlı.Value * 40);
                }
                TXTBİLGİ.Text += "-----------------";
                TXTBİLGİ.Text += string.Format("Toplam {0:C}", hesap);
            }
        }
    }
}
