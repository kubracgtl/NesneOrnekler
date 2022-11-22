using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int sayi = Convert.ToInt32(listBox1.Items[i]);
                if (sayi % 2 == 0)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rstgsayi = new Random();
            for (int i = 1; i < 20; i++)
            {
                listBox1.Items.Add(rstgsayi.Next(1, 1000));
            }
        }
    }
}

                  
            
        
    

