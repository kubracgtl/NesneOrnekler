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

namespace KutuphaneProjesi
{
    public partial class formOgrenci : Form
    {
        VeriTabaniİslemleri vtislemleri = new VeriTabaniİslemleri();
        MySqlConnection baglanti;
        MySqlCommand kommut;
        string komutsatiri;
        public formOgrenci()
        {
            InitializeComponent();
        }

        private void formOgrenci_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "select * From ogrenciler";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable datatable = new DataTable();
                dataAdapter.Fill(datatable);
                gridogrenci.DataSource = datatable;
                gridogrenci.Columns["ogrenci_no"].HeaderText = "Öğrenci No";
                gridogrenci.Columns["ad"].HeaderText = "Ad";
                gridogrenci.Columns["soyad"].HeaderText = "Soyad";
                gridogrenci.Columns["sinif"].HeaderText = "Sınıf";
                gridogrenci.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                gridogrenci.Columns["telefon"].HeaderText = "Telefon";

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
                komutsatiri = "DELETE FROM ogrenciler WHERE ogrenci_no=@no";
                kommut = new MySqlCommand(komutsatiri, baglanti);
                kommut.Parameters.AddWithValue("@no", gridogrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString());
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "INSERT INTO ogrenciler (ogrenci_no,ad ,soyad,sinif,cinsiyet,telefon) VALUES (@no,@ad,@soyad,@sinif,@cinsiyet,@telefon)";
                kommut = new MySqlCommand(komutsatiri, baglanti);
                kommut.Parameters.AddWithValue("@no", int.Parse(txtno.Text.ToString()));
                kommut.Parameters.AddWithValue("@ad", txtad.Text);
                kommut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                kommut.Parameters.AddWithValue("@sinif", int.Parse(combosinif.SelectedItem.ToString()));
                kommut.Parameters.AddWithValue("@cinsiyet", combocinsiyet.SelectedItem.ToString());
                kommut.Parameters.AddWithValue("@telefon", txttelefon.Text);
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

        private void temizle()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txtno.Clear();
            txttelefon.Clear();

        }

        private void gridogrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtno.Text = gridogrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
                txtad.Text = gridogrenci.CurrentRow.Cells["ad"].Value.ToString();
                txtsoyad.Text = gridogrenci.CurrentRow.Cells["soyad"].Value.ToString();
                txttelefon.Text = gridogrenci.CurrentRow.Cells["telefon"].Value.ToString();
                combosinif.SelectedItem = gridogrenci.CurrentRow.Cells["sinif"].Value.ToString();
                combocinsiyet.SelectedItem = gridogrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("hata oluştu", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "UPDATE ogrenciler  SET ad=@ad,soyad=@soyad,sinif=@sinif,cinsiyet=@cinsiyet,telefon=@telefon where ogrenci_no=@no";
                kommut = new MySqlCommand(komutsatiri, baglanti);
                kommut.Parameters.AddWithValue("@no", int.Parse(gridogrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString()));
                kommut.Parameters.AddWithValue("@ad", txtad);
                kommut.Parameters.AddWithValue("@soyad", txtsoyad);
                kommut.Parameters.AddWithValue("@sinif", int.Parse(combosinif.SelectedItem.ToString()));
                kommut.Parameters.AddWithValue("@cinsiyet", combocinsiyet.SelectedItem.ToString());
                kommut.Parameters.AddWithValue("@telefon", txttelefon);
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

        private void txtogrenciara_TextChanged(object sender, EventArgs e)
        {
            OgrenciArama(txtogrenciara.Text);
        }

        public void OgrenciArama(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();

                }
                kommut = new MySqlCommand();
                kommut.Connection = baglanti;
                kommut.CommandText = "select * from ogrenciler WHERE ad LIKE '" + aranacakKelime + "'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(kommut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridogrenci.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
