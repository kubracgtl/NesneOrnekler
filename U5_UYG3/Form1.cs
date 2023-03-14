using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            decimal cpufiyat = 0;
            if (radioButton1.Checked)
            {
                cpufiyat = 300;

            }
            else if(radioButton2.Checked)
            {
                cpufiyat = 200;
            }
            else if(radioButton3.Checked)
            {
                cpufiyat = 100;

            }
            else if(radioButton4.Checked)
            {
                cpufiyat = 250;
            }
            else if(radioButton5.Checked)
            {
                cpufiyat = 150;
            }
            tabanFiyat += cpufiyat;
            decimal ramfiyat = 0;
            if (radioButton6.Checked)
            {
                ramfiyat = 125;

            }
            else if(radioButton7.Checked)
            {
                ramfiyat = 75;

            }
            else if(radioButton8.Checked)
            {
                ramfiyat = 45;
            }
            tabanFiyat += ramfiyat;
            MessageBox.Show(string.Format("toplam fiyat={0:C}", tabanFiyat));

            decimal sabitdiskfiyat = 0;
            if (radioButton9.Checked)
            {
                sabitdiskfiyat = 600;
            }
            else if(radioButton10.Checked)
            {
                sabitdiskfiyat = 450;
            }
            else if(radioButton11.Checked)
            {
                sabitdiskfiyat = 300;
            }
            tabanFiyat += sabitdiskfiyat;
            MessageBox.Show(string.Format("toplam fiyat={0:C}", tabanFiyat));

            decimal ekdonanimfiyat = 0;
            if (checkBox1.Checked)
            {
                ekdonanimfiyat = 1000;

            }
            else if (checkBox2.Checked) 
            {
                ekdonanimfiyat = 500;
            }
            else 
            {
                ekdonanimfiyat = 300;
            }
            tabanFiyat += ekdonanimfiyat;
            MessageBox.Show(string.Format("toplam fiyat={0:C}", tabanFiyat));
        }

    }
}
