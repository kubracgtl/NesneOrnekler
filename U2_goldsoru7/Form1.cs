using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_goldsoru7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            int enb, enk;
            int deger;
            enb = Convert.ToInt32(listBox1.Items[i]);
            enk = Convert.ToInt32(listBox1.Items[i]);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                deger = Convert.ToInt32(listBox1.Items[i]);
                if (enb < deger)
                {
                    enb = deger;


                }
                else
                {
                    enk = deger;

                }
            }
            label1.Text = "en büyük sayi" + enb;
            label2.Text = "en küçük sayi" + enk;





        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();


            for (int i = 0; i < 20; i++)
            {

                listBox1.Items.Add(random.Next(100));

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();


            for (int i = 0; i < 20; i++)
            {

                listBox1.Items.Add(random.Next(100));


            }
        }

}
