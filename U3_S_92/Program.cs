using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_92
{
    class Kisi
    {
        int yas;
        string ad;
        public Kisi()
        {
            yas = 19;
            ad = "ahmet";
            Console.WriteLine("yapıcı metot çslıştı");
        }
        public int Yas
        {
            get
            {
                return yas;


            }
            
        }
        public string Ad
        {
            get
            {
                return ad;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM BAŞLADI");
            Kisi k = new Kisi();
            Console.WriteLine("adı:{0},yaşı {1}",k.Ad,k.Yas);
            Console.WriteLine("program bitti");
            Console.ReadLine();

        }
    }
}
