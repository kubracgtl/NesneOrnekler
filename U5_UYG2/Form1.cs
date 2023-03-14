using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "form uygulaması";
            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
            this.Size = new Size(300, 150);



            label1.Text = "adınız";
            label1.Location = new Point(10, 10);
            label1.Size = new Size(65, 15);
            label1.ForeColor = Color.White;




            textBox1.Location = new Point(75, 10);
            textBox1.Size = new Size(150, 15);
            textBox1.TabIndex = 1;




            button1.Text = "tıkla";
            button1.Location = new Point(100, 60);
            button1.Size = new Size(100, 30);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.TabIndex = 2;

            this.Controls.Add(label1);
            this.Controls.Add(label1);
            this.Controls.Add(label1);


            textBox1.KeyPress += TxtAdSoyad_KeyPress;
            button1.Click += BtnGiris_Click;
            


        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba" + textBox1.Text); 
        }

        private void TxtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
