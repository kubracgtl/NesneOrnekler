using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenciler> liste = new List<Ogrenciler>();
      
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.numara = int.Parse(textBox1.Text);
            ogrenci.adsoyad = textBox2.Text;
            ogrenci.dersnotu = int.Parse(textBox3.Text);
            liste.Add(ogrenci);
            bagla();

                
        }

        private void bagla()
        {
            listegrid.DataSource = null;
            listegrid.DataSource = liste;

        }

        private void listegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = listegrid.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = listegrid.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = listegrid.CurrentRow.Cells[2].Value.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
