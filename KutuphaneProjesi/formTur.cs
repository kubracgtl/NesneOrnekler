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
    public partial class formTur : Form
    {
        VeriTabaniİslemleri vtislemleri = new VeriTabaniİslemleri();
        MySqlConnection baglanti;
        MySqlCommand kommut;
        string komutsatiri;
        public formTur()
        {
            InitializeComponent();
        }

        private void formTur_Load(object sender, EventArgs e)
        {
            turlerilistele();
        }

        private void turlerilistele()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "select* From kitapturleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridtur.DataSource = dataTable;
                gridtur.Columns["tur_id"].HeaderText = "ID";
                gridtur.Columns["tur_id"].Width = 100;
                gridtur.Columns["tur_id"].HeaderText = "türadi";
                gridtur.Columns["tur_id"].Width = 300;

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
                if (baglanti.State!=ConnectionState.Open)
                {
                    baglanti.Open();
                }
                kommut = new MySqlCommand( );
                kommut.Connection = baglanti;
                kommut.CommandText = "INSERT INTO kitapturleri(tur_adi)VALUES(@tur_adi)";
                kommut.Parameters.AddWithValue("@tur_adi", txtturadi.Text);

                kommut.ExecuteNonQuery();
                baglanti.Close();
                txtturadi.Clear();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                turlerilistele();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
        }

        private void gridtur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridtur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtturadi.Text = gridtur.CurrentRow.Cells["tur_adi"].Value.ToString();

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
                if (baglanti.State!=ConnectionState.Open)
                {
                    baglanti.Open();
                }
                kommut = new MySqlCommand(komutsatiri,baglanti);
                kommut.Connection = baglanti;
                kommut.CommandText="DELETE FROM kitapturleri WHERE tur_id =@tur_id";
                kommut.Parameters.AddWithValue("@tur_id", gridtur.CurrentRow.Cells["tur_id"].Value.ToString());
                kommut.ExecuteNonQuery();
                baglanti.Close();
                txtturadi.Clear();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                turlerilistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK,MessageBoxIcon.Error);
              
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
                kommut = new MySqlCommand(komutsatiri,baglanti);
                kommut.Connection = baglanti;
                kommut.CommandText = "DELETE FROM kitapturleri WHERE tur_id=@tur_id";
                kommut.Parameters.AddWithValue("@tur_id)", gridtur.CurrentRow.Cells["tur_id"].Value.ToString());
                baglanti.Close();
                txtturadi.Clear();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
