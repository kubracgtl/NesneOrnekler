using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GOLDSORU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 1000; i++)
                
            {
                Random rstgsayi = new Random();
                pictureBox1.Left = pictureBox1.Left + rstgsayi.Next(1, 20);
                    
                pictureBox2.Left = pictureBox2.Left+rstgsayi.Next (1,20);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
