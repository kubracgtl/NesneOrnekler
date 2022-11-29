using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_UYG26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == "hopörler" ||
                   listBox1.Items[i].ToString() == "mikrofon" ||
                    listBox1.Items[i].ToString() == "monitör")
                { listBox2.Items.Add(listBox2.Items[i]);
                }
                else
                {
                    listBox3.Items.Add(listBox2.Items[i]);
                }


                }
        }
    }
}
