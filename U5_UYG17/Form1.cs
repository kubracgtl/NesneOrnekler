using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int sonuc)) 

            {
                ep.SetError(textBox1, "");
            }
            else
            {

                e.Cancel = true;
                ep.SetError(textBox1, "numaralı giris hatalı");
          
            }
        
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text=="")
            {
                e.Cancel = true;
                ep.SetError(textBox1, "adınızı soyadınızı giriniz");


            }
            else
            {
                ep.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            int dersnotu;
            if (int.TryParse(textBox3.Text, out dersnotu))
            {
                if (dersnotu < 0 || dersnotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(textBox3, "0-100 arasında sayı giriniz");
                }
                else
                {

                    ep.SetError(textBox3, "");

                }

            }


            else
            {
                e.Cancel = true;
                ep.SetError(textBox3, "sayısal deger giriniz");
            }
            }
        }
    }

