using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sehirler> listSehirler = new List<Sehirler>();

        private void button1_Click(object sender, EventArgs e)
        {
            Sehirler sehir = new Sehirler();
            sehir.Plaka = textBox1.Text;
            sehir.sehiradı = textBox2.Text;
            listSehirler.Add(sehir);
            bagla();

        }

        private void bagla()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = listSehirler;
            comboBox1.DisplayMember = "sehiradı";
            comboBox1.ValueMember = "plaka";
        }
    }
}
