using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkitap_Click(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.ShowDialog();

        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            formOgrenci ogrenci = new formOgrenci();
            ogrenci.ShowDialog();
        }

        private void btntur_Click(object sender, EventArgs e)
        {
            formTur tur = new formTur();
            tur.ShowDialog();
        }

        private void btnodunc_Click(object sender, EventArgs e)
        {
            formOdunc odunc = new formOdunc();
            odunc.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
