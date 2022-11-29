using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo, boy, kiloboyi;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            kiloboyi = kilo / (boy + boy);
            if (kiloboyi < 18)
            {
                MessageBox.Show("zayıf");

            }
            else if (kiloboyi >= 18 && kiloboyi < 25)
            {
                MessageBox.Show("normal");
            }

             if (kiloboyi >= 25 && kiloboyi < 30)
            {
                MessageBox.Show("kilolu");
            }
             if (kiloboyi >= 30 && kiloboyi < 35)
            {
                MessageBox.Show("obez");
            }
            else
            {
                MessageBox.Show("çok cıddı obez");
            }


        }
    }
}
