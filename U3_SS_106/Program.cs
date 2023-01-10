using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_106
{
    public abstract class Kütüphane
    {
        public string Kitapadi { get; set; }
        public string dergiadi { get; set; }
        public string ansiklobedi { get; set; }
        public abstract void oku();
    }

    public class Kitap : Kütüphane
    {
        public override void oku()
        {
            Console.WriteLine("kitap okundu");
        }
   
    }
    public class Dergi : Kütüphane
    {
        public override void oku()
        {
            Console.WriteLine("dergi okundu");

        }
    }
    public class Ansiklopedi : Kütüphane
    {
        public override void oku()
        {
            Console.WriteLine("ansiklopedi okundu");
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap();
            k.Kitapadi = "huzur";
            Console.Write("{0} adlı ", k.Kitapadi);
            k.oku();


            Dergi d = new Dergi();
            d.dergiadi = "yeşil ev";
            Console.Write("{0} adlı ", d.dergiadi);
            d.oku();



            Ansiklopedi a = new Ansiklopedi();
            a.ansiklobedi = "psikopat";
            Console.Write("{0} adlı ", a.ansiklobedi);
            a.oku();




            Console.ReadLine();
                
        }
    }
}
