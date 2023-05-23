using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formOdunc : Form
    {
        VeriTabaniİslemleri vtislemleri = new VeriTabaniİslemleri();
        MySqlConnection baglanti;
        MySqlCommand kommut;
         string komutsatiri;
        public formOdunc()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void formOdunc_Load(object sender, EventArgs e)
        {
            listele();
            kitapyukle();
        }

        private void kitapyukle()
        {
            try
            {
                komutsatiri = "select * from kitaplar where  kitap_id not in (select kitap_id from odunc_kitaplar where  teslim_tarihi IS NULL";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                combokitap.DataSource = dataTable;
                combokitap.ValueMember = "kitap_id";
                combokitap.DisplayMember = "kitap_adi";


            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listele()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "select id,ogrenci_no,ad,soyad ,kitap_adi,verilis_tarihi,teslim_tarihi,aciklama" + "from  kitaplar ,ogrenciler ,odunc_kitaplar " + "where  ogr_no=ogrenci_no and kitaplar.kitap_id=odunc_kitaplar.kitap_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable datatable=new  DataTable

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
