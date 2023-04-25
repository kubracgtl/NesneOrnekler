﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("numara", typeof(int));
            tablo.Columns.Add("ad soyad", typeof(string));
            tablo.Columns.Add("notu", typeof(int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numara = int.Parse(textBox1.Text);
            string adsoyad = textBox2.Text;
            int notu = int.Parse(textBox3.Text);
            tablo.Rows.Add(numara, adsoyad, notu);
            bagla();
        }

        private void bagla()
        {
            listegrid.DataSource = tablo;
        }
    }
}
