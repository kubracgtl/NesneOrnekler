using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte yuzde;
            try
            {
                yuzde = Convert.ToByte(textBox1.Text);
                progressBar1.Value = yuzde;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
