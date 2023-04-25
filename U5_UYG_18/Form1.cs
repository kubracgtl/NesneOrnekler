using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG_18
{
    public partial class Form1 : Form
    {
       
    
    public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int sonuc))
            {
                ep.SetError(textBox1, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(textBox1, "Numara girişi hatalı");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
 {
                e.Cancel = true;
                ep.SetError(textBox2, "Adı ve soyadı giriniz.");
            }
 else
            {
                ep.SetError(textBox2, "");
            }
        }
    }
    }
    }

