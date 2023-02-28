using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_UYG13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numaralarlist = new List<int>();
        List<string> adsoyadlist = new List<string>();
        List<Ogrenciler> ogrenciler = new List<Ogrenciler>();
        private void button1_Click(object sender, EventArgs e)
        {
            numaralarlist.Add(int.Parse(textBox1.Text));
            listBox1.Items.Clear();
            foreach (var item in numaralarlist)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
