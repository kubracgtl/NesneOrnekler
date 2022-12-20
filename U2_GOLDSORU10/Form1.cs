using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GOLDSORU10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int kisisayisi = listBox1.Items.Count;
            for (int i = 1; i <= kisisayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                if (i % 4 == 0)
                {
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                }
                else if (i % 4 == 1)
                {
                    listBox3.Items.Add(listBox1.Items[tutulan]);
                }
                else if (i % 4 == 2)
                {
                    listBox4.Items.Add(listBox1.Items[tutulan]);
                }
                else
                {
                    listBox5.Items.Add(listBox1.Items[tutulan]);

                }
            }
        }
    }
}
