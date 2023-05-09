using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace KutuphaneProjesi
{
    class VeriTabaniİslemleri
    {
        String baglanticümlesi = ConfigurationManager.ConnectionStrings["kutuphanebaglantıcümlesi"].ConnectionString;
        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection(baglanticümlesi);
            MySqlConnection.ClearPool(baglanti);

            return baglanti;


        }
    }
}
