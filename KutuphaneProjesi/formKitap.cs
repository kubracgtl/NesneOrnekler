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
    public partial class formKitap : Form
    {
        public formKitap()
        {
            InitializeComponent();
        }
       VeriTabaniİslemleri vtislemleri = new VeriTabaniİslemleri();
        MySqlConnection baglanti;
        MySqlCommand kommut;
        string komutsatiri;
        private void formKitap_Load(object sender, EventArgs e)
        {
            kitapturyukle();
            kitaplistele();
        }

        private void kitaplistele()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "select kitap_id,tur_id,kitap_adi,yazar,yayinevi,sayfasayisi From kitaplar ,kitapturleri where  kitaplar.tur_id=kitapturleri.tur_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridkitap.DataSource = dataTable;
                gridkitap.Columns["kitapi_id"].HeaderText = "ID";
                gridkitap.Columns["kitapi_id"].Width = 20;
                gridkitap.Columns["kitapi_id"].HeaderText = "tür";
                gridkitap.Columns["kitapi_id"].Width = 30;
                gridkitap.Columns["kitapi_id"].HeaderText = "adı";
                gridkitap.Columns["kitapi_id"].Width = 90;
                gridkitap.Columns["kitapi_id"].HeaderText = "yazar";
                gridkitap.Columns["kitapi_id"].Width = 80;
                gridkitap.Columns["kitapi_id"].HeaderText = "yayinevi";
                gridkitap.Columns["kitapi_id"].Width = 80;
                gridkitap.Columns["kitapi_id"].HeaderText = "sayfasayisi";
                gridkitap.Columns["kitapi_id"].Width = 50;
            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void kitapturyukle()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "SELECT * FROM kitapturleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                combotur.DataSource = dataTable;
                combotur.ValueMember = "tur_adi";
                combotur.DisplayMember = "tur_adi";

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
                kommut = new MySqlCommand();
                kommut.Connection = baglanti;
                kommut.CommandText = "INSERT INTO kitaplar(tur_id,kitap_adi,yazar,yayievi,sayfasayisi" + "values(@tur_adi,@kitap_id,@yazar,@yayinevi,@sayfasayisi)";
                kommut.Parameters.AddWithValue("@tur_id", int.Parse(combotur.SelectedValue.ToString()));
                kommut.Parameters.AddWithValue("@kitap_id", txtkitapadi.Text);
                kommut.Parameters.AddWithValue("@yazar", txtyazar.Text);
                kommut.Parameters.AddWithValue("@yayinevi", txtyayınevi.Text);
                kommut.Parameters.AddWithValue("@sayfasayisi", int.Parse(txtsayfasayisi.Text));
                kommut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
        }

        private void temizle()
        {
            txtkitapadi.Clear();
            txtsayfasayisi.Clear();
            txtyayınevi.Clear();
            txtyazar.Clear();
        }

        private void gridkitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtkitapadi.Text = gridkitap.CurrentRow.Cells["kitap_adi"].Value.ToString();
                txtsayfasayisi.Text = gridkitap.CurrentRow.Cells["sayfasayisi"].Value.ToString();
                txtsayfasayisi.Text = gridkitap.CurrentRow.Cells["yayinevi"].Value.ToString();
                txtsayfasayisi.Text = gridkitap.CurrentRow.Cells["yazar"].Value.ToString();
                txtsayfasayisi.Text = gridkitap.CurrentRow.Cells["tur_adi"].Value.ToString();
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
                if (baglanti.State!= ConnectionState.Open)
                {
                    baglanti.Open();
                }
                kommut = new MySqlCommand();
                kommut.Connection = baglanti;
                kommut.CommandText = "DELETE FROM kitaplar WHERE kitap_id=@kitap_id";
                kommut.Parameters.AddWithValue("@kitap_id", gridkitap.CurrentRow.Cells["kitap_id"].Value.ToString());
                kommut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                kitaplistele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State!=ConnectionState.Open)
                {
                    baglanti.Open();
                }
                kommut = new MySqlCommand();
                kommut.Connection = baglanti;
                kommut.CommandText = "UPDATE kitaplar SET tur_id=@tur_id,kitap_adi=@kitap_adi," + "yazar=@yazar,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,where kitap_id=@kitap_id";
                kommut.Parameters.AddWithValue("@kitap_id", int.Parse(gridkitap.CurrentRow.Cells["kitap_id"].Value.ToString()));
                kommut.Parameters.AddWithValue("@tur_id", int.Parse(combotur.SelectedValue.ToString()));
                kommut.Parameters.AddWithValue("@kitap_adi", txtkitapadi.Text);
                kommut.Parameters.AddWithValue("@yazar", txtyazar.Text);
                kommut.Parameters.AddWithValue("@yayinevi", txtyayınevi.Text);
                kommut.Parameters.AddWithValue("@sayfasayisi", int.Parse(txtsayfasayisi.Text));
                kommut.ExecuteNonQuery();
                baglanti.Close();
                temizle();
                MessageBox.Show("işlem basarili", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                kitaplistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
        }

        private void txtogrenciara_TextChanged(object sender, EventArgs e)
        {
            kitaparama(txtkitapara.Text);
        }

        private void kitaparama(string aranacakkelime)
        {
            try
            {
                if (baglanti.State!=ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "select kitap_id,tur_id,yazar,yayinevi,sayfa_sayisi From kitaplar,kitapturleri" + "where  kitaplar.tur_id=kitapturleri.tur_id and  kitap_adi LIKE :'" + aranacakkelime + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridkitap.DataSource = dataTable;
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);  
              
            }
        }
    }
}
