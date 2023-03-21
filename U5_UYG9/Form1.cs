using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_UYG9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kESToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kOPYALAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yAPIŞTIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void kESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kOPYALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yAPIŞTIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("çıkmak istedigine eminmisiniz", "çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (cevap == DialogResult.Yes)
            {


                Application.Exit();
            }
        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text dosyası|*.txt|tümdosyalar|*.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void aÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "text dosyaları| *txt | Tüm Dosyalar |*.*";
            DialogResult cevap = opn.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                richTextBox1.LoadFile(opn.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void yAZDIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog prn = new PrintDialog();
            DialogResult cevap = prn.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                printDocument1.Print();


            }
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }
    }
}

    

