using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(textBox1, "adınızı giriniz");
            tt.SetToolTip(textBox2, "soyadınızı giriniz");
            tt.SetToolTip(textBox3, "dogum tarihinizi giriniz");
            tt.SetToolTip(textBox4, "adresinizi giriniz");

            tt.SetToolTip(button1, "Kaydetmek için tıklayınız.");
        }
    }
}
