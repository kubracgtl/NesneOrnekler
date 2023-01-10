using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_100
{
    class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        class Ogretmen : OkulPersoneli
        {
            public string Brans { get; set; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                OkulPersoneli per = new OkulPersoneli();
                Ogretmen ogrt = new Ogretmen();
                ogrt.Ad = "serkan";
                ogrt.Soyad = "aydın";
                ogrt.Brans = "bilişim";
                Console.WriteLine("ögretmen sınıfından türetilen {0} {1}{2}", ogrt.Ad, ogrt.Soyad, ogrt.Brans);

                per.Ad = "perihan";
                per.Soyad = "altuntug";
                Console.WriteLine("personel sınıfından türetilen {0} {1}{2}", per.Ad, per.Soyad);
                Console.ReadLine();


            }
        }

    }
}