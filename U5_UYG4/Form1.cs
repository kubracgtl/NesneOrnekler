using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoHome();

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            listBox1.Items.Add(webBrowser2.Url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }
    }
}
