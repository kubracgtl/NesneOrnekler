using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav2023_2donem_2yazılı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeriTabaniİslemleri vtislemleri = new VeriTabaniİslemleri();
        MySqlConnection baglanti;
        MySqlCommand kommut;
        string komutsatiri;
        int id;


        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "select * From urunler";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable datatable = new DataTable();
                dataAdapter.Fill(datatable);
                datagrid.DataSource = datatable;
                datagrid.Columns["id"].HeaderText = "id";
                datagrid.Columns["urun_adi"].HeaderText = "Ürün Adı";
                datagrid.Columns["fiyat"].HeaderText = "Fiyat";
                datagrid.Columns["adet"].HeaderText = "Adet";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "INSERT INTO urunler (adet,urun_adi,fiyat) VALUES (@fiyat,@urun_adi,@adet)";
                kommut = new MySqlCommand(komutsatiri, baglanti);
           
                kommut.Parameters.AddWithValue("@adet",int.Parse( txtadett.Text.ToString()));
                kommut.Parameters.AddWithValue("@urun_adi",txturunadi.Text);
                kommut.Parameters.AddWithValue("@fiyat", int.Parse(txtfiyat.Text.ToString()));
                
               
                kommut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

            private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "DELETE FROM urunler WHERE id=@id";
                kommut = new MySqlCommand(komutsatiri, baglanti);
                kommut.Parameters.AddWithValue("@id", datagrid.CurrentRow.Cells["id"].Value.ToString());
                kommut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void temizle()
        {

            txtfiyat.Clear();
            txturunadi.Clear();
            txtadett.Clear();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "UPDATE urunler  SET adet=@adet,urun_adi=@urun_adi,fiyat=@fiyat where id=@id";
                kommut = new MySqlCommand(komutsatiri, baglanti);
                kommut.Parameters.AddWithValue("@fiyat", int.Parse(datagrid.CurrentRow.Cells["fiyat"].Value.ToString()));
                kommut.Parameters.AddWithValue("@urun_adi", txturunadi);

                kommut.Parameters.AddWithValue("@adet", int.Parse(txtadett.Text.ToString()));
              
                kommut.ExecuteNonQuery();
                temizle();
                baglanti.Close();
                MessageBox.Show("işlem  başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
